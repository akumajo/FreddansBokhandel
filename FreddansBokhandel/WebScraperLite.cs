using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace FreddansBokhandel
{
    class WebScraperLite
    {
        readonly HttpClient client = new HttpClient();
        private string bokusUrl = "http://image.bokus.com/images/";
        private string fullImgPath;
        private string isbn;

        public WebScraperLite(string _isbn)
        {
            isbn = _isbn;
            fullImgPath = bokusUrl + isbn;
        }

        public void SaveImageToDatabase()
        {
            var imgData = GetImgData(fullImgPath);

            if (imgData == null) { return; }

            using (var db = new FreddansBokhandelContext())
            {
                if (db.Database.CanConnect())
                {
                    var newImage = new Image
                    {
                        Id = isbn,
                        ImageArray = imgData
                    };

                    db.Add(newImage);
                    db.SaveChanges();
                }

                db.Dispose();
            }
        }

        private byte[] GetImgData(string fullImgPath)
        {
            try
            {
                return client.GetByteArrayAsync(fullImgPath).Result;
            }

            catch
            {
                return null;
            }
        }
    }
}