using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AddDeleteListItems
{
    public class CarListPage : ContentPage
    {
        private ObservableCollection<Car> cars = new ObservableCollection<Car>
        {
            new Car { Make = "Ford", Model = "Mustang", Color = "Red" },
            new Car { Make = "Chevrolet", Model = "Camaro", Color = "Blue" },
            new Car { Make = "Dodge", Model = "Challenger", Color = "Black" }
        };
        public CarListPage()
        {
            var listView = new ListView
            {
                ItemsSource = cars,
                ItemTemplate = new DataTemplate(() =>
                {
                    var makeLabel = new Label();
                    var modelLabel = new Label();
                    var colorLabel = new Label();

                    makeLabel.SetBinding(Label.TextProperty, "Make");
                    modelLabel.SetBinding(Label.TextProperty, "Model");
                    colorLabel.SetBinding(Label.TextProperty, "Color");

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children = { makeLabel, modelLabel, colorLabel }
                        }
                    };
                })
            };

            // Button to add a car
            var addButton = new Button
            {
                Text = "Add a Car"
            };
            addButton.Clicked += (sender, e) =>
            {
                cars.Add(new Car { Make = "Tesla", Model = "Model S", Color = "White" });
            };

            // Deleting a car on item tap
            listView.ItemTapped += (sender, e) =>
            {
                if (e.Item != null && e.Item is Car car)
                {
                    cars.Remove(car);
                }
            };

            Content = new StackLayout
            {
                Children = { addButton, listView }
            };
        }
    }
}