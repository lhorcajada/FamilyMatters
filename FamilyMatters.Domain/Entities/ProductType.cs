namespace FamilyMatters.Domain.Entities
{
    public class ProductType(int value, string name)
    {
        public static readonly ProductType Insurance = new ProductType(1, nameof(Insurance));
        public static readonly ProductType Taxes = new ProductType(2, nameof(Taxes));
        public static readonly ProductType Shopping = new ProductType(3, nameof(Shopping));
        public static readonly ProductType Fuel = new ProductType(4, nameof(Fuel));
        public static readonly ProductType Vacations = new ProductType(5, nameof(Vacations));
        public static readonly ProductType Telecommunications = new ProductType(6, nameof(Telecommunications));
        public static readonly ProductType BankLoans = new ProductType(7, nameof(BankLoans));

        private readonly int _value = value;
        private readonly string _name = name;
        private static readonly ProductType[] Values = [Insurance, Taxes, Shopping, Fuel, Vacations, Telecommunications, BankLoans];
        public static IEnumerable<ProductType> GetAll() => Values;
        public static ProductType FromValue(int value) => Values.Single(x => x._value == value);
        public static ProductType FromName(string name) => Values.Single(x => x._name == name);

    }
}
