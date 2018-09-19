using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OCRJourOff.BusinessLogic.Abstraction;

namespace OCRJourOff.WebApi.Controllers
{
    public class FileController : Controller
    {
        private readonly IFileEngine _fileEngine;

        public FileController(IFileEngine fileEngine)
        {
            _fileEngine = fileEngine;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task <IActionResult> UploadFile(CancellationToken ct)
        {


            //Call FileEngine UploadFile
            await _fileEngine.UploadFile(ct);
            return Ok();
        }
    }
}