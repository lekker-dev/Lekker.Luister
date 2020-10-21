using System;

namespace Lekker.Luister.Models.Response
{
    public class DeezerTrackResponse
    {
        /// <summary>
        /// The track number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// The track name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The duration of the track
        /// </summary>
        public TimeSpan Duration { get; set; }
    }
}