using System;
using System.Collections.Generic;
using System.IO;

namespace CustomerData
{
    public static class CustomerDB
    {
        const string path = "Customer.txt";

        /// <summary>
        /// Read Customers from text file
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetCustomers()
        {
            List<Customer> customersList = new List<Customer>();
            string line;
            string[] fields;
            Customer cus;
            using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    fields = line.Split('/');
                    cus = new Customer
                    {
                        AccountNo = Convert.ToInt32(fields[0]),
                        CustomerName = fields[1],
                        CustomerType = Convert.ToChar(fields[2]),
                        ChargeAmount = Convert.ToDouble(fields[3])
                    };
                    customersList.Add(cus);
                }
            }
            return customersList;
        }

        /// <summary>
        /// Saves customers info into a text file
        /// </summary>
        /// <param name="customersList"></param>
        public static void SaveCustomers(List<Customer> customersList)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write)))
            {
                foreach (Customer cus in customersList)
                {
                    sw.WriteLine(cus.ToFileString());
                }
            }
        }
    }
}

