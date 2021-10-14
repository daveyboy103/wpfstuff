using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SampleWPF.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ApplyCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand RefreshCommand { get; set; }

        private string description;
        private string rawMaterial;

        public IEnumerable<string> MaterialTypes { get; }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Description)));
            }
        }

        public string Finish
        {
            get { return finish; }
            set
            {
                finish = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Finish)));
            }
        }

        public string PurchaseInformation
        {
            get { return purchaseInformation; }
            set
            {
                purchaseInformation = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(PurchaseInformation)));
            }
        }

        public string SupplierName
        {
            get { return supplierName; }
            set
            {
                supplierName = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(SupplierName)));
            }
        }

        public string SupplierCode
        {
            get { return supplierCode; }
            set
            {
                supplierCode = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(SupplierCode)));
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                length = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Length)));
            }
        }

        public string Status { get; }
        public string Revision { get; }
        public string PartNumber { get; }

        public string RawMaterial
        {
            get { return rawMaterial; }
            set
            {
                rawMaterial = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(RawMaterial)));
            }
        } 
        
        public double Mass
        {
            get { return mass; }
            set
            {
                mass = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Mass)));
            }
        }

        private bool weld;

        public bool Weld
        {
            get { return weld; }
            set
            {

                weld = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Weld)));
            }
        }

        private bool assembly;

        public bool Assembly
        {
            get { return assembly; }
            set
            {

                assembly = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Assembly)));
            }
        }

        private bool plasma;

        public bool Plasma
        {
            get { return plasma; }
            set
            {

                plasma = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Plasma)));
            }
        }

        private bool laser;

        public bool Laser
        {
            get { return laser; }
            set
            {

                laser = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Laser)));
            }
        }

        private bool purchase;

        public bool Purchase
        {
            get { return purchase; }
            set
            {

                purchase = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Purchase)));
            }
        }

        private bool lathe;

        public bool Lathe
        {
            get { return lathe; }
            set
            {

                lathe = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Lathe)));
            }
        }

        private bool drill;

        public bool Drill
        {
            get { return drill; }
            set
            {

                drill = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Drill)));
            }
        }

        private bool fold;

        public bool Fold
        {
            get { return fold; }
            set
            {

                fold = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Fold)));
            }
        }

        private bool roll;

        public bool Roll
        {
            get { return roll; }
            set
            {

                roll = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nameof(Roll)));
            }
        }

        private bool saw;
        private double length;
        private string finish;
        private string purchaseInformation;
        private string supplierName;
        private string supplierCode;
        private double mass;

        public bool Saw
        {
            get { return saw; }
            set
            {

                saw = value;
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

        private string notes;

        public string Notes { get => notes; set => SetProperty(ref notes, value); }

    }
}
