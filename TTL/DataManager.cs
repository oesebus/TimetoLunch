using System;
using System.Collections.ObjectModel;

namespace Data
{
	public class DataManager
	{
		public DataManager()
		{
		}

		public static ObservableCollection<Product> Products = new ObservableCollection<Product>
		{

			new Product {reference=2453, Name="Sandwich Poulet Curry", UnitCost=4.60m},
			new Product {reference=2453, Name="Sandwich Thon mayonnaise", UnitCost=4.60m},
			new Product {reference=00786, Name="Panini Tomate Mozarella", UnitCost=4.30m}
			
		}; 

	}
}
