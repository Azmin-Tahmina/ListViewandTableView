using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListEx1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SampleListView.ItemsSource = new ObservableCollection<Item>
            {
                new Item { Name = "Item 1" },
                new Item { Name = "Item 2" },
                new Item { Name = "Item 3" },
                new Item { Name = "Item 4" }
            };
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item != null && e.Item is Item item)
            {
                DisplayAlert("Item Tapped", item.Name, "OK");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
    }

}
