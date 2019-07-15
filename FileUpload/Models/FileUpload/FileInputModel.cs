using Microsoft.AspNetCore.Http;

namespace FileUpload.Models.FileUpload
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
