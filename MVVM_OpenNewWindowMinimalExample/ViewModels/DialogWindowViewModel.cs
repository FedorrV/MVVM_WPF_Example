namespace MVVM_OpenNewWindowMinimalExample.ViewModels {
    class DialogWindowViewModel:BasicViewModel {
        private string textValue;
        public string TextValue
        {
            get { return textValue; }
            set
            {
                textValue = value;
                TextBlock = textValue;
                OnPropertyChanged("TextValue");
            }
        }

        private string textBlock;
        public string TextBlock
        {
            get { return textBlock; }
            set
            {
                textBlock = value;
                OnPropertyChanged("TextBlock");
            }
        }
    }
}