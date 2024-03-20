using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FruitsListView
{
    public class Fruit
    {
        private string fName = String.Empty;
        private string fDesc = String.Empty;

        public string Name
        {
            get { return this.fName; }
            set
            {
                if (value != this.fDesc)
                {
                    this.fDesc = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get { return this.fDesc; }
            set
            {
                if (value != this.fDesc)
                {
                    this.fDesc = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


    }
}
