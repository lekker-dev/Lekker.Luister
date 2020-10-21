using System.Collections.Generic;

namespace Lekker.Luister.Models.DeezerApiModels
{
    public class DeezerAlbum
    {
        public string Title { get; set; }

        public string Link { get; set; }

        public string Cover_Medium { get; set; }

        public DeezerArtist Artist { get; set; }

        public Dictionary<string, List<DeezerTrack>> Tracks { get; set; }
    }
}