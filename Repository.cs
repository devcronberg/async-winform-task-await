using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace async_winform_task_await
{
    class Repository
    {
        private const string url = "http://webdemo.cronberg.dk/service/dice_txt/3000";

        public async Task<string> HentTilfældigVærdiAsync(CancellationToken token, bool fejl = false) {

            if (fejl)
                throw new ApplicationException("Fejl fra HentTilfældigVærdi()");

            using (var client = new HttpClient())
            {
                var r = await client.GetAsync(url, token);
                token.ThrowIfCancellationRequested();
                if (r.IsSuccessStatusCode)
                    return await r.Content.ReadAsStringAsync();
                else
                    throw new ApplicationException("Kan ikke hente tal");
            }
        }

        public string HentTilfældigVærdiSync(bool fejl = false)
        {

            if (fejl)
                throw new ApplicationException("Fejl fra HentTilfældigVærdiSync()");

            using (WebClient w = new WebClient())
            {
                string res = w.DownloadString(new Uri(url));
                return res;
            }
        }
    }
}
