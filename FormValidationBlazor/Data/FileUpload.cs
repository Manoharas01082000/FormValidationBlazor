using BlazorInputFile;
using FormValidationBlazor.Service;

namespace FormValidationBlazor.Data
{
   
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _oWebHostEnvironment;
        public FileUpload(IWebHostEnvironment oWebHostEnvironment)
        {
            _oWebHostEnvironment = oWebHostEnvironment;
        }
        public async Task upload(IFileListEntry file)
        {
            var path = Path.Combine(_oWebHostEnvironment.ContentRootPath, "UploadFiles", file.Name);
            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);
            using(FileStream fileStream=new FileStream(path,FileMode.Create,FileAccess.Write))
            {
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}
