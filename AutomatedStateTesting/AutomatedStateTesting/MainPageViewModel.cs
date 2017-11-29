using System.Windows.Input;
using Xamarin.Forms;

namespace AutomatedStateTesting
{
    internal class MainPageViewModel : MvvmHelpers.BaseViewModel
    {
        private string text;
        private int clickCount;

        public MainPageViewModel()
        {
            ClickCommand = new Command(IncrementClickCount);
        }

        public ICommand ClickCommand { get; private set; }

        public string Text 
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        public int ClickCount
        {
            get { return clickCount; }
            set { SetProperty(ref clickCount, value); }
        }

        public string ClickCountText
        {
            get { return $"Clicked {ClickCount} Times"; }
        }

        private void IncrementClickCount()
        {
            ClickCount++;
            OnPropertyChanged("ClickCountText");
        }
    }
}