using MediaInfo;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EasyNfoCreator
{
    public partial class Form1 : Form
    {
        private readonly ILogger<Form1> _logger;
        private string[] supportedVideoFormat = { "mp4", "avi", "mkv", "mov", "wmv", "flv", "mpeg", "webm", "ts", "m2ts" };
        private List<string> videoFiles = new();

        public Form1(ILogger<Form1> logger)
        {
            InitializeComponent();
            _logger = logger;
        }

        private bool FormatSupported(string file)
        {
            foreach (var item in supportedVideoFormat)
            {
                if (file.EndsWith("." + item, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private void GetVideos()
        {
            videoFiles.Clear();

            if (Directory.Exists(LLB_VideoFolder.Text))
            {
                string[] files = Directory.GetFiles(LLB_VideoFolder.Text, "*.*", SearchOption.TopDirectoryOnly);
                int videoFilesCount = 0;

                foreach (string file in files)
                {
                    if (FormatSupported(file))
                    {
                        videoFiles.Add(file);
                        videoFilesCount++;
                    }
                }

                LB_VideoCount.Text = videoFilesCount.ToString();
            }
        }

        private void Run()
        {
            string videoFolder = LLB_VideoFolder.Text;

            try
            {
                foreach (string file in videoFiles)
                {
                    // ʹ��MediaInfo��ȡ��Ƶ��Ϣ
                    var mediaInfo = new MediaInfoWrapper(file, _logger);
                    try
                    {
                        // ��ȡ��Ƶ��Ϣ
                        string title = Path.GetFileNameWithoutExtension(file);
                        string episodeNumber = title;
                        string pattern = TB_EpisodeRule.Text;
                        if (pattern != string.Empty)
                        {
                            Regex regex = new(pattern);
                            Match match = regex.Match(title);
                            if (match.Success)
                            {
                                episodeNumber = match.Value;
                            }
                            else
                            {
                                Debug.WriteLine("δ�ҵ����֡�");
                            }
                        }

                        string codec = mediaInfo.VideoCodec;
                        string aspect = mediaInfo.AspectRatio;
                        string width = mediaInfo.Width.ToString();
                        string height = mediaInfo.Height.ToString();
                        string duration = mediaInfo.Duration.ToString();
                        string audioCodec = mediaInfo.AudioCodec;
                        string channels = mediaInfo.AudioChannels.ToString();

                        // ����XMLԪ��
                        XElement episodeElement = new("episodedetails",
                            new XElement("title", $"�� {episodeNumber} ��"),
                            new XElement("showtitle", TB_ShowTitle.Text),
                            new XElement("season", (int)NUD_Season.Value),
                            new XElement("episode", episodeNumber),
                            new XElement("fileinfo",
                                new XElement("streamdetails",
                                    new XElement("video",
                                        new XElement("codec", codec),
                                        new XElement("aspect", aspect),
                                        new XElement("width", width),
                                        new XElement("height", height),
                                        new XElement("durationinseconds", Convert.ToInt32(duration) / 1000) // ת��Ϊ��
                                    ),
                                    new XElement("audio",
                                        new XElement("codec", audioCodec),
                                        new XElement("channels", channels)
                                    )
                                )
                            ),
                            new XElement("original_filename", Path.GetFileName(file))
                        );

                        // ����������Nfo�ļ�
                        XDocument xmlDocument = new(
                            new XDeclaration("1.0", "UTF-8", "yes"),
                            episodeElement
                        );
                        string xmlOutputPath = LLB_VideoFolder.Text + "\\" + title + ".nfo";
                        xmlDocument.Save(xmlOutputPath);

                        Debug.WriteLine("��Ƶ��Ϣ�ѳɹ�д��Nfo�ļ���");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("����" + ex.Message);
                    }
                }

                MessageBox.Show("������ϣ�", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"������Ƶ�ļ�ʱ����: {ex.Message}");
            }
        }

        private void LLB_VideoFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LLB_VideoFolder.Text == string.Empty || LLB_VideoFolder.Text == "δѡ��")
            {
                return;
            }
            else
            {
                if (Directory.Exists(LLB_VideoFolder.Text))
                {
                    try
                    {
                        System.Diagnostics.Process.Start("explorer", LLB_VideoFolder.Text);
                    }
                    catch
                    {
                        MessageBox.Show("·��������ȷ��·���Ƿ���ڣ�", "·������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BTN_SelectVideoPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LLB_VideoFolder.Text = dialog.SelectedPath;
                GetVideos();
            }
        }

        private void BTN_Run_Click(object sender, EventArgs e)
        {
            if (LLB_VideoFolder.Text == string.Empty || LLB_VideoFolder.Text == "δѡ��" || !Directory.Exists(LLB_VideoFolder.Text))
            {
                return;
            }
            else
            {
                Run();
            }
        }
    }
}
