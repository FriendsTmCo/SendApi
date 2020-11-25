using services.cross.Models.Results.AppLication;
using services.cross.Repository;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace services.cross.Services
{
    public class SendRequestServices : ISendRequestRepository
    {
        private HttpClient httpClient = new HttpClient();

        public async Task<ApiSendResult> PostJsonAsync(string url, object jsonDate)
        {
            return await Task.Run(() =>
            {
                return null;
            });
        }
    }
}
