using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListandTableExLO
{
    public partial class App : Application
    {
        private ToDo curItem;
        public App()
        {
            InitializeComponent();

            ObservableCollection<ToDo> items = new ObservableCollection<ToDo>
                {
                    new ToDo { Description="Planning Meeting", Completed = false, Date = new DateTime(2018, 1, 19)},
                    new ToDo { Description="Soccer", Completed = true, Date = new DateTime(2018, 1, 20)},
                    new ToDo { Description="Budget Meeting", Completed = false, Date = new DateTime(2018, 1, 21) }
                };

            ListView listView = new ListView
            {
                ItemsSource = items,
                ItemTemplate = new DataTemplate(typeof(ToDoCell)),
                RowHeight = ToDoCell.RowHeight,
                HeightRequest = 900
            };

            StackLayout layout = new StackLayout { HorizontalOptions = LayoutOptions.Center };
            layout.Children.Add(listView);

            TableView table = new TableView { Intent = TableIntent.Form };
            EntryCell eDesc = new EntryCell { Label = "Description" };
            ViewCell cell = new ViewCell();
            DatePicker picker = new DatePicker { Format = "D" };
            cell.View = picker;
            SwitchCell sCompleted = new SwitchCell { Text = "Completed?" };
            TableSection section = new TableSection("Add New Item") { eDesc, sCompleted, cell };
            table.Root = new TableRoot { section };
            layout.Children.Add(new BoxView { HeightRequest = 2, WidthRequest = 400, Color = Color.Black });
            layout.Children.Add(table);
            Button btnSave = new Button { Text = "Save", VerticalOptions = LayoutOptions.Start };
            btnSave.Clicked += (sender, e) =>
            {
                if (curItem != null)
                {
                    curItem.Description = eDesc.Text;
                    curItem.Date = picker.Date;
                    curItem.Completed = sCompleted.On;
                    curItem = null;
                }
                else
                {
                    ToDo item = new ToDo { Description = eDesc.Text, Date = picker.Date, Completed = sCompleted.On };
                    items.Add(item);
                }
                picker.Date = DateTime.Now;
                eDesc.Text = "";
                sCompleted.On = false;
            };
            listView.ItemTapped += (sender, e) =>
            {
                listView.SelectedItem = null;
                curItem = (ToDo)e.Item;
                eDesc.Text = curItem.Description;
                picker.Date = curItem.Date;
                sCompleted.On = curItem.Completed;
            };

            layout.Children.Add(btnSave);
            MainPage = new ContentPage { Content = layout };
        }


    }
}
