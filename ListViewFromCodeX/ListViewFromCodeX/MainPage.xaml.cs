using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewFromCodeX
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //var listview = new ListView();
            //listview.ItemsSource = new ObservableCollection<Item>
            //{
            //    new Item { Name = "Item 1" },
            //    new Item { Name = "Item 2" },
            //};

            //listview.ItemTemplate = new DataTemplate(typeof(CustomViewCell));

            //Another way
            var listView = new ListView
            {
                // Set the ItemSource to your collection of data
                ItemsSource = new ObservableCollection<Item>
                {
                    new Item { Name = "Item 1" },
                    new Item { Name = "Item 2" },
                    // Add more items as needed
                },

                // Use OurCustomCell for rendering each item
                ItemTemplate = new DataTemplate(typeof(CustomViewCell))
            };
         
            Content = listView;
        }
    }

}
