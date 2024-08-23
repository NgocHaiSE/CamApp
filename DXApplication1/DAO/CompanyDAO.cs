using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAO
{
    public class CompanyDAO
    {
        private static CompanyDAO instance;
        public static CompanyDAO Instance
        {
            get { if (instance == null) instance = new CompanyDAO(); return CompanyDAO.instance; }
            private set => CompanyDAO.instance = value;
        }
        private CompanyDAO() { }
        public List<CompanyDTO> GetAllCompanies()
        {
            List<CompanyDTO> companies = new List<CompanyDTO>();
            string query = "SELECT * FROM company";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CompanyDTO company = new CompanyDTO(item);
                companies.Add(company);
            }
            return companies;
        }

        


    }
}
