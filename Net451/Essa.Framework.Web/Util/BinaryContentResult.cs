using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Alfazema.Framework.Web.Util
{
    public class BinaryContentResult : ActionResult
    {
        public string ContentType { get; set; }
        public byte[] Content { get; set; }

        public BinaryContentResult(byte[] contentBytes, string contentType)
        {
            this.Content = contentBytes;
            this.ContentType = contentType;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            response.Clear();
            response.Cache.SetCacheability(HttpCacheability.Public);
            response.ContentType = this.ContentType;

            using (var stream = new MemoryStream(this.Content))
            {
                stream.WriteTo(response.OutputStream);
                stream.Flush();
            }
        }
    }
}
