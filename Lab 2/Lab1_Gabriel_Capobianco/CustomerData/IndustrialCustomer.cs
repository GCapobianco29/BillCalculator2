namespace CustomerData
{
    public class IndustrialCustomer : Customer
    {
        private const double IND_PEAK = 76.00;
        private const double IND_OFF = 40.00;
        private static double PeakUsage, OffPeakUsage;
        private static double total;

        public IndustrialCustomer(int accN, string name, char cusType, double pU, double oPu, double charge)
            : base(accN, name, cusType, charge)
        {
            PeakUsage = pU;
            OffPeakUsage = oPu;
        }

        public static double CalculateCharge()
        {
            double peakTotal, offPeakTotal;
            if (PeakUsage <= 1000)
                peakTotal = IND_PEAK;
            else
                peakTotal = IND_PEAK + ((PeakUsage - 1000) * 0.065);

            if (OffPeakUsage <= 1000)
                offPeakTotal = IND_OFF;
            else
                offPeakTotal = IND_OFF + ((OffPeakUsage - 1000) * 0.028);

            total = peakTotal + offPeakTotal;
            return total;
        }
        //public override string ToString()
        //{
        //    //return "The customer: " + base.ToString() + " has a charge of " + total.ToString("c");
        //    //return $"The customer: {base.accountNo} has a charge of {CalculateCharge()}";
        //}
    }
}
