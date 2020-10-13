using Lekker.Luister.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lekker.Luister.Controllers.Deezer
{
    [ApiController]
    [Route("deezer/album/")]
    public class AlbumController : Controller
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<DeezerAlbumResponse>> GetAlbum(int id)
        {
            var album = new DeezerAlbumResponse()
            {
                Title = "Fuz fuz",
                ArtistName = "The Knacks",
                CoverUrl = new Uri("https://e-cdns-images.dzcdn.net/images/cover/8e119aaa57aafc3266bc427acb942a9b/250x250-000000-80-0-0.jpg"),
                Tracks = new List<DeezerTrackResponse>
                {
                    new DeezerTrackResponse
                    {
                        Number = 1,
                        Name = "The floox cruze",
                        Duration = TimeSpan.FromMinutes(3.1)
                        
                    }
                },
                Link = new Uri("https://www.deezer.com/album/100000")

            };

            return Ok(album);
        }
    }
}