﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin_Layouts
{
	public partial class RootPage : MasterDetailPage
    {
		public RootPage ()
		{
            MasterBehavior = MasterBehavior.Popover;
            InitializeComponent ();
		}
	}
}
