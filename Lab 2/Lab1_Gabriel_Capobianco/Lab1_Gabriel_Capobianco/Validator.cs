using System;
using System.Windows.Forms;

namespace Lab1_Gabriel_Capobianco
{
    /// <summary>
    /// Repository of static Validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Check if the input box is empty
        /// </summary>
        /// <param name="textBox">Usage</param>
        /// <param name="name">Type of user</param>
        /// <returns>Entry is empty</returns>
        public static bool IsPresent(TextBox textBox, string name)
        {
            bool isValid = true;
            if (textBox.Text == "")
            {
                isValid = false;
                MessageBox.Show(name + " must not be empty", "Entry Error");
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// Check if the number entered is positive
        /// </summary>
        /// <param name="textBox">Usage</param>
        /// <param name="name">Type of user</param>
        /// <returns>Entry is not positive</returns>
        public static bool IsPositive(string textBox, string name)
        {
            double input = Convert.ToDouble(textBox);
            if (input >= 0)
                return true;
            else
            {
                MessageBox.Show(name + " must be a positive number.", "Entry Error");
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a positive integer number.", "Input error");
                textBox.Focus();
                return false;
            }
        }
        /// <summary>
        /// Validator to check if it is a Number
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>True if a number, False if a string</returns>
        public static bool IsNumber(TextBox textBox)
        {
            double number = 0;
            if (Double.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a number.", "Input error");
                textBox.Focus();
                return false;
            }
        }
    }
}
