namespace Products.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} {TotalPrice().ToString("C")} (Customs fee: {CustomsFee.ToString("C")})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
