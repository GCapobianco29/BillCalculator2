namespace CustomerData
{
    public class ResidentialCustomer : Customer
    {
        private const double RESI = 6.00;
        private static double usage;
        private static double total;
        public ResidentialCustomer(int accN, string name, char cusType, double use)
            : base(accN, name, cusType)
        {
            usage = use;
        }

        public static double CalculateCharge()
        {
            total = RESI + (usage * 0.052);
            return total;
        }

        //public override string ToString()
        //{
        //    //return $"The customer: {base.accountNo} has a charge of {CalculateCharge()}";
        //}
    }

}
