using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TableViewBasic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarsTableViewPage : ContentPage
    {
        public CarsTableViewPage()
        {
            InitializeComponent();
            Title = "Cars Table";
            var tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Car Details")
                {
                    new TableSection("Car 1")
                    {
                        new TextCell { Text = "Make", Detail = "Ford" },
                        new TextCell { Text = "Model", Detail = "Mustang" },
                        new TextCell { Text = "Color", Detail = "Red" }
                    },
                    new TableSection("Car 2")
                    {
                        new TextCell { Text = "Make", Detail = "Chevrolet" },
                        new TextCell { Text = "Model", Detail = "Camaro" },
                        new TextCell { Text = "Color", Detail = "Blue" }
                    }
                    // Add more cars as needed
                }
            };

            // Adding the TableView to the Page
            Content = tableView;
        }
    }
}