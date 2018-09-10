/*
 * Name: Jaidan Escott
 * Date: 3/09/18
 * Version: 2
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        // Adds zero to the text display
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        // Adds one to the text display
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        // Adds two to the text display
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        // Adds three to the text display
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        // Adds four to the text display
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        // Adds five to the text display
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        // Adds six to the text display
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        // Adds seven to the text display
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        // Adds eight to the text display
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        // Adds nine to the text display
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        // Adds a decimal point to the text display
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text = txtDisplay.Text + btnDot.Text;
        }

        // Clears the text display
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        // Here we use two stored total amount when we begin using the 4 operators
        double storedAmount = 0;  // Before we use any of the 4 operators
        double newAmount = 0;   // After we use any of the 4 operators

        // These booleans store what was last used
        bool plusButtonClicked = false; // Used to know when the plus button was last clicked
        bool minusButtonClicked = false;    // Used to know when the minus button was last clicked
        bool divideButtonClicked = false;   // Used to know when the divide button was last clicked
        bool multiplyButtonClicked = false; // Used to know when the divide button was last clicked

        // Plus button was clicked so store the information
        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                // Prevent the button from being used when one of the four buttons were already pressed
                if (plusButtonClicked == true || minusButtonClicked == true || divideButtonClicked == true || multiplyButtonClicked == true)
                    return;

                // Stores the current number displayed in the text display in the variable
                storedAmount = MathLib.Arithmetic.Add(storedAmount, double.Parse(txtDisplay.Text));
                txtDisplay.Clear();

                // Let the program know this button was clicked
                plusButtonClicked = true;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = false;

                // Enable or disable the buttons necessary
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnEquals.Enabled = true;
            }
            catch (Exception)
            {
                // Display a warning message
                MessageBox.Show("Tried using something that isn't a number!", "Warning");
            }
        }

        // Minus button was clicked so store the information
        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                // Prevent the button from being used when one of the four buttons were already pressed
                if (plusButtonClicked == true || minusButtonClicked == true || divideButtonClicked == true || multiplyButtonClicked == true)
                    return;

                // Stores the current number displayed in the text display in the variable
                storedAmount = MathLib.Arithmetic.Add(storedAmount, double.Parse(txtDisplay.Text));
                txtDisplay.Clear();

                // Let the program know this button was clicked
                plusButtonClicked = false;
                minusButtonClicked = true;
                divideButtonClicked = false;
                multiplyButtonClicked = false;

                // Enable or disable the buttons necessary
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnEquals.Enabled = true;
            }
            catch (Exception)
            {
                // Display a warning message
                MessageBox.Show("Tried using something that isn't a number!", "Warning");
            }
        }

        // Divide button was clicked so store the information
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                // Prevent the button from being used when one of the four buttons were already pressed
                if (plusButtonClicked == true || minusButtonClicked == true || divideButtonClicked == true || multiplyButtonClicked == true)
                    return;

                // Stores the current number displayed in the text display in the variable
                storedAmount = MathLib.Arithmetic.Add(storedAmount, double.Parse(txtDisplay.Text));
                txtDisplay.Clear();

                // Let the program know this button was clicked
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = true;
                multiplyButtonClicked = false;

                // Enable or disable the buttons necessary
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnEquals.Enabled = true;
            }
            catch (Exception)
            {
                // Display a warning message
                MessageBox.Show("Tried using something that isn't a number!", "Warning");
            }
        }

        // Multiply button was clicked so store the information
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                // Prevent the button from being used when one of the four buttons were already pressed
                if (plusButtonClicked == true || minusButtonClicked == true || divideButtonClicked == true || multiplyButtonClicked == true)
                    return;

                // Stores the current number displayed in the text display in the variable
                storedAmount = MathLib.Arithmetic.Add(storedAmount, double.Parse(txtDisplay.Text));
                txtDisplay.Clear();

                // Let the program know this button was clicked
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = true;

                // Enable or disable the buttons necessary
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnEquals.Enabled = true;
            }
            catch (Exception)
            {
                // Display a warning message
                MessageBox.Show("Tried using something that isn't a number!", "Warning");
            }
        }

        // Equals button was pressed, perform the calculations
        private void btnEquals_Click(object sender, EventArgs e)
        {
            // Calculate
            if (plusButtonClicked == true)
            {
                // Plus button was the previously clicked button
                newAmount = MathLib.Arithmetic.Add(storedAmount, double.Parse(txtDisplay.Text));
            }
            else if (minusButtonClicked == true)
            {
                // Minus button was the previously clicked button
                newAmount = MathLib.Arithmetic.Subtract(storedAmount, double.Parse(txtDisplay.Text));
            }
            else if (divideButtonClicked == true)
            {
                // Divide button was the previously clicked button
                newAmount = MathLib.Arithmetic.Divide(storedAmount, double.Parse(txtDisplay.Text));

                // If the number results in Infinity (such as divided by 0) we need to stop it
                if (double.IsInfinity(newAmount))
                {
                    // Result in an error message
                    MessageBox.Show("Resulting number is invalid!", "Warning");
                    newAmount = 0;
                }
            }
            else if (multiplyButtonClicked == true)
            {
                // Multiply button was the previously clicked button
                newAmount = MathLib.Arithmetic.Multiply(storedAmount, double.Parse(txtDisplay.Text));
            }
            else
            {
                return;
            }

            // Set the display to the new amount
            txtDisplay.Text = newAmount.ToString();

            // Reset stored amounts in the variables
            storedAmount = 0;
            newAmount = 0;

            // Reset last clicked variables
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;

            // Enable or disable the necessary buttons
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnEquals.Enabled = false;
        }

        // SquareRoot the current number in the display
        private void btnSQRT_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse and store the number in this variable
                double number = double.Parse(txtDisplay.Text);

                // Only square root the number if it's 0 or over
                if (number >= 0)
                {
                    txtDisplay.Text = MathLib.Algebraic.SQRT(number).ToString();
                }
                else
                {
                    // Result in a warning if it is below 0
                    MessageBox.Show("Number must be a positive!", "Warning");
                    txtDisplay.Clear();
                }
            }
            catch (Exception)
            {
                // User typed in something that isn't a number
                MessageBox.Show("Tried using something that isn't a number!", "Warning");
            }
        }

        // CubeRoot the current number in the display
        private void btnCBRT_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse and store the number in this variable
                double number = double.Parse(txtDisplay.Text);
                txtDisplay.Text = MathLib.Algebraic.CBRT(number).ToString();
            }
            catch (Exception)
            {
                // User typed in something that isn't a number
                MessageBox.Show("Tried using something that isn't a number!", "Warning");
            }
        }

        // Inverses the current number in the display
        private void btnInverse_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse and store the number in this variable
                double number = double.Parse(txtDisplay.Text);
                if (number != 0)
                {
                    // If the number is not 0, inverse the number
                    txtDisplay.Text = MathLib.Algebraic.Inverse(number).ToString();
                }
                else
                {
                    // Number is 0, display a message
                    MessageBox.Show("Number cannot be 0!", "Warning");
                    txtDisplay.Clear();
                }
            }
            catch (Exception)
            {
                // Used something that is not a number
                MessageBox.Show("Tried using something that isn't a number!", "Warning");
            }
        }

        // Find the tangent of the given angle
        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse and store the number in this variable
                double number = double.Parse(txtDisplay.Text);
                if (number < 90)
                {
                    // Tangent requires a number between 0 and 89
                    txtDisplay.Text = MathLib.Trigonometric.Tan(number).ToString();
                }
                else
                {
                    // If it is below 0 or is 90, result in a message
                    MessageBox.Show("Number must be valid (below 90)!", "Warning");
                    txtDisplay.Clear();
                }
            }
            catch (Exception)
            {
                // Used something that is not a number
                MessageBox.Show("Tried using something that isn't a number!", "Warning");
            }
        }

        // Find the sine of the given angle
        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse and store the number in this variable
                double number = double.Parse(txtDisplay.Text);
                txtDisplay.Text = MathLib.Trigonometric.Sine(number).ToString();
            }
            catch (Exception)
            {
                // Used something that is not a number
                MessageBox.Show("Tried using something that isn't a number!", "Warning");
            }
        }

        // Find the cosine of the given angle
        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse and store the number in this variable
                double number = double.Parse(txtDisplay.Text);
                txtDisplay.Text = MathLib.Trigonometric.Cosine(number).ToString();
            }
            catch (Exception)
            {
                // Used something that is not a number
                MessageBox.Show("Tried using something that isn't a number!", "Warning");
            }
        }

        // Clears the display
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Use the clear method on the display
            txtDisplay.Clear();
        }

        // Quits the program
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates a message box with two buttons
            if (MessageBox.Show("Do you really want to quit?", "Quit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit(); // Exit the program
            }
        }
    }
}
