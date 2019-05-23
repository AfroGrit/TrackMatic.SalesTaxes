using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace TrackMatic.SalesTaxes
{
    public enum Type
    {
        Local,
        Import,
        Exempt
    }

    public class Cart : INotifyPropertyChanged, IDisposable
    {
        private string _name;
        private double _amount;

        public Type Type { get; }

        public List<string> Item { get; }

        public Cart(Type type)
        {
            Type = type;
            Item = new List<string>();
        }

        public Cart(Type type, string name, double amount) : this(type)
        {
            Name = name;
            Amount = amount;
        }

        public double Sales { get; private set; } = 0.0;
        public double Taxes { get; private set; } = 0.0;

        public double GetTaxRate()
        {
            switch (Type)
            {
                case Type.Local:
                    return 0.10;
                case Type.Import:
                    return 0.05;
                case Type.Exempt:
                    return 0;
                default:
                    break;
            }
            throw new ArgumentOutOfRangeException();
        }

        public void TotalSales()
        {
            if (Amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount));
            }
            Sales += Amount;
        }


        public double TotalTaxes()
        {
            switch (Type)
            {
                case Type.Local:
                    return Amount * 0.10;
                case Type.Import:
                    return Amount * 0.05;
                case Type.Exempt:
                    return Amount;
                default:
                    break;
            }
            throw new ArgumentOutOfRangeException();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public double Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Name;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void Dispose()
        {
        }


    }
}