namespace UnitTestProject
{
    public class Receipt
    {
        //properties
        private int receiptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerName;
        private string customerAddress;
        private string customerPhoneNumber;
        private int itemNumber;
        private string description;
        private decimal unitPrice;
        private int quantityPurchased;

        //constructor
        public Receipt(int receiptNum, string purchaseDate, int customerNum, string name, string address, string customerPhoneNum,
                       int itemNum, string desc, decimal price, int quantity)
        {
            ReceiptNumber = receiptNum;
            DateOfPurchase = purchaseDate;
            CustomerNumber = customerNum;
            CustomerName = name;
            CustomerAddress = address;
            CustomerPhoneNumber = customerPhoneNum;
            ItemNumber = itemNum;
            Description = desc;
            UnitPrice = price;
            QuantityPurchased = quantity;
        }

        //get set values
        public int ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                if (value > 0)
                {
                    receiptNumber = value;
                }
            }
        }
        public string DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }
            set
            {
                dateOfPurchase = value;
            }
        }
        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                if (value > 0)
                {
                    customerNumber = value;
                }
            }
        }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }

        public string CustomerPhoneNumber
        {
            get
            {
                return customerPhoneNumber;
            }
            set
            {
                customerPhoneNumber = value;
            }
        }

        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                if (value > 0 && value < 9999)
                {
                    itemNumber = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if (value > 0 && value < 9999)
                {
                    unitPrice = value;
                }
            }
        }

        public int QuantityPurchased
        {
            get
            {
                return quantityPurchased;
            }
            set
            {
                if (value > 0)
                {
                    quantityPurchased = value;
                }
            }
        }

        //methods

        public decimal TotalCost()
        {
            return QuantityPurchased + UnitPrice;
        }

        public override string ToString()
        {
            return "Customer Name: " + CustomerName +
                "Customer Phone Number: " + CustomerPhoneNumber +
                "\nTotal Purchases:" + TotalCost().ToString("C");
        }
    }
}



