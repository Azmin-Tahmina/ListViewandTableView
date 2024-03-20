using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListandTableExLO
{
    public class ToDoCell : ViewCell
    {
        public const int RowHeight = 85;
        private Label lblDesc = new Label();
        public ToDoCell()
        {
            lblDesc.FontAttributes = FontAttributes.Bold;
            lblDesc.SetBinding(Label.TextProperty, "Description");

            Label lblDate = new Label { FontAttributes = FontAttributes.Italic };
            lblDate.SetBinding(Label.TextProperty, "Date", stringFormat: "{0:D}");

            Switch swtCompleted = new Switch { HorizontalOptions = LayoutOptions.Start, IsEnabled = false };
            swtCompleted.SetBinding(Switch.IsToggledProperty, "Completed");
            StackLayout switchStack = new StackLayout { Orientation = StackOrientation.Horizontal, HorizontalOptions = LayoutOptions.Start };
            switchStack.Children.Add(new Label { Text = "Completed?" });
            switchStack.Children.Add(swtCompleted);

            StackLayout viewLayout = new StackLayout();
            viewLayout.Children.Add(lblDesc);
            viewLayout.Children.Add(lblDate);
            viewLayout.Children.Add(switchStack);
            View = viewLayout;
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            // OnBindingContextChanged is useful if there is something that you need to go and lookup (perhaps in another table in a database)
            // to display in this cell. The issue with doing this kind of work in the constructor is that when the constructor runs, 
            // the binding (link) to the object hasn't happened yet, so we can't access properties of the object in the constructor.
            // (Try accessing the Date value in the constructor, you will see that the BindingContext is null)
            ToDo item = (ToDo)this.BindingContext;
            if (item.Date < DateTime.Now) // the item is overdue
            {
                lblDesc.BackgroundColor = Color.Red;
            }
            else // the item can still be completed
            {
                lblDesc.BackgroundColor = Color.Green;
            }
            // This method runs after the constructor, once the "link" has been established to this row's bound ToDo object
            // Often times you may want to use a property of the bound item to do something like make a decision, so that kind of code
            // would go here.
        }

    }
}