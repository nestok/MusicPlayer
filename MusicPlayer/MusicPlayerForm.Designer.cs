namespace MusicPlayer
{
    partial class MusicPlayerForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPlayRadio = new System.Windows.Forms.Button();
            this.labelMusicPos = new System.Windows.Forms.Label();
            this.openMusicFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerTrack = new System.Windows.Forms.Timer(this.components);
            this.MusicListView = new System.Windows.Forms.ListView();
            this.Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.glControl = new OpenTK.GLControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpPlayer = new System.Windows.Forms.TabPage();
            this.btnRemoveTrack = new System.Windows.Forms.Button();
            this.SliderVolume = new MB.Controls.ColorSlider();
            this.SliderMusicPos = new MB.Controls.ColorSlider();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tpRadio = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbImageUrl = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnDeleteStation = new System.Windows.Forms.Button();
            this.lblStationName = new System.Windows.Forms.Label();
            this.tbStationName = new System.Windows.Forms.TextBox();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.lblRadioUrl = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.tbStationUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRadioName = new System.Windows.Forms.Label();
            this.pictureRadio = new System.Windows.Forms.PictureBox();
            this.lvRadio = new System.Windows.Forms.ListView();
            this.Station = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpStream = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.bckWorkerVisual = new System.ComponentModel.BackgroundWorker();
            this.SliderRadioVolume = new MB.Controls.ColorSlider();
            this.tabControl.SuspendLayout();
            this.tpPlayer.SuspendLayout();
            this.tpRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRadio)).BeginInit();
            this.tpStream.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayRadio
            // 
            this.btnPlayRadio.Location = new System.Drawing.Point(12, 233);
            this.btnPlayRadio.Name = "btnPlayRadio";
            this.btnPlayRadio.Size = new System.Drawing.Size(75, 23);
            this.btnPlayRadio.TabIndex = 1;
            this.btnPlayRadio.Text = "PlayRadio";
            this.btnPlayRadio.UseVisualStyleBackColor = true;
            this.btnPlayRadio.Click += new System.EventHandler(this.btnPlayRadio_Click);
            // 
            // labelMusicPos
            // 
            this.labelMusicPos.AutoSize = true;
            this.labelMusicPos.Location = new System.Drawing.Point(12, 265);
            this.labelMusicPos.Name = "labelMusicPos";
            this.labelMusicPos.Size = new System.Drawing.Size(49, 13);
            this.labelMusicPos.TabIndex = 6;
            this.labelMusicPos.Text = "00:00:00";
            // 
            // openMusicFileDialog
            // 
            this.openMusicFileDialog.FileName = "openMusicFileDialog";
            this.openMusicFileDialog.Filter = "Все форматы|*.mp3; *.mp4; *.m4a; *.alac; *.ogg; *.opus; *.ac3; *.ape; *.mpc; *.fl" +
    "ac; *.wma; *.tta; *.alac; *.wv";
            this.openMusicFileDialog.Multiselect = true;
            this.openMusicFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openMusicFileDialog_FileOk);
            // 
            // timerTrack
            // 
            this.timerTrack.Interval = 1000;
            this.timerTrack.Tick += new System.EventHandler(this.timerTrack_Tick);
            // 
            // MusicListView
            // 
            this.MusicListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Music,
            this.Time});
            this.MusicListView.FullRowSelect = true;
            this.MusicListView.GridLines = true;
            this.MusicListView.Location = new System.Drawing.Point(0, 306);
            this.MusicListView.MultiSelect = false;
            this.MusicListView.Name = "MusicListView";
            this.MusicListView.Size = new System.Drawing.Size(370, 129);
            this.MusicListView.TabIndex = 7;
            this.MusicListView.UseCompatibleStateImageBehavior = false;
            this.MusicListView.View = System.Windows.Forms.View.Details;
            this.MusicListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.MusicListView_ColumnWidthChanging);
            this.MusicListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btnPlay_Click);
            // 
            // Music
            // 
            this.Music.Text = "Music";
            this.Music.Width = 261;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 88;
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Location = new System.Drawing.Point(-38, 0);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(410, 197);
            this.glControl.TabIndex = 11;
            this.glControl.VSync = false;
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpPlayer);
            this.tabControl.Controls.Add(this.tpRadio);
            this.tabControl.Controls.Add(this.tpStream);
            this.tabControl.Location = new System.Drawing.Point(-4, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(376, 459);
            this.tabControl.TabIndex = 12;
            // 
            // tpPlayer
            // 
            this.tpPlayer.Controls.Add(this.btnRemoveTrack);
            this.tpPlayer.Controls.Add(this.SliderVolume);
            this.tpPlayer.Controls.Add(this.SliderMusicPos);
            this.tpPlayer.Controls.Add(this.glControl);
            this.tpPlayer.Controls.Add(this.btnPause);
            this.tpPlayer.Controls.Add(this.MusicListView);
            this.tpPlayer.Controls.Add(this.labelMusicPos);
            this.tpPlayer.Controls.Add(this.btnStop);
            this.tpPlayer.Controls.Add(this.btnPlay);
            this.tpPlayer.Controls.Add(this.btnOpenFile);
            this.tpPlayer.Location = new System.Drawing.Point(4, 22);
            this.tpPlayer.Name = "tpPlayer";
            this.tpPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayer.Size = new System.Drawing.Size(368, 433);
            this.tpPlayer.TabIndex = 0;
            this.tpPlayer.Text = "Player";
            this.tpPlayer.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTrack
            // 
            this.btnRemoveTrack.Image = global::MusicPlayer.Properties.Resources.Player_Delete1;
            this.btnRemoveTrack.Location = new System.Drawing.Point(216, 214);
            this.btnRemoveTrack.Name = "btnRemoveTrack";
            this.btnRemoveTrack.Size = new System.Drawing.Size(48, 48);
            this.btnRemoveTrack.TabIndex = 14;
            this.btnRemoveTrack.UseVisualStyleBackColor = true;
            this.btnRemoveTrack.Click += new System.EventHandler(this.btnRemoveTrack_Click);
            // 
            // SliderVolume
            // 
            this.SliderVolume.BackColor = System.Drawing.Color.Transparent;
            this.SliderVolume.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.SliderVolume.LargeChange = ((uint)(5u));
            this.SliderVolume.Location = new System.Drawing.Point(272, 282);
            this.SliderVolume.Name = "SliderVolume";
            this.SliderVolume.Size = new System.Drawing.Size(86, 18);
            this.SliderVolume.SmallChange = ((uint)(1u));
            this.SliderVolume.TabIndex = 13;
            this.SliderVolume.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.SliderVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SliderVolume_Scroll);
            // 
            // SliderMusicPos
            // 
            this.SliderMusicPos.BackColor = System.Drawing.Color.Transparent;
            this.SliderMusicPos.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.SliderMusicPos.LargeChange = ((uint)(5u));
            this.SliderMusicPos.Location = new System.Drawing.Point(12, 282);
            this.SliderMusicPos.Name = "SliderMusicPos";
            this.SliderMusicPos.Size = new System.Drawing.Size(243, 18);
            this.SliderMusicPos.SmallChange = ((uint)(1u));
            this.SliderMusicPos.TabIndex = 12;
            this.SliderMusicPos.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.SliderMusicPos.Value = 0;
            this.SliderMusicPos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SliderMusicPos_Scroll);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::MusicPlayer.Properties.Resources.Player_Pause;
            this.btnPause.Location = new System.Drawing.Point(80, 214);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(48, 48);
            this.btnPause.TabIndex = 10;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::MusicPlayer.Properties.Resources.Player_Stop;
            this.btnStop.Location = new System.Drawing.Point(148, 214);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 48);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::MusicPlayer.Properties.Resources.Player_Play;
            this.btnPlay.Location = new System.Drawing.Point(12, 214);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 48);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = global::MusicPlayer.Properties.Resources.orange_folder_open_7278;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFile.Location = new System.Drawing.Point(284, 214);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(48, 48);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // tpRadio
            // 
            this.tpRadio.Controls.Add(this.SliderRadioVolume);
            this.tpRadio.Controls.Add(this.label2);
            this.tpRadio.Controls.Add(this.tbImageUrl);
            this.tpRadio.Controls.Add(this.btnDisconnect);
            this.tpRadio.Controls.Add(this.btnDeleteStation);
            this.tpRadio.Controls.Add(this.lblStationName);
            this.tpRadio.Controls.Add(this.tbStationName);
            this.tpRadio.Controls.Add(this.btnAddStation);
            this.tpRadio.Controls.Add(this.lblRadioUrl);
            this.tpRadio.Controls.Add(this.labelAdd);
            this.tpRadio.Controls.Add(this.tbStationUrl);
            this.tpRadio.Controls.Add(this.lblUrl);
            this.tpRadio.Controls.Add(this.lblArtist);
            this.tpRadio.Controls.Add(this.lblTitle);
            this.tpRadio.Controls.Add(this.lblRadioName);
            this.tpRadio.Controls.Add(this.pictureRadio);
            this.tpRadio.Controls.Add(this.lvRadio);
            this.tpRadio.Controls.Add(this.btnPlayRadio);
            this.tpRadio.Location = new System.Drawing.Point(4, 22);
            this.tpRadio.Name = "tpRadio";
            this.tpRadio.Padding = new System.Windows.Forms.Padding(3);
            this.tpRadio.Size = new System.Drawing.Size(368, 433);
            this.tpRadio.TabIndex = 1;
            this.tpRadio.Text = "Radio";
            this.tpRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Input image url:";
            // 
            // tbImageUrl
            // 
            this.tbImageUrl.Location = new System.Drawing.Point(12, 162);
            this.tbImageUrl.Name = "tbImageUrl";
            this.tbImageUrl.Size = new System.Drawing.Size(100, 20);
            this.tbImageUrl.TabIndex = 19;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(97, 233);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 18;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.Location = new System.Drawing.Point(181, 233);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStation.TabIndex = 17;
            this.btnDeleteStation.Text = "Delete";
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Location = new System.Drawing.Point(12, 99);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(97, 13);
            this.lblStationName.TabIndex = 16;
            this.lblStationName.Text = "Input station name:";
            // 
            // tbStationName
            // 
            this.tbStationName.Location = new System.Drawing.Point(12, 115);
            this.tbStationName.Name = "tbStationName";
            this.tbStationName.Size = new System.Drawing.Size(100, 20);
            this.tbStationName.TabIndex = 15;
            // 
            // btnAddStation
            // 
            this.btnAddStation.Location = new System.Drawing.Point(12, 191);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(75, 23);
            this.btnAddStation.TabIndex = 14;
            this.btnAddStation.Text = "Add";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // lblRadioUrl
            // 
            this.lblRadioUrl.AutoSize = true;
            this.lblRadioUrl.Location = new System.Drawing.Point(9, 56);
            this.lblRadioUrl.Name = "lblRadioUrl";
            this.lblRadioUrl.Size = new System.Drawing.Size(93, 13);
            this.lblRadioUrl.TabIndex = 13;
            this.lblRadioUrl.Text = "Input stream URL:";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(9, 30);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(115, 13);
            this.labelAdd.TabIndex = 12;
            this.labelAdd.Text = "Add New RadioStation";
            // 
            // tbStationUrl
            // 
            this.tbStationUrl.Location = new System.Drawing.Point(12, 72);
            this.tbStationUrl.Name = "tbStationUrl";
            this.tbStationUrl.Size = new System.Drawing.Size(100, 20);
            this.tbStationUrl.TabIndex = 11;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(247, 145);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(0, 13);
            this.lblUrl.TabIndex = 10;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(169, 47);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(0, 13);
            this.lblArtist.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(169, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTitle.TabIndex = 8;
            // 
            // lblRadioName
            // 
            this.lblRadioName.AutoSize = true;
            this.lblRadioName.Location = new System.Drawing.Point(172, 81);
            this.lblRadioName.Name = "lblRadioName";
            this.lblRadioName.Size = new System.Drawing.Size(0, 13);
            this.lblRadioName.TabIndex = 5;
            // 
            // pictureRadio
            // 
            this.pictureRadio.Location = new System.Drawing.Point(172, 99);
            this.pictureRadio.Name = "pictureRadio";
            this.pictureRadio.Size = new System.Drawing.Size(132, 115);
            this.pictureRadio.TabIndex = 4;
            this.pictureRadio.TabStop = false;
            // 
            // lvRadio
            // 
            this.lvRadio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Station});
            this.lvRadio.FullRowSelect = true;
            this.lvRadio.GridLines = true;
            this.lvRadio.Location = new System.Drawing.Point(0, 271);
            this.lvRadio.Name = "lvRadio";
            this.lvRadio.Size = new System.Drawing.Size(372, 166);
            this.lvRadio.TabIndex = 2;
            this.lvRadio.UseCompatibleStateImageBehavior = false;
            this.lvRadio.View = System.Windows.Forms.View.Details;
            this.lvRadio.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btnPlayRadio_Click);
            // 
            // Station
            // 
            this.Station.Text = "Station";
            this.Station.Width = 347;
            // 
            // tpStream
            // 
            this.tpStream.Controls.Add(this.label1);
            this.tpStream.Controls.Add(this.textBoxIP);
            this.tpStream.Controls.Add(this.btnConnect);
            this.tpStream.Controls.Add(this.btnStartServer);
            this.tpStream.Controls.Add(this.rbClient);
            this.tpStream.Controls.Add(this.rbServer);
            this.tpStream.Location = new System.Drawing.Point(4, 22);
            this.tpStream.Name = "tpStream";
            this.tpStream.Padding = new System.Windows.Forms.Padding(3);
            this.tpStream.Size = new System.Drawing.Size(368, 433);
            this.tpStream.TabIndex = 2;
            this.tpStream.Text = "Stream";
            this.tpStream.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input client ip:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(39, 124);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(209, 68);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(39, 69);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 2;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(209, 34);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(51, 17);
            this.rbClient.TabIndex = 1;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.CheckedChanged += new System.EventHandler(this.rbClient_CheckedChanged);
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Checked = true;
            this.rbServer.Location = new System.Drawing.Point(39, 34);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(56, 17);
            this.rbServer.TabIndex = 0;
            this.rbServer.TabStop = true;
            this.rbServer.Text = "Server";
            this.rbServer.UseVisualStyleBackColor = true;
            this.rbServer.CheckedChanged += new System.EventHandler(this.rbServer_CheckedChanged);
            // 
            // bckWorkerVisual
            // 
            this.bckWorkerVisual.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckWorkerVisual_DoWork);
            // 
            // SliderRadioVolume
            // 
            this.SliderRadioVolume.BackColor = System.Drawing.Color.Transparent;
            this.SliderRadioVolume.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.SliderRadioVolume.LargeChange = ((uint)(5u));
            this.SliderRadioVolume.Location = new System.Drawing.Point(269, 235);
            this.SliderRadioVolume.Name = "SliderRadioVolume";
            this.SliderRadioVolume.Size = new System.Drawing.Size(89, 19);
            this.SliderRadioVolume.SmallChange = ((uint)(1u));
            this.SliderRadioVolume.TabIndex = 21;
            this.SliderRadioVolume.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.SliderRadioVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SliderRadioVolume_Scroll);
            // 
            // MusicPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 456);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MusicPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusicPlayerForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tpPlayer.ResumeLayout(false);
            this.tpPlayer.PerformLayout();
            this.tpRadio.ResumeLayout(false);
            this.tpRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRadio)).EndInit();
            this.tpStream.ResumeLayout(false);
            this.tpStream.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayRadio;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
       // private MB.Controls.ColorSlider SliderMusicPos;
       // private MB.Controls.ColorSlider SliderVolume;
        private System.Windows.Forms.Label labelMusicPos;
        private System.Windows.Forms.OpenFileDialog openMusicFileDialog;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Timer timerTrack;
        private System.Windows.Forms.ListView MusicListView;
        private System.Windows.Forms.ColumnHeader Music;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Button btnPause;
        private OpenTK.GLControl glControl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpPlayer;
        private System.Windows.Forms.TabPage tpRadio;
        private System.Windows.Forms.ListView lvRadio;
        private System.Windows.Forms.ColumnHeader Station;
        private System.Windows.Forms.PictureBox pictureRadio;
        private System.Windows.Forms.Label lblRadioName;
        //private MB.Controls.ColorSlider RadioSlider;
        public System.Windows.Forms.Label lblUrl;
        public System.Windows.Forms.Label lblArtist;
        public System.Windows.Forms.Label lblTitle;
        private System.ComponentModel.BackgroundWorker bckWorkerVisual;
        private System.Windows.Forms.TabPage tpStream;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbServer;
        private System.Windows.Forms.TextBox textBoxIP;
        //private MB.Controls.ColorSlider SliderVolume;
        //private MB.Controls.ColorSlider SliderMusicPos;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.Label lblRadioUrl;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.TextBox tbStationUrl;
        private System.Windows.Forms.TextBox tbStationName;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Button btnDeleteStation;
        private MB.Controls.ColorSlider SliderVolume;
        private MB.Controls.ColorSlider SliderMusicPos;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnRemoveTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbImageUrl;
        private MB.Controls.ColorSlider SliderRadioVolume;
    }
}

