/*
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PRUEBA1.Controllers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PRUEBA1;

namespace PRUEBA1.Controllers
{
    public class VideosController:Controller
    {
        private HelperUploadFiles helper;

        
        public VideosController(HelperUploadFiles helper)
        {
            this.helper = helper;
        }

        public IActionResult Videos()
        {
            return Views();
        }
        [HttpPost]
        public async Task<IActionResult> Videos(IFormFile Video)
        {
            String fileName = Video.FileName;
            if (fileName != null)
            {
                ViewData["video"] = fileName;
            }
            string path = await this.helper.UploadFileAsync(Video, folders.Videos, fileName);
            return View(path);
        }
    }
}
*/