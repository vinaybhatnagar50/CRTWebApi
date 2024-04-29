using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRTBuisnessLogics.Entity.Admin
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastEdit { get; set; }
        public bool IsDelete { get; set; }
        public int FeatureOption { get; set; }
        public int MenuId { get; set; }
    }
}
