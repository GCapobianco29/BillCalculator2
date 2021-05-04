namespace CustomerData
{
    public class Customer
    {
        private int accountNo;
        //private char customerType;
        private double chargeAmount;
        //double resChargeTotal;



        public int AccountNo
        {
            get { return accountNo; }
            set
            {
                if (value >= 0) accountNo = value;
                else
                    accountNo = 0000;
            }
        }
        public string CustomerName { get; set; }

        public char CustomerType { get; set; }

        //public char CustomerType
        //{
        //    get { return customerType; }
        //    set
        //    {
        //        if (value == ' ')
        //            customerType = 'X';
        //    }
        //}

        public double ChargeAmount
        {
            get { return chargeAmount; }
            set
            {
                if (value >= 0) chargeAmount = value;
                else
                    chargeAmount = 0;
            }
        }

        public Customer(int accN = 0000, string name = "Unknown", char cusType = 'X', double charge = 00)
        {
            AccountNo = accN;
            CustomerName = name;
            CustomerType = cusType;
            ChargeAmount = charge;
        }
        public override string ToString()
        {
            return AccountNo + ":   " + CustomerName + ",   " + CustomerType + ",   (" + ChargeAmount.ToString("c") + ")";
        }

        public string ToFileString()
        {
            return AccountNo.ToString() + "/" + CustomerName + "/" + CustomerType.ToString() + "/" + ChargeAmount.ToString();
        }
    }
}











