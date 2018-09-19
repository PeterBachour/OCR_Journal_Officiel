using OCRJourOff.BusinessLogic.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OCRJourOff.BusinessLogic.Implementation
{
    public class FileEngine : IFileEngine
    {
        public FileEngine()
        {
        }

        public async Task UploadFile(CancellationToken ct)
        {
            int a = 2;
            int b = 3;
            int d = a + b;
            throw new NotImplementedException();
        }
    }
}
