using System.ComponentModel;

namespace DataBindingExercise
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields
        private string _exampleString;
        #endregion

        #region Constructor
        public ViewModel()
        {
            ExampleString = "Here is some text which is loaded at startup.";
        }
        #endregion

        #region Properties
        public string ExampleString
        {
            get { return _exampleString; }
            set
            {
                _exampleString = value;
                OnPropertyChanged("ExampleString");
            }
        }
        #endregion

        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
        #endregion
    }
}