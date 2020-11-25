using services.cross.Models.Results.AppLication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace services.cross.Repository
{
    public  interface ISendRequestRepository
    {
        Task<ApiSendResult> PostJsonAsync(string url, object jsonDate);
    }
}
