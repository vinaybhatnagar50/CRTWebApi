using CRTBuisnessLogics.Entity.Admin;
using CRTBuisnessLogics.Managers.Admin;
using CRTDataAccess.DBContext;
using CRTDataAccess.DTO.Admin;
using CRTDataAccess.Managers.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CRTDataAccess.Managers.Admin
{
    public class CategoryManager : ManagerBase, ICategoryManager
    {
        public CategoryManager(AppDBContext dBContext) : base(dBContext) { }
        public List<Category> getallitem()
        {
            var list = new List<Category>();
            try
            {
              
                var dto = DbContext.Categories.ToList();
                //foreach (var item in dto)
                //{
                //    var put = ToEntity(item);
                //    list.Add(put);
                //}
                return list;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static Category ToEntity(CategoryDTO dto)
        {
            var entity = new Category
            {
                Id = dto.Id,
                Name = dto.Name,
                Created = dto.Created,
                CreatedBy = dto.CreatedBy,
                FeatureOption = dto.FeatureOption,
                IsDelete = dto.IsDelete,
                LastEdit = dto.LastEdit,
                MenuId = dto.MenuId,
            };
            return entity;
        }
    }
}