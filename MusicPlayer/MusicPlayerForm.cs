using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Wma;
using Un4seen.Bass.AddOn.Tags;
using System.Xml;
using System.Xml.Linq;

using OpenTK.Graphics.OpenGL;

namespace MusicPlayer
{
    public partial class MusicPlayerForm : Form
    {
        public BassSimpleLogic Sound = new BassSimpleLogic();
        public TagInfoRadio tags;
        public String clientIP;
        public event EventHandler<TagsEventArgs> NewTagEvent = delegate { };

        public MusicPlayerForm()
        {
            TagRadioManager.NewTagEvent += AddItemAsync;
            InitializeComponent();
            Sound.InitBass(Sound.samplingFrequency);
            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, this.Handle))
                MessageBox.Show(this, "Wrong Bass Version!");
            updatePlaylist();
            btnConnect.Enabled = false;
            bckWorkerVisual.RunWorkerAsync();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openMusicFileDialog.ShowDialog();
        }

        private void openMusicFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string[] tmp = openMusicFileDialog.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                Files.files.Add(tmp[i]);
                TagModel TM = new TagModel(tmp[i]);
                ListViewItem item;
                if ((TM.Artist == "") || (TM.Title == ""))
                    item = new ListViewItem(Files.GetFileName(tmp[i]));
                else
                    item = new ListViewItem(TM.Artist + " - " + TM.Title);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, TimeSpan.FromSeconds(Sound.GetLengthOfStream(Bass.BASS_StreamCreateFile(tmp[i], 0, 0, BASSFlag.BASS_DEFAULT))).ToString()));
                
                MusicListView.Items.Add(item);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if ((MusicListView.Items.Count != 0) && (MusicListView.SelectedItems.Count != 0))
            {
                string currentTrack = Files.files[MusicListView.SelectedItems[0].Index];
                if (Files.CurrentTrackNumber != MusicListView.SelectedItems[0].Index)
                {
                    Sound.Stop();
                }
                Files.CurrentTrackNumber = MusicListView.SelectedItems[0].Index;
                MusicListView.Select();
                MusicListView.Items[Files.CurrentTrackNumber].Selected = true;
                timerTrack.Enabled = true;
                Sound.Play(currentTrack, Sound.Volume);
                labelMusicPos.Text = TimeSpan.FromSeconds(Sound.GetPositionOfStream(Sound.Stream)).ToString();
                SliderMusicPos.Maximum = Sound.GetTimeOfStream(Sound.Stream);
                SliderMusicPos.Value = Sound.GetPositionOfStream(Sound.Stream);
            }
        }

        private void timerTrack_Tick(object sender, EventArgs e)
        {
            labelMusicPos.Text = TimeSpan.FromSeconds(Sound.GetPositionOfStream(Sound.Stream)).ToString();
            SliderMusicPos.Value = Sound.GetPositionOfStream(Sound.Stream);

            if (Sound.ToNextTrack())
            {
                MusicListView.Select();
                MusicListView.Items[Files.CurrentTrackNumber].Selected = true;
                labelMusicPos.Text = TimeSpan.FromSeconds(Sound.GetPositionOfStream(Sound.Stream)).ToString();
                SliderMusicPos.Maximum = Sound.GetTimeOfStream(Sound.Stream);
                SliderMusicPos.Value = Sound.GetPositionOfStream(Sound.Stream);
            }
        }


        private void SliderMusicPos_Scroll(object sender, ScrollEventArgs e)
        {
            Sound.SetPosOfScroll(Sound.Stream, SliderMusicPos.Value);
        }

        private void SliderVolume_Scroll(object sender, ScrollEventArgs e)
        {
            Sound.SetVolumeToStream(Sound.Stream, SliderVolume.Value);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerTrack.Enabled = false;
            Sound.Stop();
            SliderMusicPos.Value = 0;
            labelMusicPos.Text = "00:00:00";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (Sound.isPlaing)
            {
                Sound.Pause();
            }
        }

        private void MusicListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = MusicListView.Columns[e.ColumnIndex].Width;
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            float[] SpectrumArrayLeft = new float[1024];
            float[] SpectrumArrayRight = new float[1024];

            Bass.BASS_ChannelGetData(Sound.Stream, SpectrumArrayLeft, (int)BASSData.BASS_DATA_FFT2048);
            Bass.BASS_ChannelGetData(Sound.Stream, SpectrumArrayRight, (int)BASSData.BASS_DATA_FFT2048);

            double intensifier = 0.00324;
            System.Drawing.Color fool1 = Color.Blue;
            System.Drawing.Color fool2 = Color.Aqua;
            System.Drawing.Color fool3 = Color.FromArgb(((fool1.A) + (fool2.A)) / 2, ((fool1.R) + (fool2.R)) / 2, ((fool1.G) + (fool2.G)) / 2, ((fool1.B) + (fool2.B)) / 2);

            GL.Begin(BeginMode.Lines);
            GL.Color3(fool3);
            GL.Vertex2(-1, 0);
            GL.Color3(fool3);
            GL.Vertex2(1, 0);
            GL.End();
            int j = -325;
            double k = 0;
            for (double i = -1; i < 1; i += intensifier)
            {
                j++;
                if (j < 0)
                {
                    k = (SpectrumArrayLeft[j * -1]) * 2;
                    if (k > 0.9) { k = 0.9; }
                }
                else
                {
                    k = (SpectrumArrayRight[j]) * 2;
                    if (k > 0.9) { k = 0.9; }
                }
                GL.Begin(BeginMode.Lines);
                GL.Color3(fool1);
                GL.Vertex2(i, k);
                GL.Color3(fool2);
                GL.Vertex2(i, k * -1);
                GL.End();
            }
            glControl.SwapBuffers();
        }

        private void btnPlayRadio_Click(object sender, EventArgs e)
        {
            if ((lvRadio.Items.Count != 0) && (lvRadio.SelectedItems.Count != 0))
            {
                BassRadioPlayer.startBassStream(ParserXML.stations[lvRadio.SelectedItems[0].Index].Url, Sound.Volume);
                lblRadioName.Text = ParserXML.stations[lvRadio.SelectedItems[0].Index].Name;
                pictureRadio.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureRadio.ImageLocation = ParserXML.stations[lvRadio.SelectedItems[0].Index].Image;
                btnDisconnect.Enabled = true;
            }
        }

        private void AddItemAsync(Object sender, TagsEventArgs args)
        {
            if (lblArtist.InvokeRequired)
            {
                lblArtist.Invoke((MethodInvoker)delegate()
                {
                    lblArtist.Text = args.TagProp.Artist;
                    lblTitle.Text = args.TagProp.Titles;
                    lblUrl.Text = args.TagProp.CustomUrl;
                });
            }
        }

        private void btnLoadStations_Click(object sender, EventArgs e)
        {
            updatePlaylist();
        }

        private void RadioSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Sound.SetVolumeToStream(BassRadioPlayer.RadioStream, SliderVolume.Value);
        }

        private void bckWorkerVisual_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                System.Threading.Thread.Sleep(40);

                try
                {
                    glControl.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Error of input ip");
                }
            }
        }

        private void rbServer_CheckedChanged(object sender, EventArgs e)
        {
            textBoxIP.Enabled = true;
            btnConnect.Enabled = false;
            btnStartServer.Enabled = true;
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            textBoxIP.Enabled = false;
            btnConnect.Enabled = true;
            btnStartServer.Enabled = false;
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (btnStartServer.Text == "Start Server")
            {
                Server.Client_IP = textBoxIP.Text;
                if ((Server.Client_IP == null) || (Server.Client_IP == ""))
                {
                    MessageBox.Show("Error of input ip");
                    return;
                }
                Server.connected = true;
                ThreadPool.QueueUserWorkItem(Server.Music_Input, Sound.Stream);

                btnStartServer.Text = "Stop Server";
            }
            else
            {
                Server.connected = false;
                btnStartServer.Text = "Start Server";
            }
        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            ParserXML.addNewStation(tbStationUrl.Text, tbStationName.Text, tbImageUrl.Text);
            updatePlaylist();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                Client.connected = true;
                ThreadPool.QueueUserWorkItem(new WaitCallback(Client.ClientThread));
                btnConnect.Text = "Disconnect";
            }
            else
            {
                Client.connected = false;
                btnConnect.Text = "Connect";
            }
        }

        public void updatePlaylist()
        {
            lvRadio.Items.Clear();
            foreach (Station stat in ParserXML.stations)
                lvRadio.Items.Add(stat.Name);
        }

        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
            if ((lvRadio.Items.Count != 0) && (lvRadio.SelectedItems.Count != 0))
            {
                ParserXML.deleteStation(lvRadio.SelectedItems[0].Index);
                updatePlaylist();
            }
        }

        private void MusicPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bass.BASS_StreamFree(BassRadioPlayer.RadioStream);
            Bass.BASS_StreamFree(Sound.Stream);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Bass.BASS_StreamFree(BassRadioPlayer.RadioStream);
            btnDisconnect.Enabled = false;
            lblArtist.Text = "";
            lblTitle.Text = "";
            lblRadioName.Text = "";
            pictureRadio.ImageLocation = "";
        }

        private void btnRemoveTrack_Click(object sender, EventArgs e)
        {
            if ((MusicListView.Items.Count != 0) && (MusicListView.SelectedItems.Count != 0))
            {
                if (Files.CurrentTrackNumber == MusicListView.SelectedItems[0].Index)
                {
                    Sound.Stop();
                    labelMusicPos.Text = "00:00:00";
                    SliderMusicPos.Value = 0;
                    timerTrack.Stop();
                }
                Files.files.RemoveAt(MusicListView.SelectedItems[0].Index);
                MusicListView.SelectedItems[0].Remove();
            }
        }

        private void SliderRadioVolume_Scroll(object sender, ScrollEventArgs e)
        {
            BassRadioPlayer.SetVolumeToStream(BassRadioPlayer.RadioStream, SliderRadioVolume.Value);
        }
    }
}
