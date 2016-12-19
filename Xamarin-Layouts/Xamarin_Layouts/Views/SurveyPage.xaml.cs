using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin_Layouts
{
	public partial class SurveyPage : ContentPage
	{
		public SurveyPage ()
		{
			InitializeComponent ();

            Dictionary<int, string> answerOptions = new Dictionary<int, string>
            {
                { 1, "The first answer" }, 
                { 2, "The second answer" },
                { 3, "The third answer" }, 
                { 4, "The fourth answer" }, 
                { 5, "The fifth answer" }, 
                { 6, "The sixth answer" }, 
                { 7, "The seventh answer" }, 
                { 8, "The last answer" }
            };

		    Button btn;
            foreach (string answerOption in answerOptions.Values)
            {
                btn = new Button();
                btn.Text = answerOption;
                StackAnswerOptions.Children.Add(btn);
            }

        }
    }
}
