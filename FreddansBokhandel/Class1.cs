using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace FreddansBokhandel
{
    class Class1
    {
        readonly HttpClient client = new HttpClient();
        private string bokusUrl = "http://image.bokus.com/images/";
        private string fullImgPath;

        public Class1(string isbn)
        {
            fullImgPath = bokusUrl + isbn;
        }

        public void yeah()
        {
           var habo = client.GetByteArrayAsync(fullImgPath);

            var hello = habo.Result;

        }
    }
}
