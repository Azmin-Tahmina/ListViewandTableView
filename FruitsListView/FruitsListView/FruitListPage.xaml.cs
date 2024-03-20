using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FruitsListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FruitListPage : ContentView
    {
        public FruitListPage()
        {
            List<Fruit> list = new List<Fruit> {
                new Fruit { Name = "Apple", Description = "Awesome!" },
                new Fruit { Name = "Banana", Description = "Beautiful!" },
                new Fruit { Name = "Cherry", Description = "Cheap!" },
            };
            var listView = new ListView
            {
                ItemsSource = list,
                ItemTemplate = new DataTemplate(typeof(FruitCell)),
                RowHeight = FruitCell.RowHeight,
            };

            listView.ItemTapped += (sender, e) => {
                listView.SelectedItem = null;
                //Navigation.PushAsync(new FruitDetailPage(e.Item as Fruit));
                ((ObservableCollection<Fruit>)listView.ItemsSource).Remove((Fruit)e.Item);
            };

            Content = listView;

            StackLayout layout = new StackLayout();
            layout.Children.Add(listView);
            Entry eName = new Entry();
            Entry eDescription = new Entry();
            Button btnNew = new Button { Text = "Create New Fruit" };
            btnNew.Clicked += (sender, e) =>
            {
                Fruit f = new Fruit { Name = eName.Text, Description = eDescription.Text };
                list.Add(f);
                eName.Text = ""; // clear for next entry
                eDescription.Text = "";
            };
            layout.Children.Add(eName);
            layout.Children.Add(eDescription);
            layout.Children.Add(btnNew);
            Content = layout;

        }

    }
}