﻿using System.Collections.Generic;

namespace TH.Models
{
	public class Product
	{
		public int ProductID { get; set; }
		public string Name { get; set; } = "";
		public double Price { get; set; }
		public int CategoryID { get; set; }
		public int OnSale { get; set; }
		public int StockLevel { get; set; }
		public string ImageFileName { get; set; }
		public IEnumerable<Category> Categories { get; set; }
	}
}
