using System;
using System.Collections.Generic;

namespace Lekker.Luister.Models.Response
{
    public class DeezerAlbumResponse
    {
        /// <summary>
        /// The title of the album.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The name of the album artist
        /// </summary>
        public string ArtistName { get; set; }

        /// <summary>
        /// The URL to the image of the album art.
        /// </summary>
        public Uri CoverUrl { get; set; }

        /// <summary>
        /// The track listing.
        /// </summary>
        public List<DeezerTrackResponse> Tracks { get; set; }

        /// <summary>
        /// The URL to the album on the Deezer service.
        /// </summary>
        public Uri Link { get; set; }
    }
}