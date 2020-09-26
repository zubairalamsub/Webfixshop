using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebfixShop.Database;
using WebfixShop.Entities;

namespace WebfixShop.Services
{
	public class CategoriesService
	{
		public Category GetCategories(int ID)
		{
			using (var context = new WFSContext())
			{
				return context.Categories.Find(ID);
			}
		}
		public List<Category> GetCategories()
		{
			using (var context = new WFSContext())
			{
				return context.Categories.ToList();
			}
		}
		public void SaveCategory(Category category)
		{
			using(var context=new WFSContext())
			{
				context.Categories.Add(category);
				context.SaveChanges();
			}
		}
		public void UpdateCategory(Category category)
		{
			using (var context = new WFSContext())
			{
				context.Entry(category).State = System.Data.Entity.EntityState.Modified;
				context.SaveChanges();
			}
		}
		public void DeleteCategory(int ID)
		{
			using (var context = new WFSContext())
			{
				var category = context.Categories.Find(ID);
				//context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
				context.Categories.Remove(category);
				context.SaveChanges();
			}
		}

	}
}
