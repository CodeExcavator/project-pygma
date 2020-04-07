using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pygma.UatTests.Extensions;
using Pygma.Users.ViewModels.Requests;

namespace Pygma.UatTests.Endpoints
{
    public static class HttpAccountExtensions
    {
        private const string url = "/api/account";

        public static async Task<ActionResult> RegisterAsync(this HttpClient client,
            RegisterAccountVm registerAccountVm,
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
        {
            return await client.DoPostAsync<RegisterAccountVm, ActionResult>($"{url}/registration", registerAccountVm,
                expectedStatusCode);
        }

        public static async Task<ActionResult<string>> LoginAsync(this HttpClient client, LoginVm loginVm,
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
        {
            return await client.DoPostAsync<LoginVm, string>($"{url}", loginVm, expectedStatusCode);
        }
    }
}