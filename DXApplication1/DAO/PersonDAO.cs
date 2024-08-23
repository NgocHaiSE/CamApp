using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAO
{
    public class PersonDAO
    {

        private DataProvider dataProvider;
        
        
        public DataTable GetPersonInfo()
        {
            string query = "GetPersonInfo";
            return dataProvider.ExecuteProcedure(query, null);
        }
    }
}
