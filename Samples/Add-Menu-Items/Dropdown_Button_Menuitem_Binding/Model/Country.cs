﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Dropdown_Button_Menuitem_Binding
{
    public class Country
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private BitmapImage flag;
        public BitmapImage Flag
        {
            get
            {
                return flag;
            }
            set
            {
                flag = value;
            }
        }
    }
}

