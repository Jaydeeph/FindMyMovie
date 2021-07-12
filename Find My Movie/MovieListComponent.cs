using OMDbApiNet.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Find_My_Movie
{
    public partial class MovieListComponent : UserControl
    {

        UtilHelper utilHelper;
        Item item;

        public MovieListComponent(ref UtilHelper UtilHelper, Item item)
        {
            InitializeComponent();

            this.utilHelper = UtilHelper;
            this.item = item;
        }

        private void MovieListComponent_Load(object sender, EventArgs e)
        {
            LoadControlData();
        }

        private void LoadControlData()
        {
            bool keyImdbExists = item.Ratings.ElementAtOrDefault(0) != null;
            bool keyRottenTomatoesExists = item.Ratings.ElementAtOrDefault(1) != null;
            bool keyMetacriticExists = item.Ratings.ElementAtOrDefault(2) != null;

            MoviePosterPictureBox.ImageLocation = item.Poster;
            TitleLabel.Text = item.Title;
            RuntimeLabel.Text = item.Runtime;
            CountryLabel.Text = item.Country;
            RatedLabel.Text = item.Rated;
            MetascoreLabel.Text = item.Metascore;
            ActorsLabel.Text = item.Actors;
            PlotLabel.Text = item.Plot;
            ImdbLabel.Text = keyImdbExists ? item.Ratings[0].Value : "N/A";
            MetacriticLabel.Text = keyRottenTomatoesExists ? item.Ratings[1].Value : "N/A";
            RottenTomatoesLabel.Text = keyMetacriticExists ? item.Ratings[2].Value : "N/A";
        }

        private void TransparentMoviePanel_Click(object sender, EventArgs e)
        {
            utilHelper.currentSelectedIem = item;
            utilHelper.MovieListForm.ShowMovie();
        }
    }
}
