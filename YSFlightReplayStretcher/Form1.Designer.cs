namespace YSFlightReplayStretcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.FileNameHolder = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Step1 = new System.Windows.Forms.Label();
            this.Step2 = new System.Windows.Forms.Label();
            this.Step2_0 = new System.Windows.Forms.Label();
            this.Step2_1 = new System.Windows.Forms.Label();
            this.RecordingFPS = new System.Windows.Forms.TextBox();
            this.PlaybackFPS = new System.Windows.Forms.TextBox();
            this.Step2_2 = new System.Windows.Forms.Label();
            this.Step3 = new System.Windows.Forms.Label();
            this.Step3_0 = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.ProcessText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileBrowser
            // 
            this.FileBrowser.DefaultExt = "yfs";
            this.FileBrowser.FileName = "*.yfs";
            this.FileBrowser.Filter = "\"YSFlight Replay File|*.yfs|All Files|*.*\"";
            this.FileBrowser.InitialDirectory = "./";
            this.FileBrowser.Title = "Select YSFlight Replay File";
            // 
            // FileNameHolder
            // 
            this.FileNameHolder.AllowDrop = true;
            this.FileNameHolder.Location = new System.Drawing.Point(15, 36);
            this.FileNameHolder.Name = "FileNameHolder";
            this.FileNameHolder.Size = new System.Drawing.Size(556, 20);
            this.FileNameHolder.TabIndex = 0;
            this.FileNameHolder.Text = "*.yfs";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(577, 36);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.ShowDialog);
            // 
            // Step1
            // 
            this.Step1.AutoSize = true;
            this.Step1.Location = new System.Drawing.Point(12, 20);
            this.Step1.Name = "Step1";
            this.Step1.Size = new System.Drawing.Size(119, 13);
            this.Step1.TabIndex = 2;
            this.Step1.Text = "Step 1: Enter File Name";
            // 
            // Step2
            // 
            this.Step2.AutoSize = true;
            this.Step2.Location = new System.Drawing.Point(12, 59);
            this.Step2.Name = "Step2";
            this.Step2.Size = new System.Drawing.Size(177, 13);
            this.Step2.TabIndex = 3;
            this.Step2.Text = "Step 2: Choose Target Frame Rates";
            // 
            // Step2_0
            // 
            this.Step2_0.AutoSize = true;
            this.Step2_0.Location = new System.Drawing.Point(48, 75);
            this.Step2_0.Name = "Step2_0";
            this.Step2_0.Size = new System.Drawing.Size(54, 13);
            this.Step2_0.TabIndex = 4;
            this.Step2_0.Text = "Record at";
            // 
            // Step2_1
            // 
            this.Step2_1.AutoSize = true;
            this.Step2_1.Location = new System.Drawing.Point(235, 75);
            this.Step2_1.Name = "Step2_1";
            this.Step2_1.Size = new System.Drawing.Size(177, 13);
            this.Step2_1.TabIndex = 5;
            this.Step2_1.Text = "Frames per second, But playback at";
            // 
            // RecordingFPS
            // 
            this.RecordingFPS.Location = new System.Drawing.Point(108, 72);
            this.RecordingFPS.Name = "RecordingFPS";
            this.RecordingFPS.Size = new System.Drawing.Size(121, 20);
            this.RecordingFPS.TabIndex = 6;
            this.RecordingFPS.Text = "5";
            // 
            // PlaybackFPS
            // 
            this.PlaybackFPS.Location = new System.Drawing.Point(418, 72);
            this.PlaybackFPS.Name = "PlaybackFPS";
            this.PlaybackFPS.Size = new System.Drawing.Size(121, 20);
            this.PlaybackFPS.TabIndex = 7;
            this.PlaybackFPS.Text = "30";
            // 
            // Step2_2
            // 
            this.Step2_2.AutoSize = true;
            this.Step2_2.Location = new System.Drawing.Point(545, 75);
            this.Step2_2.Name = "Step2_2";
            this.Step2_2.Size = new System.Drawing.Size(100, 13);
            this.Step2_2.TabIndex = 8;
            this.Step2_2.Text = "Frames per second.";
            // 
            // Step3
            // 
            this.Step3.AutoSize = true;
            this.Step3.Location = new System.Drawing.Point(12, 88);
            this.Step3.Name = "Step3";
            this.Step3.Size = new System.Drawing.Size(85, 13);
            this.Step3.TabIndex = 9;
            this.Step3.Text = "Step 3: Process!";
            // 
            // Step3_0
            // 
            this.Step3_0.AutoSize = true;
            this.Step3_0.Location = new System.Drawing.Point(48, 101);
            this.Step3_0.Name = "Step3_0";
            this.Step3_0.Size = new System.Drawing.Size(314, 13);
            this.Step3_0.TabIndex = 10;
            this.Step3_0.Text = "Press the \"Process\" Button below to Make your adjusted Replay!";
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(577, 170);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(75, 23);
            this.Process.TabIndex = 11;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(15, 170);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(556, 23);
            this.Progress.TabIndex = 12;
            // 
            // ProcessText
            // 
            this.ProcessText.AutoSize = true;
            this.ProcessText.ForeColor = System.Drawing.Color.Gold;
            this.ProcessText.Location = new System.Drawing.Point(12, 154);
            this.ProcessText.Name = "ProcessText";
            this.ProcessText.Size = new System.Drawing.Size(163, 13);
            this.ProcessText.TabIndex = 13;
            this.ProcessText.Text = "Process: Processing Not Started.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 202);
            this.Controls.Add(this.ProcessText);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.Step3_0);
            this.Controls.Add(this.Step3);
            this.Controls.Add(this.Step2_2);
            this.Controls.Add(this.PlaybackFPS);
            this.Controls.Add(this.RecordingFPS);
            this.Controls.Add(this.Step2_1);
            this.Controls.Add(this.Step2_0);
            this.Controls.Add(this.Step2);
            this.Controls.Add(this.Step1);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.FileNameHolder);
            this.Name = "Form1";
            this.Text = "YSFlight Replay Stretcher: .YFS to .AVI Screen Recorder Assitant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FileBrowser;
        private System.Windows.Forms.TextBox FileNameHolder;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label Step1;
        private System.Windows.Forms.Label Step2;
        private System.Windows.Forms.Label Step2_0;
        private System.Windows.Forms.Label Step2_1;
        private System.Windows.Forms.TextBox RecordingFPS;
        private System.Windows.Forms.TextBox PlaybackFPS;
        private System.Windows.Forms.Label Step2_2;
        private System.Windows.Forms.Label Step3;
        private System.Windows.Forms.Label Step3_0;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label ProcessText;
    }
}

