using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TTL
{
	public partial class TTLPage : ContentPage
	{
		public TTLPage()
		{
			InitializeComponent();
			MenuListView.ItemsSource = Data.DataManager.Products;
			Content = MenuListView;
		}
	}
}