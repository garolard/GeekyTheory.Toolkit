using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace GeekyTheory.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        private Frame appFrame;
        private Frame splitViewFrame;
        private bool isBusy;

        public Frame AppFrame
        {
            get { return appFrame; }
        }
        public Frame SplitViewFrame
        {
            get { return splitViewFrame; }
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public abstract Task OnNavigatedFrom(NavigationEventArgs e);

        public abstract Task OnNavigatedTo(NavigationEventArgs e);

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void SetAppFrame(Frame viewFrame)
        {
            appFrame = viewFrame;
        }

        internal void SetSplitFrame(Frame viewFrame)
        {
            splitViewFrame = viewFrame;
        }
    }
}
