namespace Lab1_Gabriel_Capobianco
{
    /// <summary>
    /// Repository of methods to calculate the total to pay by each type of customer
    /// </summary>
    public class Calculate
    {
        /// <summary>
        /// Calculates amount to pay by a Residential User
        /// </summary>
        /// <param name="rate">Residential rate</param>
        /// <param name="usage">Residential Usage</param>
        /// <returns>Total to pay</returns>
        public static double ResiTotal(double rate, double usage)
        {
            double total;
            total = rate + (usage * 0.052);
            return total;
        }

        /// <summary>
        /// Calculates amount to pay by a Commercial User
        /// </summary>
        /// <param name="rate">Commercial Rate</param>
        /// <param name="usage">Commercial Usage</param>
        /// <returns>Total to pay</returns>
        public static double CommTotal(double rate, double usage)
        {
            double total;
            if (usage <= 1000)
                total = rate;
            else
                total = rate + ((usage - 1000) * 0.045);

            return total;
        }

        /// <summary>
        /// Calculates amount to pay by a Industrial User
        /// </summary>
        /// <param name="PeakRate">Peak hours rate</param>
        /// <param name="OffPeakRate">Off-peak hours rate</param>
        /// <param name="PeakUsage">Peak hour usage</param>
        /// <param name="OffPeakUsage">Off-peak hour usage</param>
        /// <returns>Total to pay</returns>
        public static double IndTotal(double PeakRate, double OffPeakRate, double PeakUsage, double OffPeakUsage)
        {
            double total, peakTotal, offPeakTotal;
            if (PeakUsage <= 1000)
                peakTotal = PeakRate;
            else
                peakTotal = PeakRate + ((PeakUsage - 1000) * 0.065);

            if (OffPeakUsage <= 1000)
                offPeakTotal = OffPeakRate;
            else
                offPeakTotal = OffPeakRate + ((OffPeakUsage - 1000) * 0.028);

            total = peakTotal + offPeakTotal;
            return total;
        }
    }
}
