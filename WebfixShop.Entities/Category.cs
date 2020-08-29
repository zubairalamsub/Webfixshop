using System;
using System.Collections.Generic;
using System.Text;

namespace WebfixShop.Entities
{
	public class Category :BaseEntity
	{

		
        public List<Product> products { get; set; }
		
	}
}
