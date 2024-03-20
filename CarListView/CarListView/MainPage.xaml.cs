using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // Sample data for the ListView
            var cars = new ObservableCollection<CAR>
            {
                new CAR { Make = "Toyota", Model = "Camry", Year = 2020 },
                new CAR { Make = "Honda", Model = "Accord", Year = 2019 },
                new CAR { Make = "Ford", Model = "Mustang", Year = 2021 },
            // Add more cars as needed
            };

            // Create the ListView
            var listView = new ListView
            {
                ItemsSource = cars,
                ItemTemplate = new DataTemplate(typeof(CarViewCell)),
                SeparatorColor = Color.Gray
            };

            // Set the Content of the Page to the ListView
            Content = listView;
        }
    }
}
