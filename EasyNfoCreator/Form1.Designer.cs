namespace EasyNfoCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TB_EpisodeRule = new TextBox();
            label5 = new Label();
            NUD_Season = new NumericUpDown();
            label4 = new Label();
            TB_ShowTitle = new TextBox();
            label3 = new Label();
            LB_VideoCount = new Label();
            label2 = new Label();
            BTN_Run = new Button();
            BTN_SelectVideoPath = new Button();
            LLB_VideoFolder = new LinkLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)NUD_Season).BeginInit();
            SuspendLayout();
            // 
            // TB_EpisodeRule
            // 
            TB_EpisodeRule.Location = new Point(332, 89);
            TB_EpisodeRule.Name = "TB_EpisodeRule";
            TB_EpisodeRule.Size = new Size(282, 28);
            TB_EpisodeRule.TabIndex = 23;
            TB_EpisodeRule.Text = "\\d+";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 92);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 22;
            label5.Text = "集数正则:";
            // 
            // NUD_Season
            // 
            NUD_Season.Location = new Point(80, 89);
            NUD_Season.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUD_Season.Name = "NUD_Season";
            NUD_Season.Size = new Size(120, 28);
            NUD_Season.TabIndex = 21;
            NUD_Season.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 92);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 20;
            label4.Text = "季数:";
            // 
            // TB_ShowTitle
            // 
            TB_ShowTitle.Location = new Point(332, 55);
            TB_ShowTitle.Name = "TB_ShowTitle";
            TB_ShowTitle.Size = new Size(282, 28);
            TB_ShowTitle.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 58);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 18;
            label3.Text = "showtitle:";
            // 
            // LB_VideoCount
            // 
            LB_VideoCount.AutoSize = true;
            LB_VideoCount.Location = new Point(176, 58);
            LB_VideoCount.Name = "LB_VideoCount";
            LB_VideoCount.Size = new Size(19, 21);
            LB_VideoCount.TabIndex = 17;
            LB_VideoCount.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 58);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 16;
            label2.Text = "当前目录视频数目:";
            // 
            // BTN_Run
            // 
            BTN_Run.Location = new Point(484, 131);
            BTN_Run.Name = "BTN_Run";
            BTN_Run.Size = new Size(144, 57);
            BTN_Run.TabIndex = 15;
            BTN_Run.Text = "运行";
            BTN_Run.UseVisualStyleBackColor = true;
            BTN_Run.Click += BTN_Run_Click;
            // 
            // BTN_SelectVideoPath
            // 
            BTN_SelectVideoPath.Location = new Point(517, 17);
            BTN_SelectVideoPath.Name = "BTN_SelectVideoPath";
            BTN_SelectVideoPath.Size = new Size(97, 35);
            BTN_SelectVideoPath.TabIndex = 14;
            BTN_SelectVideoPath.Text = "选择";
            BTN_SelectVideoPath.UseVisualStyleBackColor = true;
            BTN_SelectVideoPath.Click += BTN_SelectVideoPath_Click;
            // 
            // LLB_VideoFolder
            // 
            LLB_VideoFolder.LinkColor = Color.FromArgb(255, 128, 0);
            LLB_VideoFolder.Location = new Point(112, 24);
            LLB_VideoFolder.Name = "LLB_VideoFolder";
            LLB_VideoFolder.Size = new Size(399, 21);
            LLB_VideoFolder.TabIndex = 13;
            LLB_VideoFolder.TabStop = true;
            LLB_VideoFolder.Text = "未选择";
            LLB_VideoFolder.LinkClicked += LLB_VideoFolder_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 12;
            label1.Text = "视频目录:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 204);
            Controls.Add(TB_EpisodeRule);
            Controls.Add(label5);
            Controls.Add(NUD_Season);
            Controls.Add(label4);
            Controls.Add(TB_ShowTitle);
            Controls.Add(label3);
            Controls.Add(LB_VideoCount);
            Controls.Add(label2);
            Controls.Add(BTN_Run);
            Controls.Add(BTN_SelectVideoPath);
            Controls.Add(LLB_VideoFolder);
            Controls.Add(label1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NUD_Season).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_EpisodeRule;
        private Label label5;
        private NumericUpDown NUD_Season;
        private Label label4;
        private TextBox TB_ShowTitle;
        private Label label3;
        private Label LB_VideoCount;
        private Label label2;
        private Button BTN_Run;
        private Button BTN_SelectVideoPath;
        private LinkLabel LLB_VideoFolder;
        private Label label1;
    }
}
