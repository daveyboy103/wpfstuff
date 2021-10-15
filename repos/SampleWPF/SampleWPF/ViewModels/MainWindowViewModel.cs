using SampleWPF.Commands;
using SampleWPF.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfModels.Models;

namespace SampleWPF.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private RoutedCommand applyCommand = new RoutedCommand();
        public MainWindowViewModel(MainWindowModel data)
        {
            this.data = data;
            var cmd = new ApplyCommand(this);
            ApplyCommand = cmd;
        }

        public MainWindowModel Model => data;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ApplyCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand RefreshCommand { get; set; }

        public IEnumerable<string> MaterialTypes { get; }

        public string Description
        {
            get { return data.Description; }
            set
            {
                data.Description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
            }
        }

        public string Finish
        {
            get { return data.Finish; }
            set
            {
                data.Finish = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Finish)));
            }
        }

        public string PurchaseInformation
        {
            get { return data.PurchaseInformation; }
            set
            {
                data.PurchaseInformation = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(PurchaseInformation)));
            }
        }

        public string SupplierName
        {
            get { return data.SupplierName; }
            set
            {
                data.SupplierName = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(SupplierName)));
            }
        }

        public string SupplierCode
        {
            get { return data.SupplierCode; }
            set
            {
                data.SupplierCode = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(SupplierCode)));
            }
        }

        public double Length
        {
            get { return data.Length; }
            set
            {
                data.Length = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Length)));
            }
        }
        public string Status => data.Status;
        public string Revision => data.Revision;
        public string PartNumber => data.PartNumber;
        public string RawMaterial
        {
            get { return data.RawMaterial; }
            set
            {
                data.RawMaterial = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(RawMaterial)));
            }
        }
        public double Mass
        {
            get { return data.Mass; }
            set
            {
                data.Mass = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Mass)));
            }
        }

        public bool Weld
        {
            get { return data.Weld; }
            set
            {

                data.Weld = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Weld)));
            }
        }

        public bool Assembly
        {
            get { return data.Assembly; }
            set
            {

                data.Assembly = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Assembly)));
            }
        }

        public bool Plasma
        {
            get { return data.Plasma; }
            set
            {

                data.Plasma = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Plasma)));
            }
        }

        public bool Laser
        {
            get { return data.Laser; }
            set
            {

                data.Laser = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Laser)));
            }
        }

        public bool Purchase
        {
            get { return data.Purchase; }
            set
            {

                data.Purchase = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Purchase)));
            }
        }

        public bool Lathe
        {
            get { return data.Lathe; }
            set
            {

                data.Lathe = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Lathe)));
            }
        }

        public bool Drill
        {
            get { return data.Drill; }
            set
            {

                data.Drill = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Drill)));
            }
        }

        private bool fold;

        public bool Fold
        {
            get { return data.Fold; }
            set
            {

                data.Fold = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Fold)));
            }
        }

        private bool roll;

        public bool Roll
        {
            get { return data.Roll; }
            set
            {

                data.Roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Roll)));
            }
        }

        public bool Saw
        {
            get { return data.Saw; }
            set
            {

                data.Saw = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Saw)));
            }
        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private readonly MainWindowModel data;

        public string Notes
        {
            get
            {
                return data.Notes;
            }
            set
            {
                data.Notes = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Notes)));

            }

        }
    }
}
