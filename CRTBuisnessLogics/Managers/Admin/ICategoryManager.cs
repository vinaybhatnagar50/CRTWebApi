using CRTBuisnessLogics.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRTBuisnessLogics.Managers.Admin
{
    public interface ICategoryManager
    {
        public List<Category> getallitem();
    }
}
