using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _message;

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
