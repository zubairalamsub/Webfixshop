using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebfixShop.Database;
using WebfixShop.Entities;

namespace WebfixShop.Services
{
	public class ProductsService
	{
		public Product GetProducts(int ID)
		{
			using (var context = new WFSContext())
			{
				return context.Products.Find(ID);
			}
		}
		public List<Product> GetProducts()
		{
			using (var context = new WFSContext())
			{
				return context.Products.ToList();
			}
		}
		public void SaveProduct(Product product)
		{
			using(var context=new WFSContext())
			{
				context.Products.Add(product);
				context.SaveChanges();
			}
		}
		public void UpdateProduct(Product product)
		{
			using (var context = new WFSContext())
			{
				context.Entry(product).State = System.Data.Entity.EntityState.Modified;
				context.SaveChanges();
			}
		}
		public void DeleteProduct(int ID)
		{
			using (var context = new WFSContext())
			{
				var category = context.Products.Find(ID);
				//context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
				context.Products.Remove(category);
				context.SaveChanges();
			}
		}

	}
}
