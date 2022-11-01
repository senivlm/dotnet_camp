using static HW1.Product;

namespace HW1
{
    internal class Buy
        // покупка може включати кілька різних товарів
    {
        private Product _product;
        private double _count;

        public Product Product
        {
            get
            {
                return _product;
            }
            set
            {
                if (value.GetType() != typeof(Product) || value == null) { Console.WriteLine("Cannot set this value;"); }
                else { _product = value; }
            }
        }

        public double Count
        {
            get 
            {
                return _count;
            }
            set
            {
                if (((double)value).GetType() != typeof(double)) { Console.WriteLine("value is not a number;"); }
                else { _count = (double)value; }
            }
        }

        public Buy()
        {
        }

        public Buy(Product product, double count)
        {
            Product = product;
            Count = count;
        }

        public Buy(string name, WeightUnits weightunit, double weight, Currencies currency, double price, double count)
        {
            Product = new Product
                                {
                                    Name = name,
                                    Weight = weight,
                                    WeightUnit = weightunit,
                                    Price = price,
                                    Currency = currency
                                };
            Count = count;
        }

        public double BuySum()
        {
            return Product.Price * Count;
        }

        public override string ToString()
        {
            return $"Product: {Product}, count: {Count}\n";
        }
    }
}
