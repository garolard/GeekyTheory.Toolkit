using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Navigation;

namespace GeekyTheory.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public virtual void OnNavigatedFrom(NavigationEventArgs e)
        {
        }

        public virtual void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
        }

        public virtual void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
