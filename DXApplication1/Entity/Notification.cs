using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Entity
{
    public class Notification
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int Cameraid { get; set; }
        public DateTime Date { get; set; }
        public string ImageLink { get; set; }
        public float? Score {  get; set; }
        public int? TrackId {  get; set; }
        public int? X {  get; set; }
        public int? Y {  get; set; }
        public int? W {  get; set; }
        public int? H { get; set; }

    }
}
