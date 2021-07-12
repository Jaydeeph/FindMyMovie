using OMDbApiNet.Model;

namespace Find_My_Movie
{
    public class UtilHelper
    {
        public MainForm mainForm { get; set; }
        public MovieListForm MovieListForm { get; set; }
        public MovieForm movieForm { get; set; }
        public OmdbApi omdbApi { get; }
        public string currentSelectedImdbId { get; set; }
        public Item currentSelectedIem { get; set; }

        public UtilHelper()
        {
            omdbApi = new OmdbApi();
        }
    }
}
