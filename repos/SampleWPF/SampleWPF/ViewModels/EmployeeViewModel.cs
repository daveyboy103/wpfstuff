using System.ComponentModel;

namespace SampleWPF.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set
            { 
                _firstName = value;

                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(FirstName)));
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(LastName)));
                }
            }
        }



    }
}
