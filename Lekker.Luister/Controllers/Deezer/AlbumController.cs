using Lekker.Luister.Models.DeezerApiModels;
using Lekker.Luister.Models.Response;
using Lekker.Luister.RestApiClient;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Lekker.Luister.Controllers.Deezer
{
    [ApiController]
    [Route("deezer/album/")]
    public class AlbumController : Controller
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<DeezerAlbumResponse>> GetAlbum(int id, CancellationToken cancellationToken)
        {
            var client = new DeezerClient();

            DeezerAlbum deezerAlbum = await client.GetAlbum(id, cancellationToken);

            var tracks = deezerAlbum.Tracks.GetValueOrDefault("data");

            var albumResponse = new DeezerAlbumResponse
            {
                Title = deezerAlbum.Title,
                Link = new Uri(deezerAlbum.Link),
                CoverUrl = new Uri(deezerAlbum.Cover_Medium),
                ArtistName = deezerAlbum.Artist.Name,
                Tracks = tracks.ConvertAll(t => new DeezerTrackResponse
                {
                    Name = t.Title,
                    Duration = TimeSpan.FromSeconds(t.Duration),
                    Number = tracks.IndexOf(t) + 1
                })
            };

            return Ok(albumResponse);
        }
    }
}