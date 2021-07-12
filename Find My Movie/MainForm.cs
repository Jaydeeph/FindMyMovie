using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMDbApiNet;
using OMDbApiNet.Model;
using System.Threading;
using FlatUI;

namespace Find_My_Movie
{
    public partial class MainForm : Form
    {

        List<string> userMovieList = new List<string>();
        List<Item> movieList = new List<Item>();
        List<string> saveMovieList = new List<string>();

        UtilHelper utilHelper;

        public MainForm(UtilHelper utilHelper)
        {
            InitializeComponent();
            this.utilHelper = utilHelper;
            this.utilHelper.mainForm = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            utilHelper.omdbApi.SetMainForm(this);
        }

        private void SearchMovieButton_Click(object sender, EventArgs e)
        {
            ClearTableLayoutPanel();

            string movieName = MovieNameTextBox.Text.Trim();

            if (movieName.Equals(""))
            {
                MessageBox.Show("Please enter a movie name before searching!", "Searching For Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SearchForMovie(movieName);
        }

        private void LoadMovieListButton_Click(object sender, EventArgs e)
        {
            LoadMovieList();
        }

        private void SaveMovieListButton_Click(object sender, EventArgs e)
        {
            SaveMovieList();
        }

        private void ShowMovieListButton_Click(object sender, EventArgs e)
        {
            MovieListForm movieListForm = new MovieListForm(ref utilHelper, ref movieList);
            movieListForm.Show();
        }

        private void NextMovieButton_Click(object sender, EventArgs e)
        {
            string movieName = userMovieList.First();
            userMovieList.Remove(movieName);

            MovieNameTextBox.Text = movieName;
            SearchMovieButton.PerformClick(e);
        }

        public void ClickNextMovieButton(EventArgs e)
        {
            NextMovieButton.PerformClick(e);
        }

        private void ClearTableLayoutPanel()
        {
            while (TableLayoutPanelMovies.Controls.Count > 0)
            {
                TableLayoutPanelMovies.Controls[0].Dispose();
            }

            TableLayoutPanelMovies.Controls.Clear();
            TableLayoutPanelMovies.RowCount = 0;
        }

        private void SearchForMovie(string movieName)
        {
            SearchList searchList = utilHelper.omdbApi.SearchForMovieByName(movieName);

            if(searchList == null)
            {
                return;
            }

            foreach (SearchItem searchItem in searchList.SearchResults)
            {
                SearchedMovieComponent searchedMovie = new SearchedMovieComponent(ref utilHelper, searchItem.Poster, searchItem.Title, searchItem.Year, searchItem.ImdbId)
                {
                    Dock = DockStyle.Top
                };
                TableLayoutPanelMovies.Controls.Add(searchedMovie);
            }
        }

        public void ShowMovie()
        {
            string imdbId = utilHelper.currentSelectedImdbId;
            Item item = utilHelper.omdbApi.SearchForMovieByImdbId(imdbId);

            MovieForm movieForm = new MovieForm(ref utilHelper, item);
            movieForm.Show();
        }

        private void LoadMovieList()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                foreach (string line in lines)
                {
                    userMovieList.Add(line);
                }
            }
        }

