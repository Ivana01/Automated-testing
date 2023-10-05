namespace Section8
{
    public class ItemPrice
    {
        public ItemPrice(decimal price)
        {
            WholeSalePrice = price;
        }

        public decimal WholeSalePrice
        {
            get;
            set;
        }
    }
}
