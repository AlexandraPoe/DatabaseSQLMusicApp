namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource albumbBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource(); 

        List<Album> albums = new List<Album>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // connect the list to the grid view control
           
            albums = albumsDAO.getAllAlbums();

            albumbBindingSource.DataSource = albums;

            dataGridView1.DataSource = albumbBindingSource;

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // connect the list to the grid view control
            
            albumbBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text); 
            dataGridView1.DataSource = albumbBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // get the row number clicked

            int rowClicked = dataGridView.CurrentRow.Index;
           // MessageBox.Show("You clicked row " + rowClicked);

           String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            
          //  MessageBox.Show("URL=" + imageURL);
          try
            {
                pictureBox1.Load(imageURL);
            }
        
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

            tracksBindingSource.DataSource = albums[rowClicked].Tracks;
            dataGridView2.DataSource = tracksBindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // add a new item to the database
            Album album = new Album
            {
                AlbumName = txt_albumName.Text,
                ArtistName = txt_albumArtist.Text,
                Year = Int32.Parse(txt_albumYear.Text),
                ImageURL = txt_ImageURL.Text,
                Description = txt_description.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            if (checkBox1.Checked )
            {
                int albumID = int.Parse(lbl_albumID.Text);
                int result = albumsDAO.updateAlbum(album, albumID);
                MessageBox.Show(result + " row(s) updated");
            } else
            {
                int result = albumsDAO.addOneAlbum(album);
                MessageBox.Show(result + " new row(s) inserted");
            }

            txt_albumArtist.Clear();
            txt_albumYear.Clear(); 
            txt_albumName.Clear();
            txt_description.Clear();
            txt_ImageURL.Clear();
            lbl_albumID.Text = "";
            checkBox1.Checked = false;

            albums = albumsDAO.getAllAlbums();
            dataGridView1.DataSource = albums;
            dataGridView2.DataSource = null;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // get the row number clicked

            int rowClicked = dataGridView.CurrentRow.Index;
            // MessageBox.Show("You clicked row " + rowClicked);

            String videoURL = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();


            //  MessageBox.Show("URL=" + imageURL);
            try
            {
                webView21.Source = new Uri(videoURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // get the row number clicked

            var rowClicked = dataGridView2.CurrentRow.Index;
            MessageBox.Show("You clicked row " + rowClicked);
            int trackID = (int) dataGridView2.Rows[rowClicked].Cells[0].Value;
            MessageBox.Show("ID of track " + trackID);

            AlbumsDAO albumsDao = new AlbumsDAO();

            int result = albumsDao.deleteTrack(trackID);

            MessageBox.Show("REsult " + result);

            dataGridView2.DataSource = null;
            albums = albumsDao.getAllAlbums();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            // MessageBox.Show("You clicked row " + rowClicked);

            Album editMe = albums[rowClicked];
            txt_albumName.Text = editMe.AlbumName;
            txt_albumArtist.Text = editMe.ArtistName;
            txt_albumYear.Text = editMe.Year.ToString();
            txt_ImageURL.Text = editMe.ImageURL;
            txt_description.Text = editMe.Description;

            checkBox1.Checked = true;
            lbl_albumID.Text = editMe.ID.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // edit track

            int albumSelected = dataGridView1.CurrentRow.Index;
            // MessageBox.Show("You clicked row " + rowClicked);

            int trackSelected = dataGridView2.CurrentRow.Index;



            Track editMe = albums[albumSelected].Tracks[trackSelected];
            txt_trackTitle.Text = editMe.Name;
            txt_trackNumber.Text = editMe.Number.ToString();
            txt_trackURL.Text = editMe.VideoURL;
            txt_trackLyrics.Text = editMe.Lyrics; 

            checkBox2.Checked = true;
            lbl_trackID.Text = editMe.ID.ToString();

           
            comboBox1.Items.Clear();

            foreach (Album album in albums)
            {
                comboBox1.Items.Add(album);

            } 
            comboBox1.SelectedIndex = albumSelected;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            // save track
            Album albumSelected = (Album)comboBox1.SelectedItem;

            Track newTrack = new Track
            {
                Name = txt_trackTitle.Text,
                Lyrics = txt_trackLyrics.Text,
                Number = int.Parse(txt_trackNumber.Text),
                VideoURL = txt_trackURL.Text,
                AlbumID = albumSelected.ID,
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            if (checkBox2.Checked)
            {
                // edit
                int updateTrackID = int.Parse( lbl_trackID.Text);
                int result = albumsDAO.updateTrack(newTrack, updateTrackID);

                MessageBox.Show(result + " items updated");
            }
            else
            {
                // create new track
                int result = albumsDAO.newTrack(newTrack);
                MessageBox.Show(result + " items inserted");
            }

            albums = albumsDAO.getAllAlbums();
            albumbBindingSource.ResetBindings(false);
            dataGridView2.DataSource = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            albums = albumsDAO.getAllAlbums();
            foreach (Album album in albums)
            {
                comboBox1.Items.Add(album);

            }
            comboBox1.SelectedIndex = 0;
        }
    }
}