using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Information {  get; set; }
        public string CreateTime {  get; set; }
        public int? IsRecog { get; set; }
        public string Code { get; set; }
        public DateTime? Birth { get; set; }
        public int? Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Person(string code, string name, int? gender, DateTime? birth, 
            string phone, string address, string information, int? isRecog)
        {
            Name = name;
            Information = information;
            IsRecog = isRecog;
            Code = code;
            Gender = gender;
            Birth = birth;
            Phone = phone;
            Address = address;
        }
    }
}
