using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin_Layouts
{
	public partial class SurveyPage : ContentPage
	{
	    private Button currentAnswer;

        public ICommand ButtonSelectedCommand { get; set; }

        public SurveyPage ()
		{
			InitializeComponent ();

            ButtonSelectedCommand = new Command(ButtonSelected);

            Dictionary<int, string> answerOptions = new Dictionary<int, string>
            {
                { 1, "Blue" }, 
                { 2, "Red" },
                { 3, "Green" }, 
                { 4, "Pink" }, 
                { 5, "Black" }, 
                { 6, "Purple" }, 
                { 7, "Yellow" }, 
                { 8, "Other, please specify" }
            };

		    Button btn;
            foreach (string answerOption in answerOptions.Values)
            {
                btn = new Button();
                btn.Text = answerOption;
                btn.Command = ButtonSelectedCommand;
                btn.CommandParameter = btn;
                StackAnswerOptions.Children.Add(btn);
            }
        }

        void ButtonSelected(object obj)
        {
            if (currentAnswer != null)
            {
                currentAnswer.BackgroundColor = Color.White;
            }

            Button btn = (Button) obj;
            btn.BackgroundColor = Color.Lime;
            currentAnswer = btn;
        }
    }
}
