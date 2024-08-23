using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DXApplication1.DTO
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CompanyDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public CompanyDTO(DataRow row)
        {
            Id = Convert.ToInt32(row["id"]);
            Name = row["name"].ToString();
        }
    }
}