        private void SaveMovieList()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, saveMovieList);
            }
        }

        private StringBuilder CustomFormatMovieText(Item item, ref StringBuilder stringBuilder)
        {
            stringBuilder.Append(
                    $"www.imdb.com/title/{item.ImdbId}\n" +
                    $"www.imdb.com/title/{item.ImdbId}/parentalguide\n" +
                    $"```css\n" +
                    $"[ {item.Title} | ⌚ {item.Runtime} | ⭐ {item.Ratings[0].Value} | 📅 {item.Released} | {item.Rated} ]\n" +
                    $"\"{item.Plot}\"\n" +
                    $"```"
                );
            return stringBuilder;
        }

        public void SaveMovie()
        {
            Item selectedItem = utilHelper.currentSelectedIem;

            foreach (Item item in movieList)
            {
                if (item.Title.Equals(selectedItem.Title))
                {
                    MessageBox.Show("Movie already exists in your list. Please skip.", "Adding Move To List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            AddMovieItemToList(selectedItem);
            AddMovieToList(selectedItem);
        }

        public void AddMovieItemToList(Item item)
        {
            
            movieList.Add(item);
        }

        public void AddMovieToList(Item item)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (Properties.Settings.Default.UseCustomMovieFormat)
            {
                stringBuilder = CustomFormatMovieText(item, ref stringBuilder);
                saveMovieList.Add(stringBuilder.ToString());
            }
            else
            {
                bool keyImdbExists = item.Ratings.ElementAtOrDefault(0) != null;
                bool keyRottenTomatoesExists = item.Ratings.ElementAtOrDefault(1) != null;
                bool keyMetacriticExists = item.Ratings.ElementAtOrDefault(2) != null;

                stringBuilder.Append("| " + item.Title + " |");

                if (Properties.Settings.Default.AddActors)
                {
                    stringBuilder.Append(" " + item.Actors + " |");
                }

                if (Properties.Settings.Default.AddAwards)
                {
                    stringBuilder.Append(" " + item.Awards + " |");
                }

                if (Properties.Settings.Default.AddBoxOffice)
                {
                    stringBuilder.Append(" " + item.BoxOffice + " |");
                }

                if (Properties.Settings.Default.AddCountry)
                {
                    stringBuilder.Append(" " + item.Country + " |");
                }

                if (Properties.Settings.Default.AddDirector)
                {
                    stringBuilder.Append(" " + item.Director + " |");
                }

                if (Properties.Settings.Default.AddGenre)
                {
                    stringBuilder.Append(" " + item.Actors + " |");
                }

                if (Properties.Settings.Default.AddActors)
                {
                    stringBuilder.Append(" " + item.Genre + " |");
                }

                if (Properties.Settings.Default.AddImdbId)
                {
                    if (keyImdbExists) stringBuilder.Append(" " + item.Ratings[0].Value + " |");
                }

                if (Properties.Settings.Default.AddLanguage)
                {
                    stringBuilder.Append(" " + item.Language + " |");
                }

                if (Properties.Settings.Default.AddMetacriticRating)
                {
                    if (keyMetacriticExists) stringBuilder.Append(" " + item.Ratings[2].Value + " |");
                }

                if (Properties.Settings.Default.AddMetascoreRating)
                {
                    stringBuilder.Append(" " + item.Metascore + " |");
                }

                if (Properties.Settings.Default.AddPlot)
                {
                    stringBuilder.Append(" " + item.Plot + " |");
                }

                if (Properties.Settings.Default.AddProduction)
                {
                    stringBuilder.Append(" " + item.Production + " |");
                }

                if (Properties.Settings.Default.AddRated)
                {
                    stringBuilder.Append(" " + item.Rated + " |");
                }

                if (Properties.Settings.Default.AddReleased)
                {
                    stringBuilder.Append(" " + item.Released + " |");
                }

                if (Properties.Settings.Default.AddRottenTomatoesRating)
                {
                    if (keyRottenTomatoesExists) stringBuilder.Append(" " + item.Ratings[1].Value + " |");
                }

                if (Properties.Settings.Default.AddRuntime)
                {
                    stringBuilder.Append(" " + item.Runtime + " |");
                }

                if (Properties.Settings.Default.AddWriter)
                {
                    stringBuilder.Append(" " + item.Writer + " |");
                }
            }

            saveMovieList.Add(stringBuilder.ToString());
        }

        public void AddMovieNotFoundToList(string movieName)
        {
            saveMovieList.Add($"{movieName} was not found. Seems like Omdb doesn't have it in its database.");
        }

        private void SettingsPictureBox_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();
        }

        private void OnClick(object sender, EventArgs e)
        {
            base.OnClick(e);
            Environment.Exit(0);
        }
    }
}
