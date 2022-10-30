using System;
using Microsoft.AspNetCore.Http;

namespace DgKala.Security
{
    public static class ImageValidator
    {
        public static bool IsImage(this IFormFile file)
        {

            try
            {
                var img = System.Drawing.Image.FromStream(file.OpenReadStream());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
