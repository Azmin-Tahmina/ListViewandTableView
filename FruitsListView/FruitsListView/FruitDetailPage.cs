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

            Title = fruit.Name;
            StackLayout layout = new StackLayout { HorizontalOptions = LayoutOptions.Center };

            TableView table = new TableView { Intent = TableIntent.Form };

            EntryCell eName = new EntryCell { Label = "Name", Text = fruit.Name };
            EntryCell eDescription = new EntryCell { Label = "Description", Text = fruit.Description };
            TableSection section = new TableSection(fruit.Name)
            {
                eName, eDescription
            };
            table.Root = new TableRoot { section };
            Button btnSave = new Button { Text = "Save Changes" };
            btnSave.Clicked += (sender, e) =>
            {
                fruit.Name = eName.Text;
                fruit.Description = eDescription.Text;
                Navigation.PopAsync();
            };
            Button btnCancel = new Button { Text = "Cancel" };
            btnCancel.Clicked += (sender, e) => { Navigation.PopAsync(); };
            layout.Children.Add(table);
            layout.Children.Add(btnSave);
            layout.Children.Add(btnCancel);
            Content = layout;


        }
    }
}