using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListViewFromCodeX
{
    public class CustomViewCell : ViewCell
    {
        public CustomViewCell()
        {
            // Steps:
            //1. define elemnts for view
            //2. define layout
            //3. add the elements to layout
            //4. add event HandlerAttribute as needed
            //5. for click and display to the list item use binding context and displayalert (IF required)

            var label = new Label();
            label.VerticalOptions = LayoutOptions.Center;
            label.HorizontalOptions = LayoutOptions.StartAndExpand;
            label.SetBinding(Label.TextProperty,"Name");

            // another way
            //var label = new Label
            //{
            //    VerticalOptions = LayoutOptions.Center,
            //    HorizontalOptions = LayoutOptions.StartAndExpand
            //};
            //label.SetBinding(Label.TextProperty, "Name");

            var button = new Button();
            button.Text = "Click!";

            //another way
            //var button = new Button
            //{
            //    Text = "Click Me"
            //};


            button.Clicked += (sender, e) =>
            {
                // Handle the button click event
                // You can access the BindingContext to get the item data
                var item = (Item)this.BindingContext;
                Application.Current.MainPage.DisplayAlert("Button Clicked", item.Name, "OK");
            };

            var stackLayout = new StackLayout();
            stackLayout.Orientation = StackOrientation.Horizontal;
            //stackLayout.Children.Add(button);
            stackLayout.Children.Add(label);

            //another way
            //var stackLayout = new StackLayout
            //{
            //    Orientation = StackOrientation.Horizontal,
            //    Children = { label, button }
            //};

            View = stackLayout;
        }
    }
}