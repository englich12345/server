using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Areas.Admin.Controllers
{
    [Route("api/media")]
    [EnableCors("CorsPolicy")]
    public class UploadController:Controller
    {
        [HttpPost]
        public async Task<ActionResult> UploadFileAsync(string folder, IFormFile formFile)
        {
            if (formFile == null || formFile.Length == 0)
                return Content("No file selected");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory("wwwroot\\" + folder);
            string domain = HttpContext.Request.Host.ToString();
            var extension = Path.GetExtension(formFile.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), string.Format("wwwroot\\{0}", folder), formFile.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
                path = string.Format("{0}{1}", domain, Url.Action("download", "media", new { folder = folder, fileName = string.Format("{0}", formFile.FileName) }));
            }

            return Ok(path);
        }
    }
}
