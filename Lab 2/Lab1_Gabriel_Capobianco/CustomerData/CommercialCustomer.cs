namespace CustomerData
{
    public class CommercialCustomer : Customer
    {
        private const double COMM = 60.00;
        private static double usage;
        private static double total;

        public CommercialCustomer(int accN, string name, char cusType, double use, double charge)
            : base(accN, name, cusType, charge)
        {
            usage = use;
        }

        public static double CalculateCharge()
        {
            if (usage <= 1000)
                total = COMM;
            else
                total = COMM + ((usage - 1000) * 0.045);
            return total;
        }
        //public override string ToString()
        //{
        //    //return $"The customer: {base.accountNo} has a charge of {CalculateCharge()}";
        //}
    }
}
