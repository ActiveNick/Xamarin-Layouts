using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin_Layouts
{
	public partial class ButtonGridPage : ContentPage
	{
		public ButtonGridPage ()
		{
			InitializeComponent ();

            imgLogo.Source = "xamarinlogo.png";

            InitializeWidgetGrid();
        }

        private void InitializeWidgetGrid(int widgetCount = 9)
        {
            int WidgetCount = widgetCount; // This will come from the server
            Button btnWidget;

            // Start in top left corner
            int row = 0, col = 0;

            for (int i = 0; i < WidgetCount; i++)
            {

                btnWidget = new Button();

                btnWidget.Image = "notes.png";
#if __ANDROID__
                btnWidget.FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Button));
#else
                btnWidget.FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button));
#endif

                btnWidget.BackgroundColor = Color.FromHex("F2F2F2");  // Very pale gray

                btnWidget.Text = "Notes";

                WidgetGrid.Children.Add(btnWidget, col, row);
                col++;

                // If column contains more than 3 objects, create a new row
                if (col > 2)
                {
                    col = 0;
                    row++;
                }
            }
        }
    }
}
