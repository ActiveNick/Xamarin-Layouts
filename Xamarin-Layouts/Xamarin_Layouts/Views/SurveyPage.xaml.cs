using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        // No longer needed since I don't use buttons to show the answer options
        //public ICommand ButtonSelectedCommand { get; set; }

        ObservableCollection<AnswerOption> answers = new ObservableCollection<AnswerOption>();

        public SurveyPage ()
		{
			InitializeComponent ();

            answers.Add(new AnswerOption { AnswerText = "Blue" });
            answers.Add(new AnswerOption { AnswerText = "Red" });
            answers.Add(new AnswerOption { AnswerText = "Green" });
            answers.Add(new AnswerOption { AnswerText = "Pink" });
            answers.Add(new AnswerOption { AnswerText = "Black" });
            answers.Add(new AnswerOption { AnswerText = "Purple" });
            answers.Add(new AnswerOption { AnswerText = "Yellow" });
            answers.Add(new AnswerOption { AnswerText = "Other (please specify)" });

            AnswersList.ItemsSource = answers;

            // Below is the original code when I was using buttons in a StackLayout
            // to pick an answer. I've now switched to the ListView above
            //ButtonSelectedCommand = new Command(ButtonSelected);

            //Dictionary<int, string> answerOptions = new Dictionary<int, string>
            //{
            //    { 1, "Blue" }, 
            //    { 2, "Red" },
            //    { 3, "Green" }, 
            //    { 4, "Pink" }, 
            //    { 5, "Black" }, 
            //    { 6, "Purple" }, 
            //    { 7, "Yellow" }, 
            //    { 8, "Other (please specify)" }
            //};

            //Button btn;
            //      foreach (string answerOption in answerOptions.Values)
            //      {
            //          btn = new Button();
            //          btn.Text = answerOption;
            //          btn.Command = ButtonSelectedCommand;
            //          btn.CommandParameter = btn;
            //          StackAnswerOptions.Children.Add(btn);
            //      }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            //AnswersList.HeightRequest = this.Height - 200;
        }

        // No longer needed since I don't use buttons to show the answer options
        //void ButtonSelected(object obj)
        //{
        //    if (currentAnswer != null)
        //    {
        //        currentAnswer.BackgroundColor = Color.White;
        //    }

        //    Button btn = (Button) obj;
        //    btn.BackgroundColor = Color.Lime;
        //    currentAnswer = btn;
        //}
    }

    public class AnswerOption
    {
        public string AnswerText { get; set; }
    }
}
