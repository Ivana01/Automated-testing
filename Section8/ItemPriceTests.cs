using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class ItemPriceTests
    {
        [TestMethod]

        public void Display_Retail_Price()
        {
            //call the constructor for trhe class and give it the item price
            ItemPrice myItem = new ItemPrice(12.99M);

            //header rows for tabular format
            Console.WriteLine("{0, -20} {1, 25}", "Item", "Percentage Increase");
            Console.WriteLine("{0,12}", "Price");

            //create the output in tabular format
            for (decimal percentage = 0.05M; percentage <= 0.10M; percentage += 0.01M)
            {
                Console.WriteLine("{0,12}", percentage);

            }

            //linebreak
            Console.WriteLine();

            Console.Write("{0, -10:C}", myItem.WholeSalePrice);

            //create the output in tabular format

            for (decimal percentage = 0.05M; percentage < 0.10M; percentage += 0.01M)
            {
                Console.WriteLine("{0,10}", (myItem.WholeSalePrice + (percentage * myItem.WholeSalePrice)));

            }
        }
    }
}
