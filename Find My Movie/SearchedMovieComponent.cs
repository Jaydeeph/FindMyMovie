using System;
using System.Windows.Forms;



namespace Find_My_Movie
{
    public partial class SearchedMovieComponent : UserControl
    {
        UtilHelper utilHelper;
        public string moviePosterUrl { get; set; }
        public string movieTitle { get; set; }
        public string movieYear { get; set; }
        public string movieImdbId { get; set; }

        public SearchedMovieComponent(ref UtilHelper utilHelper, string moviePosterUrl, string movieTitle, string movieYear, string movieImdbId)
        {
            InitializeComponent();

            this.moviePosterUrl = moviePosterUrl;
            this.movieTitle = movieTitle;
            this.movieYear = movieYear;
            this.movieImdbId = movieImdbId;

            this.utilHelper = utilHelper;
        }

        private void SearchedMovieComponent_Load(object sender, EventArgs e)
        {
            LoadControlData();
        }

        private void LoadControlData()
        {
            MoviePosterPictureBox.ImageLocation = moviePosterUrl;
            MovieNameLabel.Text = "Movie:\n" + movieTitle;
            MovieYearLabel.Text = "Year:\n" + movieYear;
            MovieImdbLabel.Text = "IMDB ID:\n" + movieImdbId;
        }

        private void TransparentMoviePanel_Click(object sender, EventArgs e)
        {
            utilHelper.currentSelectedImdbId = movieImdbId;
            utilHelper.mainForm.ShowMovie();
        }
    }
}
