using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Entity
{
    public class ImageEntity
    {
        public int Id { get; set; }
        public string PersonCode { get; set; }
        public string Link { get; set; }
        public int IndexMilvus {  get; set; }
        //public Image(string personCode, string link, int indexMilvus) 
        //{
        //    PersonCode = personCode;
        //    Link = link;
        //    IndexMilvus = indexMilvus;
        //}
    }

}
