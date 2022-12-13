using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomSniper
{
    class linkRow
    {
        public string Link { get; set; }
        public string Adres { get; set; }


        public linkRow(string link, string adress)
        {
            Link = link;
            Adres = adress;
        }
    }
}
