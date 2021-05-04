using CustomerData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*************************************************************************************
**            This app Calculates a customer bill from the city power company.      **
**              Author: Gabriel Capobianco                                          **
**              Date: December 2020                                                 **
*************************************************************************************/
namespace Lab1_Gabriel_Capobianco
{
    public partial class BillCalculator : Form
    {
        const double RESI = 6.00;           //residential rate
        const double COMM = 60.00;          //commercial rate
        const double IND_PEAK = 76.00;      //Industrial peak hour rate
        const double IND_OFF = 40.00;       //Industrial off-peak hour rate
        double usage;
        double peakUsage, offPeakUsage;
        double billTotal;
        char cusType;
        double resChargeTotal = 0, commChargeTotal = 0, indChargeTotal = 0;

        List<Customer> customerlist;

        public BillCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // When the form loads the Industrial box will be hidden and Residential radio button selected as default
            industrialBox.Visible = false;
            radioButtonResidential.Checked = true;
            btnAdd.Visible = false;
            customerlist = CustomerDB.GetCustomers();
            DisplayCustomers();
            DisplaySumOfCharges();
        }
        /// <summary>
        /// Display every Customer in the List to the listbox
        /// </summary>
        private void DisplayCustomers()
        {
            listCustomersBox.Items.Clear();
            foreach (Customer cus in customerlist)
            {
                listCustomersBox.Items.Add(cus);
            }
            textBoxCustSum.Text = customerlist.Count.ToString();
        }

        private void DisplaySumOfCharges()
        {
            foreach (Customer cus in customerlist)
            {
                if (cus.CustomerType == 'R')
                {
                    resChargeTotal += cus.ChargeAmount;
                }
                else if (cus.CustomerType == 'C')
                {
                    commChargeTotal += cus.ChargeAmount;
                }
                else if (cus.CustomerType == 'I')
                {
                    indChargeTotal += cus.ChargeAmount;
                }
            }
            textBoxResTotal.Text = resChargeTotal.ToString("c");
            textBoxCommTotal.Text = commChargeTotal.ToString("c");
            textBoxIndTotal.Text = indChargeTotal.ToString("c");
            double allSums = resChargeTotal + commChargeTotal + indChargeTotal;
            textBoxSumofAllCharges.Text = allSums.ToString("c");
        }

        private void DisplayNewSumOfCharges()
        {
            // get data of new product
            int accNo = Convert.ToInt32(textBoxAccNo.Text);
            string name = textBoxName.Text;

            if (radioButtonResidential.Checked == true)
                cusType = 'R';
            else if (radioButtonCommercial.Checked == true)
                cusType = 'C';
            else if (radioButtonIndustrial.Checked == true)
                cusType = 'I';

            Customer newCustomer = new Customer(accNo, name, cusType, billTotal);
            // add it to the list and display
            customerlist.Add(newCustomer);

            if (newCustomer.CustomerType == 'R')
            {
                resChargeTotal += newCustomer.ChargeAmount;
            }
            else if (newCustomer.CustomerType == 'C')
            {
                commChargeTotal += newCustomer.ChargeAmount;
            }
            else if (newCustomer.CustomerType == 'I')
            {
                indChargeTotal += newCustomer.ChargeAmount;
            }
            textBoxResTotal.Text = resChargeTotal.ToString("c");
            textBoxCommTotal.Text = commChargeTotal.ToString("c");
            textBoxIndTotal.Text = indChargeTotal.ToString("c");
            double allSums = resChargeTotal + commChargeTotal + indChargeTotal;
            textBoxSumofAllCharges.Text = allSums.ToString("c");
        }

        private void RadioButtonResidential_CheckedChanged(object sender, EventArgs e)
        {
            // When selected industrial box will be hidden
            industrialBox.Visible = false;
            label2.Visible = true;
            textBox1.Visible = true;
            btnAdd.Visible = false;
        }

