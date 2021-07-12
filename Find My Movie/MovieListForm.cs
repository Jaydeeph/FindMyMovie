using OMDbApiNet.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Find_My_Movie
{
    public partial class MovieListForm : Form
    {
        private UtilHelper utilHelper;
        private List<Item> movieList;

        public MovieListForm(ref UtilHelper utilHelper, ref List<Item> movieList)
        {
            InitializeComponent();
            this.utilHelper = utilHelper;
            this.utilHelper.MovieListForm = this;
            this.movieList = movieList;
        }

        private void SearchedMovieForm_Load(object sender, EventArgs e)
        {
            ClearTableLayoutPanel();
            LoadMovieFromList(movieList);
        }

        private void LoadMovieFromList(List<Item> movieList)
        {
            foreach (Item movie in movieList)
            {
                MovieListComponent movieListComponent = new MovieListComponent(ref utilHelper, movie)
                {
                    Dock = DockStyle.Top
                };
                TableLayoutPanelMovies.Controls.Add(movieListComponent);
            }
        }

        public void ShowMovie()
        {
            Item item = utilHelper.currentSelectedIem;

            MovieForm movieForm = new MovieForm(ref utilHelper, item);
            movieForm.Show();
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

        private void MovieForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
