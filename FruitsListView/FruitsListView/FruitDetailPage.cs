using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FruitsListView
{
    public class FruitDetailPage : ContentPage
    {
        public FruitDetailPage(Fruit fruit)
        {
            Title = fruit.Name;
            Content = new Label
            {
                Text = fruit.Description,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

        }
    }
}