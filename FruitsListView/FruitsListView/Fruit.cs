using System;
using System.Collections.Generic;
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
            set { this.fName = value; }
        }

        public string Description
        {
            get { return this.fDesc; }
            set { this.fDesc = value; }
        }

    }
}
