using System;
using System.Web;

namespace RemoveIIS7ServerHeader
{
    public class CustomHeaderModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.PreSendRequestHeaders += OnPreSendRequestHeaders;
        }

        public void Dispose() { }

        void OnPreSendRequestHeaders(object sender, EventArgs e)
        {
            //HttpContext.Current.Response.Headers.Set("Server", "Box of Bolts");
            HttpContext.Current.Response.Headers.Remove("Server");
            HttpContext.Current.Response.Headers.Remove("X-AspNet-Version");
        }
    }
}
