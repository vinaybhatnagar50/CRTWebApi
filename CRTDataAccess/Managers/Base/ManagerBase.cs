using CRTDataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRTDataAccess.Managers.Base
{
    public abstract class ManagerBase
    {
        public AppDBContext DbContext { get; set; }

        protected ManagerBase(AppDBContext dBContext)
        {
            this.DbContext = dBContext;
        }
    }
}
