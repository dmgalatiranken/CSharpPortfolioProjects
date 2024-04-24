using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SongSearch
{
    public partial class frmSongSearch : Form
    {
        // Declare and initialize program constants
        const string NOTHING_INPUTTED = "No Value Was Inputted";
        const string NO_SONG_TITLE_FOUND = "No Matching Song Title Found";
        const string NO_SONG_ARTIST_FOUND = "No Matching Song Artist Found";
        const string NO_SONG_GENRE_FOUND = "No Matching Song Genre Found";

        // Declare and initialize class variable
        static List<Song> songs = SongManager.LoadData();
        public frmSongSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DecideWhichFunctionToCall();
        }

        private void DecideWhichFunctionToCall()
        {
            int option = ddlSongSearch.SelectedIndex;
            switch (option)
            {
                case -1:
                    ShowErrorMessage("You must select an option.", "No option selected");
                    ddlSongSearch.Focus();
                    return;

                case 0:
                    ShowSongListByTitleAscending();
                    break;

                case 1:
                    ShowSongListByArtistAscending();
                    break;

                case 2:
                    ShowSongListByGenreAscending();
                    break;

                case 3:
                    ShowSongListByTitleCriteria();
                    break;

                case 4:
                    ShowSongListByArtistCriteria();
                    break;

                case 5:
                    ShowSongListByGenreCriteria();
                    break;

                default:
                    break;
            }
        }

        private void ShowSongListByTitleAscending()
        {
            lvSongSearch.Items.Clear();
            var titlesAscending =
                from s in songs
                orderby s.SongTitle ascending
                select s;

            lblTitle.Text = "Song List in ascending order by song title";

            // Iterate through song list
            foreach (var s in titlesAscending)
            {
                ListViewItem lvItem = new ListViewItem(s.SongTitle);
                lvItem.SubItems.Add(s.SongArtist);
                lvItem.SubItems.Add(s.SongGenre);
                lvSongSearch.Items.Add(lvItem);
            }
        }

        private void ShowSongListByArtistAscending()
        {
            lvSongSearch.Items.Clear();
            var artistsAscending =
                from s in songs
                orderby s.SongArtist ascending, s.SongTitle ascending
                select s;



            lblTitle.Text = "Song List in ascending order by song artist";

            // Iterate through song list
            // and print out the matching songs
            foreach (var s in artistsAscending)
            {
                ListViewItem lvItem = new ListViewItem(s.SongTitle);
                lvItem.SubItems.Add(s.SongArtist);
                lvItem.SubItems.Add(s.SongGenre);
                lvSongSearch.Items.Add(lvItem);
            }
        }

        private void ShowSongListByGenreAscending()
        {
            lvSongSearch.Items.Clear();
            var genreAscending =
                from s in songs
                orderby s.SongGenre, s.SongArtist ascending, s.SongTitle ascending
                select s;

            lblTitle.Text = "Song List in ascending order by song genre";

            // Iterate through song list
            foreach (var s in genreAscending)
            {
                ListViewItem lvItem = new ListViewItem(s.SongTitle);
                lvItem.SubItems.Add(s.SongArtist);
                lvItem.SubItems.Add(s.SongGenre);
                lvSongSearch.Items.Add(lvItem);
            }
        }

        private void ShowSongListByTitleCriteria()
        {
            lvSongSearch.Items.Clear();
            string title = Interaction.InputBox("Enter a song title to search for (full or partial)");

            if (title.Trim() == "")
            {
                // There was no search criteria
                lvSongSearch.Items.Add(NOTHING_INPUTTED);
            }
            else
            {
                // There was search criteria
                var songTitles =
                    from s in songs
                    orderby s.SongTitle ascending
                    where s.SongTitle.ToUpper().Contains(title.ToUpper())
                    select s;

                // Check for no songs matching criteria
                if (songTitles.Count() < 1)
                {
                    ShowErrorMessage(NO_SONG_TITLE_FOUND, "NO OUTPUT");
                    return;
                }

                // There was at least one song matching the criteria


                lblTitle.Text = "Song titles matching inputted search criteria";

                // Iterate through song list
                foreach (var s in songTitles)
                {
                    ListViewItem lvItem = new ListViewItem(s.SongTitle);
                    lvItem.SubItems.Add(s.SongArtist);
                    lvItem.SubItems.Add(s.SongGenre);
                    lvSongSearch.Items.Add(lvItem);
                }

            }
        }

        private void ShowSongListByArtistCriteria()
        {
            lvSongSearch.Items.Clear();
            string artist = Interaction.InputBox("Enter a song artist to search for (full or partial)");

            if (artist.Trim() == "")
            {
                // There was no search criteria
                lvSongSearch.Items.Add(NOTHING_INPUTTED);
            }
            else
            {
                // There was search criteria
                var songArtists =
                    from s in songs
                    orderby s.SongArtist, s.SongTitle ascending
                    where s.SongArtist.ToUpper().Contains(artist.ToUpper())
                    select s;

                // Check for no songs matching criteria
                if (songArtists.Count() < 1)
                {
                    ShowErrorMessage(NO_SONG_ARTIST_FOUND, "NO OUTPUT");
                    return;
                }

                // There was at least one song matching the criteria


                lblTitle.Text = "Song artists matching inputted search criteria";

                // Iterate through song list
                foreach (var s in songArtists)
                {
                    ListViewItem lvItem = new ListViewItem(s.SongTitle);
                    lvItem.SubItems.Add(s.SongArtist);
                    lvItem.SubItems.Add(s.SongGenre);
                    lvSongSearch.Items.Add(lvItem);
                }
            }
        }

        private void ShowSongListByGenreCriteria()
        {
            lvSongSearch.Items.Clear();
            string genre = Interaction.InputBox("Enter a song genre to search for (full or partial)");

            if (genre.Trim() == "")
            {
                // There was no search criteria
                lvSongSearch.Items.Add(NOTHING_INPUTTED);
            }
            else
            {
                // There was search criteria
                var songGenres =
                    from s in songs
                    orderby s.SongGenre, s.SongArtist, s.SongTitle ascending
                    where s.SongGenre.ToUpper().Contains(genre.ToUpper())
                    select s;

                // Check for no songs matching criteria
                if (songGenres.Count() < 1)
                {
                    ShowErrorMessage(NO_SONG_GENRE_FOUND, "NO OUTPUT");
                    return;
                }

                // There was at least one song matching the criteria


                lblTitle.Text = "Song genres matching inputted search criteria";

                // Iterate through song list
                foreach (var s in songGenres)
                {
                    ListViewItem lvItem = new ListViewItem(s.SongTitle);
                    lvItem.SubItems.Add(s.SongArtist);
                    lvItem.SubItems.Add(s.SongGenre);
                    lvSongSearch.Items.Add(lvItem);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            lvSongSearch.Items.Clear();
            ddlSongSearch.SelectedIndex = -1;
            lblTitle.Text = "";
            ddlSongSearch.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void ExitProgram()
        {
            DialogResult dialog = MessageBox.Show(
        "Do You Really Want To Exit The Program?",
        "EXIT NOW?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void frmSongSearch_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
