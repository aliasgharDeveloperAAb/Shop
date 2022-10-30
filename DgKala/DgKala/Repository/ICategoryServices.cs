using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DgKala.Convertors;
using DgKala.Generators;
using DgKala.Models.Context;
using DgKala.Models.Entities.Category;
using DgKala.Models.ViewModels.Category;
using DgKala.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace DgKala.Repository
{
    public interface ICategoryServices
    {
        #region Group

        List<CategoryGroups> GetAllGroup();
        List<SelectListItem> GetGroupForManageCategory();
        List<SelectListItem> GetSubGroupForManageCategory(int groupId);
        List<SelectListItem> GetTeacher();
        List<SelectListItem> GetStatues();

        CategoryGroups GetyById(int groupId);
        void AddGroup(CategoryGroups groups);
        void UpdateGroup(CategoryGroups groups);

        #endregion

        #region Category

        List<ShowCategoryForAdminViewModel> GetCategoryForAdmin();
        int AddCategory(Category category, IFormFile imgCategory);
        Category GetCategoryById(int categoryId);
        void UpdateCategory(Category category, IFormFile imgCategory);

        Tuple<List<ShowCategoryListItemViewModel>, int> GetCategory(int pageId = 1, string filter = "", string getType = "all", string orderByType = "Exist", List<int> selectedGroups = null, int take = 0);

        Category GetCategoryForShow(int categoryId);

        #endregion

        #region Comment

        void AddComment(CategoryComment comment);
       Tuple<List<CategoryComment>,int> GetCategoryComment(int categoryId, int pageId=1);    

        #endregion
    } 




    public class CategoryServices : ICategoryServices
    {
        private DgkalaContext _context;

        public CategoryServices(DgkalaContext context)
        {
            _context = context;
        }
        public List<CategoryGroups> GetAllGroup()
        {
            return _context.CategoryGroups.Include(c=>c.CategoryGroupsList).ToList();
        }
        public List<SelectListItem> GetGroupForManageCategory()
        {
            return _context.CategoryGroups.Where(g => g.ParentID == null)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }
        public List<SelectListItem> GetSubGroupForManageCategory(int groupId)
        {
            return _context.CategoryGroups.Where(s => s.ParentID == groupId)
                .Select(s => new SelectListItem()
                {
                    Text = s.GroupTitle,
                    Value = s.GroupId.ToString()
                }).ToList();
        }
        public List<SelectListItem> GetTeacher()
        {
            return _context.UserRoles.Where(r => r.RoleId == 3).Include(r => r.User)
                .Select(u => new SelectListItem()
                {
                    Text = u.User.UserName,
                    Value = u.UserId.ToString()
                }).ToList();

        }
        public List<SelectListItem> GetStatues()
        {
            return _context.CategoryStatuesEnumerable.Select(s => new SelectListItem()
            {
                Text = s.StatuesTitle,
                Value = s.StatuesId.ToString()
            }).ToList();
        }
        public CategoryGroups GetyById(int groupId)
        {
            return _context.CategoryGroups.Find(groupId);
        }
        public void AddGroup(CategoryGroups groups)
        {
            _context.CategoryGroups.Add(groups);
            _context.SaveChanges();
        }
        public void UpdateGroup(CategoryGroups groups)
        {
            _context.CategoryGroups.Update(groups);
            _context.SaveChanges();
        }
        public List<ShowCategoryForAdminViewModel> GetCategoryForAdmin()
        {
            return _context.Categories.Select(c => new ShowCategoryForAdminViewModel()
            {
                CategoryId = c.CategoryId,
                CategoryImageName = c.CategoryImageName,
                Title = c.CategoryTitle

            }).ToList();
        }
        public int AddCategory(Category category, IFormFile imgCategory)
        {
            category.CreateDate = DateTime.Now;


            if (imgCategory != null && imgCategory.IsImage())
            {


                category.CategoryImageName = NameGenerator.GeneratorUniqCode() + Path.GetExtension(imgCategory.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Category/image",
                    category.CategoryImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCategory.CopyTo(stream);
                }

                ImageConvertor imgresizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Category/thumb",
                    category.CategoryImageName);


                imgresizer.Image_resize(imagePath, thumbPath, 150);



            }

            _context.Add(category);
            _context.SaveChanges();

            return category.GroupId;
        }
        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }
        public void UpdateCategory(Category category, IFormFile imgCategory)
        {
            category.UpdateDate = DateTime.Now;

            if (imgCategory != null && imgCategory.IsImage())
            {
                if (category.CategoryImageName != "a.jpg")
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Category/image", category.CategoryImageName);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                    string deletethumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Category/thumb", category.CategoryImageName);
                    if (File.Exists(deletethumbPath))
                    {
                        File.Delete(deletethumbPath);
                    }
                }
                category.CategoryImageName = NameGenerator.GeneratorUniqCode() + Path.GetExtension(imgCategory.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Category/image", category.CategoryImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCategory.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Category/thumb", category.CategoryImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }

            _context.Categories.Update(category);
            _context.SaveChanges();

        }
        public Tuple<List<ShowCategoryListItemViewModel>, int> GetCategory(int pageId = 1, string filter = "", string getType = "all", string orderByType = "date",
            List<int> selectedGroups = null, int take = 0)
        {
            if (take == 0)
                take = 8;
            IQueryable<Category> result = _context.Categories;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.CategoryTitle.Contains(filter)||c.Tags.Contains(filter));
            }

            switch (getType)
            {
                case "all":
                    break;
                case "maxPrice":
                    {
                        result = result.Where(c => c.CategoryPrice != 0);
                        break;
                    }
                case "lowprice":
                    {
                        result = result.Where(c => c.CategoryPrice < 1000000);
                        break;
                    }
            }

            switch (orderByType)
            {
                case "date":
                    {
                        result = result.OrderByDescending(c => c.CreateDate);
                        break;
                    }
                case "UpdateDate":
                    {
                        result = result.OrderByDescending(c => c.UpdateDate);
                        break;
                    }
            }

            if (selectedGroups != null && selectedGroups.Any())
            {
                foreach (int groupId in selectedGroups)
                {
                    result = result.Where(c => c.GroupId == groupId || c.SubGroup == groupId);
                }
            }

            int skip = (pageId - 1) * take;

            int pageCount = result.Select(c => new ShowCategoryListItemViewModel()
            {
                CategoryId = c.CategoryId,
                Title = c.CategoryTitle,
                ImageName = c.CategoryImageName,
                Price = c.CategoryPrice


            }).Count() / take;

            var query = result.Select(c => new ShowCategoryListItemViewModel()
            {
                CategoryId = c.CategoryId,
                Title = c.CategoryTitle,
                ImageName = c.CategoryImageName,
                Price = c.CategoryPrice


            }).Skip(skip).Take(take).ToList();

            return Tuple.Create(query, pageCount);
        }
        public Category GetCategoryForShow(int categoryId)
        {
            return _context.Categories
                 .Include(c => c.CategoryStatues)
                 .Include(c => c.CategoryGroups)
                .Include(c => c.User)
             
                .FirstOrDefault(c => c.CategoryId == categoryId);

        }
        public void AddComment(CategoryComment comment)
        {
            _context.CategoryComments.Add(comment);
            _context.SaveChanges();
        }
         
        public Tuple<List<CategoryComment>, int> GetCategoryComment(int courseId, int pageId = 1)
        {
            int take = 5;
            int skip = (pageId - 1) * take;
            int pageCount = _context.CategoryComments.Where(c => !c.IsDelete && c.CategoryId == courseId).Count() / take;

            if ((pageCount % 2) != 0)
            {
                pageCount += 1;
            }

            return Tuple.Create(
                _context.CategoryComments.Include(c => c.User).Where(c => !c.IsDelete && c.CategoryId == courseId).Skip(skip).Take(take)
                    .OrderByDescending(c => c.CreateDate).ToList(), pageCount);
        }
    }
}