        private void RadioButtonCommercial_CheckedChanged(object sender, EventArgs e)
        {
            // When selected industrial box will be hidden
            industrialBox.Visible = false;
            label2.Visible = true;
            textBox1.Visible = true;
            btnAdd.Visible = false;
        }

        private void RadioButtonIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            // When selected industrial box will show and residential and commercial usage text box hidden
            industrialBox.Visible = true;
            label2.Visible = false;
            textBox1.Visible = false;
            btnAdd.Visible = false;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)     // Button that calls the methods to calculate the bill total
        {
            if (radioButtonResidential.Checked == true && Validator.IsPresent(textBox1, "Residential Usage"))  // When the Radio button Residential is selected
            {
                // when Residential radio button is selected the Usage text box is tested to see if it is empty
                // or if the input is negative
                if (Validator.IsNumber(textBox1) && Validator.IsPositive(textBox1.Text, "Residential Usage"))
                {
                    usage = Convert.ToDouble(textBox1.Text);
                    billTotal = Calculate.ResiTotal(RESI, usage);       // Calculate the bill total thru a method
                    txtTotal.Text = billTotal.ToString("c");        // Show total in Currency format
                    btnAdd.Visible = true;
                }
            }

            if (radioButtonCommercial.Checked == true && Validator.IsPresent(textBox1, "Commercial Usage"))    // When the Radio button Comercial is selected
            {
                // when Commercial radio button is selected the Usage text box is tested to see if it is empty
                // or if the input is negative
                if (Validator.IsNumber(textBox1) && Validator.IsPositive(textBox1.Text, "Commercial Usage"))
                {
                    usage = Convert.ToDouble(textBox1.Text);
                    billTotal = Calculate.CommTotal(COMM, usage);       // Calculate the bill total thru a method
                    txtTotal.Text = billTotal.ToString("c");            // Show total in Currency format
                    btnAdd.Visible = true;
                }
            }

            if (radioButtonIndustrial.Checked == true)
            {
                // when Industrial radio button is selected the Peak and Off-Peak hours text boxes are tested to see if they are empty
                // or if the input is negative
                if (Validator.IsNumber(textBox2) && Validator.IsNumber(textBox3))
                {
                    if (Validator.IsPresent(textBox2, "Peak hours Usage") && Validator.IsPresent(textBox3, "Off-Peak hours Usage"))
                    {
                        if (Validator.IsPositive(textBox2.Text, "Peak hours Usage") && Validator.IsPositive(textBox3.Text, "Off-Peak hours Usage"))
                        {
                            peakUsage = Convert.ToDouble(textBox2.Text);
                            offPeakUsage = Convert.ToDouble(textBox3.Text);
                            billTotal = Calculate.IndTotal(IND_PEAK, IND_OFF, peakUsage, offPeakUsage);     // Calculate the bill total thru a method
                            txtTotal.Text = billTotal.ToString("c");                                        // Show total in Currency format
                            btnAdd.Visible = true;
                        }
                    }
                }
            }
        }
       
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Erase whatever it is in the text boxes and put the app to default
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txtTotal.Text = "";
            textBoxAccNo.Text = "";
            textBoxName.Text = "";
            industrialBox.Visible = false;
            radioButtonResidential.Checked = true;
            textBox1.Focus();
            btnAdd.Visible = false;
        }
       
        private void btnExit_Click(object sender, EventArgs e)          // Terminate the application
        {
            //Application.Exit();

            // Save Customer info into the .txt File
            CustomerDB.SaveCustomers(customerlist);
            // Close the app
            this.Close();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validator.IsInt32(textBoxAccNo) && Validator.IsPositive(textBoxAccNo.Text, "Account No") &&
                Validator.IsPresent(textBoxName, "Customer Name") && Validator.IsPresent(textBoxAccNo, "Account No"))
            {
                // Update the new sums
                DisplayNewSumOfCharges();

                // Display the new Customer info in the List box
                DisplayCustomers();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                txtTotal.Text = "";
                textBoxAccNo.Text = "";
                textBoxName.Text = "";
                btnAdd.Visible = false;
            }
        }
    }
}






