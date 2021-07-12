using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMDbApiNet.Model;

namespace Find_My_Movie
{
    public partial class MovieForm : Form
    {
        UtilHelper utilHelper;
        public Item itemMovie { get; set; }
        public bool isCalledFromList { get; set; }

        public MovieForm(ref UtilHelper utilHelper, Item itemMovie, bool isCalledFromList = false)
        {
            InitializeComponent();

            this.utilHelper = utilHelper;
            this.utilHelper.movieForm = this;
            this.itemMovie = itemMovie;
            this.isCalledFromList = isCalledFromList;
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            bool keyImdbExists = itemMovie.Ratings.ElementAtOrDefault(0) != null;
            bool keyRottenTomatoesExists = itemMovie.Ratings.ElementAtOrDefault(1) != null;
            bool keyMetacriticExists = itemMovie.Ratings.ElementAtOrDefault(2) != null;

            MovieFormSkin.Text = "Movie - " + itemMovie.Title;

            TitleLabel.Text = itemMovie.Title;
            RatedLabel.Text = itemMovie.Rated;
            ReleaseLabel.Text = itemMovie.Released;
            RuntimeLabel.Text = itemMovie.Runtime;
            GenreLabel.Text = itemMovie.Genre;
            DirectorLabel.Text = itemMovie.Director;
            WritersLabel.Text = itemMovie.Writer;
            ActorsLabel.Text = itemMovie.Actors;
            PlotLabel.Text = itemMovie.Plot;
            CountryLabel.Text = itemMovie.Country;
            ImdbLabel.Text = keyImdbExists ? itemMovie.Ratings[0].Value : "N/A";
            RottenTomatoesLabel.Text = keyRottenTomatoesExists ? itemMovie.Ratings[1].Value : "N/A";
            MetacriticLabel.Text = keyMetacriticExists ? itemMovie.Ratings[2].Value : "N/A";

            MoviePosterPictureBox.ImageLocation = itemMovie.Poster;
        }        

        private void TitleLabel_Click(object sender, EventArgs e)
        {
            string url = "https://www.imdb.com/title/" + itemMovie.ImdbId;
            System.Diagnostics.Process.Start(url);
        }

        private void PoweredByLabel_Click(object sender, EventArgs e)
        {
            string url = "http://www.omdbapi.com/";
            System.Diagnostics.Process.Start(url);
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            utilHelper.currentSelectedIem = itemMovie;
            utilHelper.mainForm.SaveMovie();
            utilHelper.mainForm.ClickNextMovieButton(e);
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
