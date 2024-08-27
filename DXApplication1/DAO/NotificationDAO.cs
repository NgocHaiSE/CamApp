using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAO
{
    public class NotificationDAO
    {
        private static NotificationDAO instance;

        public static NotificationDAO Instance
        {
            get { if (instance == null) instance = new NotificationDAO(); return NotificationDAO.instance; }
            private set => NotificationDAO.instance = value;
        }

        private NotificationDAO() { }

        #region Method
        public DataTable GetAllNotifications()
        {
            DataTable data = DataProvider.Instance.ExecuteProcedure("GetAllNotifications");
            return data;
        }
        #endregion
    }
}
