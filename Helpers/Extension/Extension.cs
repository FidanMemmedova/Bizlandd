using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helpers.Extension
{
    public static class Extension
    {
        public static bool CheckFileSize(this IFormFile file, int kb)
        {
            return file.Length / 1024 <= 200;
        }
        public static bool CheckFileType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }
    }
}