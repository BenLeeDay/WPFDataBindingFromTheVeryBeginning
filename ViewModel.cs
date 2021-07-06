namespace DataBindingExercise
{
    public class ViewModel
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
            }
        }
        #endregion
    }
}