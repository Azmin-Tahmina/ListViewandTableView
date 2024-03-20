using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ListandTableExLO
{
    public class ToDo
    {
        private string pDesc;
        private bool pComp;
        private DateTime pDate;
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Description
        {
            get { return this.pDesc; }
            set
            {
                if (value != this.pDesc)
                {
                    this.pDesc = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Completed
        {
            get { return this.pComp; }
            set
            {
                if (value != this.pComp)
                {
                    this.pComp = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime Date
        {
            get { return this.pDate; }
            set
            {
                if (value != this.pDate)
                {
                    this.pDate = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
