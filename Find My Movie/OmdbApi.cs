using OMDbApiNet;
using OMDbApiNet.Model;
using System.Windows.Forms;

namespace Find_My_Movie
{
    public class OmdbApi
    {
        private OmdbClient omdb = new OmdbClient("961cd039");
        private MainForm mainForm;

        public SearchList SearchForMovieByName(string movieName)
        {
            SearchList searchList = null;
            try
            {
                searchList = omdb.GetSearchList(movieName, OmdbType.Movie);
            }
            catch (System.Net.Http.HttpRequestException e)
            {
                MessageBox.Show(movieName + " " + e.Message, "Search Movie Results", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mainForm.AddMovieNotFoundToList(movieName);
            }
            return searchList;
        }

        public Item SearchForMovieByImdbId(string imdbId)
        {
            return omdb.GetItemById(imdbId, true);
        }

        public void SetMainForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

    }
}
