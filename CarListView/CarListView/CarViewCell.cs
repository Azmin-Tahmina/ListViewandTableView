using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CarListView
{
    public class CarViewCell : ViewCell
    {
        public CarViewCell()
        {
            // Horizontal layout for car properties
            var layout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(15, 5)
            };

            // Labels for the car's make, model, and year
            var makeLabel = new Label { FontAttributes = FontAttributes.Bold };
            var modelLabel = new Label();
            var yearLabel = new Label { HorizontalOptions = LayoutOptions.EndAndExpand };

            // Bind labels to Car properties
            makeLabel.SetBinding(Label.TextProperty, "Make");
            modelLabel.SetBinding(Label.TextProperty, "Model");
            yearLabel.SetBinding(Label.TextProperty, "Year");

            // Add the labels to the horizontal layout
            layout.Children.Add(makeLabel);
            layout.Children.Add(modelLabel);
            layout.Children.Add(yearLabel);

            // Set the cell's view to the layout
            View = layout;
        }
    }
}