using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Product
    {// Вітаю Вас. Все добре. 
        //Дуже доречно використати enum
        public enum WeightUnits
        {
            MILIGRAMM,
            GRAMM,
            KILOGRAMM,
            TONNE,
            BYPIECE
        }

        public enum Currencies
        {
            USD,
            UAH,
            EUR
        }

        private string _name;
        private double _weight;
        private WeightUnits _weightUnit;
        private double _price;
        private Currencies _currency;

        public Product()
        {
        }

        public Product(Product product)
        {
            Name = product.Name;
            Weight = product.Weight;
            WeightUnit = product.WeightUnit;
            Price = product.Price;
            Currency = product.Currency;
        }

        public Product(string name, WeightUnits weightunit, double weight, Currencies currency, double price)
        {
            Name = name;
            Weight = weight;
            WeightUnit = weightunit;
            Price = price;
            Currency = currency;
        }

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null)
                {// Наведіть приклад на занятті, коли виконається ця умова.
                    if (value.GetType() != typeof(string))
                    {
                        throw new ArgumentException("Inputed value is not a string.");
                    }
                    _name = value;
                }
                else { throw new ArgumentNullException("Name cannot be null."); }
            } 
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value != null)
                {
                    if (value.GetType() != typeof(double))
                    {
                        throw new ArgumentException("Inputed value is not a double.");
                    }
                    _weight = value;
                }
                else { throw new ArgumentNullException("Weight cannot be null."); }
            }
        }

        public WeightUnits WeightUnit
        {
            get
            {
                return _weightUnit;
            }
            set
            {
                if (value != null)
                {
                    if (value.GetType() != typeof(WeightUnits))
                    {
                        throw new ArgumentException("Inputed value is not a weight unit.");
                    }
                    _weightUnit = value;
                }
                else { throw new ArgumentNullException("You should choose weight unit."); }
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value != null)
                {
                    if (value.GetType() != typeof(double))
                    {
                        throw new ArgumentException("Inputed value is not a double.");
                    }
                    _price = value;
                }
                else { throw new ArgumentNullException("Price cannot be null."); }
            }
        }

        public Currencies Currency
        { 
            get
            {
                return _currency;
            }
            set
            {
                if (value != null)
                {
                    if (value.GetType() != typeof(Currencies))
                    {
                        throw new ArgumentException("Inputed value is not a valid currency.");
                    }
                    _currency = value;
                }
                else { throw new ArgumentNullException("You should choose currency."); }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, weight: {Weight} {WeightUnit}, price: {Price} {Currency}";
        }
    }
}
