using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin_Layouts
{
	public partial class UserProfilePage : ContentPage
	{
        public enum AuthMethods { Microsoft, Google }

		public UserProfilePage ()
		{
			InitializeComponent ();

            PickAuthMethod.Items.Add("Microsoft");
            PickAuthMethod.Items.Add("Google");
            PickAuthMethod.Items.Add("Facebook");
            PickAuthMethod.Items.Add("Twitter");
        }
    }
}
