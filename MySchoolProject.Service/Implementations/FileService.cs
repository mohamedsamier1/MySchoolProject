using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MySchoolProject.Service.Abstracts;

namespace MySchoolProject.Service.Implementations
{
    public class FileService : IFileService
    {
        #region field
        private readonly IWebHostEnvironment _webHostEnvironment;
        #endregion
        #region const
        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        #endregion
        #region handel func
        public async Task<string> UploadImage(string location, IFormFile file)
        {

            var path = _webHostEnvironment.WebRootPath + "/" + location + "/";
            var extention = Path.GetExtension(file.FileName);
            var filename = Guid.NewGuid().ToString().Replace("-", string.Empty) + extention;
            if (file.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = File.Create(path + filename))
                    {
                        await file.CopyToAsync(fileStream);
                        await fileStream.FlushAsync();
                        return $"/{location}/{filename}";
                    }
                }
                catch (Exception ex)
                {
                    return "FailedToUploudImage";
                }
            }
            else
            {
                return "NoImage";
            }

        }
        #endregion

    }
}
