

using System.ComponentModel.DataAnnotations.Schema;

namespace CRTDataAccess.DTO.Admin
{
    [Table("Category")]
    public class CategoryDTO
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
