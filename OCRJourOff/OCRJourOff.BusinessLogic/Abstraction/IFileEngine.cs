using System;
using System.Threading;
using System.Threading.Tasks;

namespace OCRJourOff.BusinessLogic.Abstraction
{
    public interface IFileEngine
    {
        Task UploadFile(CancellationToken ct);
    }
}
