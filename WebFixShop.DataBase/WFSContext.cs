﻿using WebfixShop.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebfixShop.Database
{
	public class WFSContext :DbContext,IDisposable
	{
		public WFSContext() : base("WebFixShopConnectionString")
		{

		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }



	}
}
