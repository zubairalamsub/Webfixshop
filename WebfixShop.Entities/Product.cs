using System;
using System.Collections.Generic;
using System.Text;

namespace WebfixShop.Entities
{
     public	class Product : BaseEntity
	{
	
		public Category Category { get; set; }


		public decimal Price { get; set; }

	}
}
