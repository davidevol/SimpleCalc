using SimpleCalc.Utilities;
using System.Text;

namespace SimpleCalc
{
    public partial class Forms : Form
    {
        public Forms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UtilsForm.ClearAll(MainTextBox, LabelFirstNumber, LabelOperator);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UtilsForm.ClearAll(MainTextBox, LabelFirstNumber, LabelOperator);
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(MainTextBox, "0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(MainTextBox, "1");
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(MainTextBox, "2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(MainTextBox, "3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(MainTextBox, "4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(MainTextBox, "5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(MainTextBox, "6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(MainTextBox, "7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(MainTextBox, "8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(MainTextBox, "9");

        }


        void InsertOperator(string operatorType)
        {
            if (this.MainTextBox.Text != "")
            {
                this.LabelFirstNumber.Text = this.MainTextBox.Text;
            }
            this.LabelOperator.Text = operatorType;
            this.MainTextBox.Text = "";

            this.MainTextBox.Focus();

        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            InsertOperator("+");
        }


        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            InsertOperator("-");
        }

        private void ButtonMult_Click(object sender, EventArgs e)
        {
            InsertOperator("x");
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            InsertOperator("/");
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            UtilsForm.Calculate(MainTextBox, LabelFirstNumber, LabelOperator);
        }

        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertDecimalIfApplicable(MainTextBox);
        }

        private void ButtonErase_Click(object sender, EventArgs e)
        {
            UtilsForm.EraseOne(MainTextBox);
        }

        private void MainTextBox_MouseHover(object sender, EventArgs e)
        {

            ToolTipReadNumber.AutoPopDelay = 30000;
            ToolTipReadNumber.InitialDelay = 1000;
            ToolTipReadNumber.ReshowDelay = 500;

            string result = this.MainTextBox.Text;
            string digits = "It was not possible to read this number.";



            try
            {
                if (double.TryParse(result, out double number))
                {
                    digits = NumberToWords(number);
                    ToolTipReadNumber.Show(digits, MainTextBox);
                }
            }
            catch (Exception)
            {
                ToolTipReadNumber.Show(digits, MainTextBox);
            }
        }

        private void MainTextBox_MouseLeave(object sender, EventArgs e)
        {
            ToolTipReadNumber.Hide(MainTextBox);
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            int textBoxLenght = MainTextBox.Text.Length;

            if (textBoxLenght > 100)
            {
                MainTextBox.Text = MainTextBox.Text[..100];
            }
        }

        static string NumberToWords(double number)
        {
            int integerPart = (int)Math.Floor(number);
            int decimalPart = (int)Math.Round((number - integerPart) * 100);

            StringBuilder words = new();

            if (integerPart == 0 && decimalPart == 0)
                return "zero";

            if (integerPart < 0)
                words.Append("minus ");

            words.Append(NumberToWords(Math.Abs(integerPart)));

            if (decimalPart > 0)
            {
                words.Append(" point ");
                words.Append(NumberToWords(decimalPart));
            }

            return words.ToString();
        }

        static string NumberToWords(int number)
        {
            string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number == 0)
                return "zero";

            if (number < 0)
                return "menos " + NumberToWords(Math.Abs(number));

            StringBuilder words = new();

            if ((number / 1000000000) > 0)
            {
                words.Append(NumberToWords(number / 1000000000) + " billion ");
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words.Append(NumberToWords(number / 1000000) + " million ");
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words.Append(NumberToWords(number / 1000) + " thousand ");
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words.Append(NumberToWords(number / 100) + " hundred ");
                number %= 100;
            }

            if (number > 0)
            {
                if (words.Length > 0)
                    words.Append("and ");

                if (number < 10)
                    words.Append(units[number]);
                else if (number < 20)
                    words.Append(teens[number - 11]);
                else
                {
                    words.Append(tens[number / 10]);
                    if ((number % 10) > 0)
                        words.Append(" " + units[number % 10]);
                }
            }

            return words.ToString();
        }

        private void main_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            string charactersAllowed = "0123456789+-/x.\r";

            if (!char.IsControl(e.KeyChar) && !charactersAllowed.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
            switch (e.KeyChar)
            {
                case '+':
                case '-':
                case 'x':
                case '/':
                    InsertOperator(e.KeyChar.ToString());
                    e.Handled = true;
                    return;
                case '.':
                    UtilsForm.InsertDecimalIfApplicable(MainTextBox);
                    e.Handled = true;
                    return;
                case '\r': // Enter
                    UtilsForm.Calculate(MainTextBox, LabelFirstNumber, LabelOperator);
                    e.Handled = true;
                    return;
            }
        }
    }

}
