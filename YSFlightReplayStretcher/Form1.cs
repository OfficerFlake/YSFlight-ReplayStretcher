using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace YSFlightReplayStretcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowDialog(object sender, EventArgs e)
        {
            if (FileBrowser.ShowDialog() == DialogResult.OK)
            {
                FileNameHolder.Text = FileBrowser.FileName;
            }
        }

        private void Process_Click(object sender, EventArgs e)
        {
            double RecordAtFPS = 5;
            double PlayAtFPS = 30;
            if((!double.TryParse(RecordingFPS.Text, out RecordAtFPS)) || (!double.TryParse(PlaybackFPS.Text, out PlayAtFPS))) {
                ProcessText.Text = "Error: Recording or Playback FPS is not a number! (" + RecordingFPS.Text + ") (" + PlaybackFPS.Text + ")";
                ProcessText.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if((RecordAtFPS < 0) || (PlayAtFPS < 0)) {
                ProcessText.Text = "Error: Recording or Playback FPS is NEGATIVE!";
                ProcessText.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if(!(File.Exists(FileNameHolder.Text)))
            {
                ProcessText.Text = "Error: Filename For Reading is Invalid.";
                ProcessText.ForeColor = System.Drawing.Color.Red;
                return;
            }
            FileNameHolder.ReadOnly = true;
            RecordingFPS.ReadOnly = true;
            PlaybackFPS.ReadOnly = true;
            Browse.Enabled = false;
            Process.Text = "Busy...";
            Process.Enabled = false;
            ProcessText.Text = "Processing Started.";
            ProcessText.ForeColor = System.Drawing.Color.Gold;
            Replay_Processor(FileNameHolder.Text, RecordAtFPS, PlayAtFPS);
        }

        public void Replay_Processor(string FileName, double Record, double Playback)
        {
            string[] Contents = File.ReadAllLines(FileName);
            int i = 0;
            while (i <= Contents.Length - 1)
            {
                ProcessText.Text = "Progress: " + ((int)(((double)i / (double)Contents.Length) * 100)).ToString() + "%";
                ProcessText.Refresh();
                Progress.Value = (int)(((double)i / (double)Contents.Length) * 100);
                Progress.Refresh();
                if (Contents[i].ToLower().StartsWith("YFSVERSI ".ToLower())) {
                    //System.Threading.Thread.Sleep(1000);
                }
                else if (Contents[i].ToLower().StartsWith("AIRPLANE ".ToLower())) {
                    //System.Threading.Thread.Sleep(1000);
                    while (i < Contents.Length - 1)
                    {
                        //System.Threading.Thread.Sleep(1000);
                        i += 1;
                        ProcessText.Text = "Progress: " + ((int)(((double)i / (double)Contents.Length) * 100)).ToString() + "%";
                        ProcessText.Refresh();
                        Progress.Value = (int)(((double)i / (double)Contents.Length) * 100);
                        Progress.Refresh();
                        Application.DoEvents();
                        if (Contents[i].ToLower().StartsWith("NUMRECOR ".ToLower()))
                        {
                            ProcessText.Text = Contents[i];
                            ProcessText.Refresh();
                            Application.DoEvents();
                            //System.Threading.Thread.Sleep(1000);
                            i += 1;
                            while (true) {
                            if (i + 4 < Contents.Length - 1)
                            {
                                double currentvalue;
                                if (!(double.TryParse(Contents[i], out currentvalue)))
                                {
                                    //We're now outside of this aircraft scope. Break the loop!
                                    //ProcessText.Text = "Break!: " + Contents[i];
                                    //ProcessText.Refresh();
                                    Application.DoEvents();
                                    //System.Threading.Thread.Sleep(1000);
                                    break;
                                }
                                else
                                {
                                    //ProcessText.Text = "TIME: " + Contents[i] + "NEW: " + (Playback / Record * currentvalue).ToString();
                                    Contents[i] = (Playback / Record * currentvalue).ToString();
                                    //ProcessText.Refresh();
                                    //Application.DoEvents();
                                    //System.Threading.Thread.Sleep(100);
                                }
                                //System.Threading.Thread.Sleep(1000);
                                i += 4;
                                if (ProcessText.Text != ((int)(((double)i / (double)Contents.Length) * 100)).ToString())
                                {
                                    ProcessText.Text = "Progress: " + ((int)(((double)i / (double)Contents.Length) * 100)).ToString() + "%";
                                    ProcessText.Refresh();
                                    Progress.Value = (int)(((double)i / (double)Contents.Length) * 100);
                                    Progress.Refresh();
                                    Application.DoEvents();
                                }
                            }
                            else
                            {
                                ProcessText.Text = "Error at line " + i.ToString() + ": Expected a Flight Record Packet, but got cut short instead!";
                                ProcessText.ForeColor = System.Drawing.Color.Red;
                                ProcessText.Refresh();
                                return;
                            }
                            }
                        }
                    }
                }
                i += 1;
            }
            ProcessText.Text = "Done!";
            ProcessText.ForeColor = System.Drawing.Color.Green;
            Progress.Value = 100;
            FileNameHolder.ReadOnly = false;
            File.WriteAllLines(FileNameHolder.Text.Remove(FileNameHolder.Text.Length - 4) + "_Processed.yfs", Contents);
            RecordingFPS.ReadOnly = false;
            PlaybackFPS.ReadOnly = false;
            Process.Text = "Process";
            Process.Enabled = true;
            Browse.Enabled = true;
            return;
        }
    }
}
