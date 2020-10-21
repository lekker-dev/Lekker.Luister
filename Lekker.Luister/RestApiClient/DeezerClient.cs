using Lekker.Luister.Models.DeezerApiModels;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace Lekker.Luister.RestApiClient
{
    public class DeezerClient
    {
        readonly private RestClient restClient;

        public DeezerClient()
        {
            restClient = new RestClient("https://api.deezer.com");
        }

        internal async Task<DeezerAlbum> GetAlbum(int id, CancellationToken cancellationToken)
        {
            var request = new RestRequest("album/{id}/", DataFormat.Json);
            request.AddUrlSegment("id", id);

            return await restClient.GetAsync<DeezerAlbum>(request, cancellationToken)
                                   .ConfigureAwait(false);
        }
    }
}