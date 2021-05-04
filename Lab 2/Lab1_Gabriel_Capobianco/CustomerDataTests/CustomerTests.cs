using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerData.Tests
{
    [TestClass()]

    // Residential Calculate Charge test
    public class CustomerTests
    {
        // Constructor test
        [TestMethod()]
        public void ResidentialChargeTestZeroArgument()
        {
            // Arrange
            double initial = 0;
            double final = 0;
            double actual;
            Customer cust;

            // Act
            cust = new Customer(0, "Unknow", 'X', initial);
            actual = cust.ChargeAmount;


            // Assert
            Assert.AreEqual(final, initial);

        }
        [TestMethod()]
        public void ResidentialChargeTestPositiveArgument()
        {
            // Arrange
            double initial = 100;
            double final = 100;
            double actual;
            Customer cust;

            // Act
            cust = new Customer(0, "Unknow", 'X', initial);
            actual = cust.ChargeAmount;


            // Assert
            Assert.AreEqual(final, initial);

        }


        // Commercial Calculate Charge test
        [TestMethod()]
        public void CommercialChargeTestZeroArgument()
        {
            // Arrange
            double initial = 0;
            double final = 0;
            double actual;
            Customer cust;

            // Act
            cust = new Customer(0, "Unknow", 'X', initial);
            actual = cust.ChargeAmount;


            // Assert
            Assert.AreEqual(final, initial);

        }
        [TestMethod()]
        public void CommercialChargeTestPositiveArgument()
        {
            // Arrange
            double initial = 100;
            double final = 100;
            double actual;
            Customer cust;

            // Act
            cust = new Customer(0, "Unknow", 'X', initial);
            actual = cust.ChargeAmount;


            // Assert
            Assert.AreEqual(final, initial);

        }
        // Industrial Calculate Charge test
        [TestMethod()]
        public void IndustrialChargeTestZeroArgument()
        {
            // Arrange
            double initial = 0;
            double final = 0;
            double actual;
            Customer cust;

            // Act
            cust = new Customer(0, "Unknow", 'X', initial);
            actual = cust.ChargeAmount;


            // Assert
            Assert.AreEqual(final, initial);

        }
        [TestMethod()]
        public void IndustrialChargeTestPositiveArgument()
        {
            // Arrange
            double initial = 100;
            double final = 100;
            double actual;
            Customer cust;

            // Act
            cust = new Customer(0, "Unknow", 'X', initial);
            actual = cust.ChargeAmount;


            // Assert
            Assert.AreEqual(final, initial);

        }

    }
}