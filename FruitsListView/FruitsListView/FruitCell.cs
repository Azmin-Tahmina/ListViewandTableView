using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FruitsListView
{
    public class FruitCell : ViewCell
    {
        public const int RowHeight = 55;
        public FruitCell()
        {
            var nameLabel = new Label { FontAttributes = FontAttributes.Bold };
            nameLabel.SetBinding(Label.TextProperty, "Name");

            var descriptionLabel = new Label { TextColor = Color.Gray };
            descriptionLabel.SetBinding(Label.TextProperty, "Description");

            View = new StackLayout
            {
                Spacing = 2,
                Padding = 5,
                Children = {
                nameLabel,
                descriptionLabel
            },
            };

            MenuItem mi = new MenuItem { Text = "Delete", IsDestructive = true };
            mi.Clicked += (sender, e) =>
            {
                ListView parent = (ListView)this.Parent;
                ObservableCollection<Fruit> list = (ObservableCollection<Fruit>)parent.ItemsSource;
                list.Remove((Fruit)this.BindingContext);
            };
            ContextActions.Add(mi);


        }
    }
}