using System.Windows.Forms;

namespace DatabaseSQLMusicApp
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
            btn_loadAlbums = new Button();
            dataGridView1 = new DataGridView();
            btn_searchAlbums = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            lbl_albumID = new Label();
            checkBox1 = new CheckBox();
            btn_addEditAlbum = new Button();
            txt_description = new TextBox();
            txt_ImageURL = new TextBox();
            txt_albumYear = new TextBox();
            txt_albumArtist = new TextBox();
            txt_albumName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btn_deleteSelectedTrack = new Button();
            btn_editSelectedAlbum = new Button();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            lbl_trackID = new Label();
            checkBox2 = new CheckBox();
            btn_addEditTrack = new Button();
            txt_trackLyrics = new TextBox();
            txt_trackURL = new TextBox();
            txt_trackNumber = new TextBox();
            txt_trackTitle = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btn_editSelectedTrack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_loadAlbums
            // 
            btn_loadAlbums.Location = new Point(244, 12);
            btn_loadAlbums.Margin = new Padding(3, 2, 3, 2);
            btn_loadAlbums.Name = "btn_loadAlbums";
            btn_loadAlbums.Size = new Size(124, 22);
            btn_loadAlbums.TabIndex = 0;
            btn_loadAlbums.Text = "Load Albums";
            btn_loadAlbums.UseVisualStyleBackColor = true;
            btn_loadAlbums.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(244, 38);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(706, 140);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btn_searchAlbums
            // 
            btn_searchAlbums.Location = new Point(633, 12);
            btn_searchAlbums.Margin = new Padding(3, 2, 3, 2);
            btn_searchAlbums.Name = "btn_searchAlbums";
            btn_searchAlbums.Size = new Size(82, 22);
            btn_searchAlbums.TabIndex = 2;
            btn_searchAlbums.Text = "Search";
            btn_searchAlbums.UseVisualStyleBackColor = true;
            btn_searchAlbums.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(374, 12);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(956, 39);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_albumID);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btn_addEditAlbum);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_ImageURL);
            groupBox1.Controls.Add(txt_albumYear);
            groupBox1.Controls.Add(txt_albumArtist);
            groupBox1.Controls.Add(txt_albumName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(228, 185);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // lbl_albumID
            // 
            lbl_albumID.AutoSize = true;
            lbl_albumID.Location = new Point(165, 144);
            lbl_albumID.Name = "lbl_albumID";
            lbl_albumID.Size = new Size(52, 15);
            lbl_albumID.TabIndex = 12;
            lbl_albumID.Text = "albumID";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(113, 143);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(46, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "edit";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_addEditAlbum
            // 
            btn_addEditAlbum.Location = new Point(10, 159);
            btn_addEditAlbum.Margin = new Padding(3, 2, 3, 2);
            btn_addEditAlbum.Name = "btn_addEditAlbum";
            btn_addEditAlbum.Size = new Size(110, 22);
            btn_addEditAlbum.TabIndex = 10;
            btn_addEditAlbum.Text = "Add / Update";
            btn_addEditAlbum.UseVisualStyleBackColor = true;
            btn_addEditAlbum.Click += button3_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(111, 118);
            txt_description.Margin = new Padding(3, 2, 3, 2);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(110, 23);
            txt_description.TabIndex = 9;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(111, 94);
            txt_ImageURL.Margin = new Padding(3, 2, 3, 2);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(110, 23);
            txt_ImageURL.TabIndex = 8;
            // 
            // txt_albumYear
            // 
            txt_albumYear.Location = new Point(111, 70);
            txt_albumYear.Margin = new Padding(3, 2, 3, 2);
            txt_albumYear.Name = "txt_albumYear";
            txt_albumYear.Size = new Size(110, 23);
            txt_albumYear.TabIndex = 7;
            // 
            // txt_albumArtist
            // 
            txt_albumArtist.Location = new Point(111, 46);
            txt_albumArtist.Margin = new Padding(3, 2, 3, 2);
            txt_albumArtist.Name = "txt_albumArtist";
            txt_albumArtist.Size = new Size(110, 23);
            txt_albumArtist.TabIndex = 6;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(111, 22);
            txt_albumName.Margin = new Padding(3, 2, 3, 2);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(110, 23);
            txt_albumName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 116);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 92);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 69);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 46);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 215);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Tracks";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(244, 232);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(421, 141);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(670, 182);
            webView21.Margin = new Padding(3, 2, 3, 2);
            webView21.Name = "webView21";
            webView21.Size = new Size(468, 227);
            webView21.Source = new Uri("https://www.youtube.com/watch?v=mQER0A0ej0M", UriKind.Absolute);
            webView21.TabIndex = 8;
            webView21.ZoomFactor = 1D;
            // 
            // btn_deleteSelectedTrack
            // 
            btn_deleteSelectedTrack.Location = new Point(294, 206);
            btn_deleteSelectedTrack.Margin = new Padding(3, 2, 3, 2);
            btn_deleteSelectedTrack.Name = "btn_deleteSelectedTrack";
            btn_deleteSelectedTrack.Size = new Size(148, 22);
            btn_deleteSelectedTrack.TabIndex = 9;
            btn_deleteSelectedTrack.Text = "Delete Selected Track";
            btn_deleteSelectedTrack.UseVisualStyleBackColor = true;
            btn_deleteSelectedTrack.Click += button4_Click;
            // 
            // btn_editSelectedAlbum
            // 
            btn_editSelectedAlbum.Location = new Point(729, 12);
            btn_editSelectedAlbum.Margin = new Padding(3, 2, 3, 2);
            btn_editSelectedAlbum.Name = "btn_editSelectedAlbum";
            btn_editSelectedAlbum.Size = new Size(146, 22);
            btn_editSelectedAlbum.TabIndex = 10;
            btn_editSelectedAlbum.Text = "Edit Selected Album";
            btn_editSelectedAlbum.UseVisualStyleBackColor = true;
            btn_editSelectedAlbum.Click += button5_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(lbl_trackID);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(btn_addEditTrack);
            groupBox2.Controls.Add(txt_trackLyrics);
            groupBox2.Controls.Add(txt_trackURL);
            groupBox2.Controls.Add(txt_trackNumber);
            groupBox2.Controls.Add(txt_trackTitle);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(9, 229);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(228, 185);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Album";
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 118);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 13;
            // 
            // lbl_trackID
            // 
            lbl_trackID.AutoSize = true;
            lbl_trackID.Location = new Point(161, 143);
            lbl_trackID.Name = "lbl_trackID";
            lbl_trackID.Size = new Size(45, 15);
            lbl_trackID.TabIndex = 12;
            lbl_trackID.Text = "TrackID";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Enabled = false;
            checkBox2.Location = new Point(113, 143);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(46, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "edit";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btn_addEditTrack
            // 
            btn_addEditTrack.Location = new Point(10, 159);
            btn_addEditTrack.Margin = new Padding(3, 2, 3, 2);
            btn_addEditTrack.Name = "btn_addEditTrack";
            btn_addEditTrack.Size = new Size(110, 22);
            btn_addEditTrack.TabIndex = 10;
            btn_addEditTrack.Text = "Add / Update";
            btn_addEditTrack.UseVisualStyleBackColor = true;
            btn_addEditTrack.Click += button6_Click;
            // 
            // txt_trackLyrics
            // 
            txt_trackLyrics.Location = new Point(111, 94);
            txt_trackLyrics.Margin = new Padding(3, 2, 3, 2);
            txt_trackLyrics.Name = "txt_trackLyrics";
            txt_trackLyrics.Size = new Size(110, 23);
            txt_trackLyrics.TabIndex = 8;
            // 
            // txt_trackURL
            // 
            txt_trackURL.Location = new Point(111, 70);
            txt_trackURL.Margin = new Padding(3, 2, 3, 2);
            txt_trackURL.Name = "txt_trackURL";
            txt_trackURL.Size = new Size(110, 23);
            txt_trackURL.TabIndex = 7;
            // 
            // txt_trackNumber
            // 
            txt_trackNumber.Location = new Point(111, 46);
            txt_trackNumber.Margin = new Padding(3, 2, 3, 2);
            txt_trackNumber.Name = "txt_trackNumber";
            txt_trackNumber.Size = new Size(110, 23);
            txt_trackNumber.TabIndex = 6;
            // 
            // txt_trackTitle
            // 
            txt_trackTitle.Location = new Point(111, 22);
            txt_trackTitle.Margin = new Padding(3, 2, 3, 2);
            txt_trackTitle.Name = "txt_trackTitle";
            txt_trackTitle.Size = new Size(110, 23);
            txt_trackTitle.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 116);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 4;
            label8.Text = "Album ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 92);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 3;
            label9.Text = "Lyrics";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 69);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 2;
            label10.Text = "Video URL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 46);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 1;
            label11.Text = "Number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 22);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 0;
            label12.Text = "Track Title";
            // 
            // btn_editSelectedTrack
            // 
            btn_editSelectedTrack.Location = new Point(469, 206);
            btn_editSelectedTrack.Margin = new Padding(3, 2, 3, 2);
            btn_editSelectedTrack.Name = "btn_editSelectedTrack";
            btn_editSelectedTrack.Size = new Size(148, 22);
            btn_editSelectedTrack.TabIndex = 14;
            btn_editSelectedTrack.Text = "Edit Selected Track";
            btn_editSelectedTrack.UseVisualStyleBackColor = true;
            btn_editSelectedTrack.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 431);
            Controls.Add(btn_editSelectedTrack);
            Controls.Add(groupBox2);
            Controls.Add(btn_editSelectedAlbum);
            Controls.Add(btn_deleteSelectedTrack);
            Controls.Add(webView21);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(btn_searchAlbums);
            Controls.Add(dataGridView1);
            Controls.Add(btn_loadAlbums);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Music Database";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_loadAlbums;
        private DataGridView dataGridView1;
        private Button btn_searchAlbums;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btn_addEditAlbum;
        private TextBox txt_description;
        private TextBox txt_ImageURL;
        private TextBox txt_albumYear;
        private TextBox txt_albumArtist;
        private TextBox txt_albumName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private DataGridView dataGridView2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btn_deleteSelectedTrack;
        private Button btn_editSelectedAlbum;
        private CheckBox checkBox1;
        private Label lbl_albumID;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label lbl_trackID;
        private CheckBox checkBox2;
        private Button btn_addEditTrack;
        private TextBox txt_trackLyrics;
        private TextBox txt_trackURL;
        private TextBox txt_trackNumber;
        private TextBox txt_trackTitle;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btn_editSelectedTrack;
    }
}