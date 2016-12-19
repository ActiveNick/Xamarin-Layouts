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
