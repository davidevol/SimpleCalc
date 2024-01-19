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
            UtilsForm.ClearAll(main_textBox, label_first_number, label_operator);
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            UtilsForm.ClearAll(main_textBox, label_first_number, label_operator);
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(main_textBox, "0");
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(main_textBox, "1");
        }
        private void Button_2_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(main_textBox, "2");
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(main_textBox, "3");
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(main_textBox, "4");
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(main_textBox, "5");
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(main_textBox, "6");
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(main_textBox, "7");
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(main_textBox, "8");
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertNumber(main_textBox, "9");

        }



        void operator_buttons(string op_type)
        {
            if (this.main_textBox.Text != "")
            {
                this.label_first_number.Text = this.main_textBox.Text;
            }
            this.label_operator.Text = op_type;
            this.main_textBox.Text = "";

            this.main_textBox.Focus();

        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            operator_buttons("+");
        }


        private void Button_minus_Click(object sender, EventArgs e)
        {
            operator_buttons("-");
        }

        private void Button_mult_Click(object sender, EventArgs e)
        {
            operator_buttons("x");
        }

        private void Button_div_Click(object sender, EventArgs e)
        {
            operator_buttons("/");
        }

        private void Button_equal_Click(object sender, EventArgs e)
        {
            UtilsForm.Calculate(main_textBox, label_first_number, label_operator);
        }

        private void Button_decimal_Click(object sender, EventArgs e)
        {
            UtilsForm.InsertDecimalIfApplicable(main_textBox);
        }

        private void Button_erase_Click(object sender, EventArgs e)
        {
            UtilsForm.EraseOne(main_textBox);
        }

        private void main_textBox_MouseHover(object sender, EventArgs e)
        {

            toolTip_read_number.AutoPopDelay = 30000;
            toolTip_read_number.InitialDelay = 1000;
            toolTip_read_number.ReshowDelay = 500;

            string result = this.main_textBox.Text;
            string digits = "It was not possible to read this number.";



            try
            {
                _ = double.TryParse(result, out double number);
                digits = NumberToWords(number);

                toolTip_read_number.Show(digits, main_textBox);
            }
            catch (Exception)
            {
                toolTip_read_number.Show(digits, main_textBox);
            }
        }

        private void main_textBox_MouseLeave(object sender, EventArgs e)
        {
            toolTip_read_number.Hide(main_textBox);
        }

        private void main_textBox_TextChanged(object sender, EventArgs e)
        {
            int textBoxLenght = main_textBox.Text.Length;

            if (textBoxLenght > 100)
            {
                main_textBox.Text = main_textBox.Text[..100];
            }
        }

        static string NumberToWords(double number)
        {
            int integerPart = (int)Math.Floor(number);
            int decimalPart = (int)Math.Round((number - integerPart) * 100);

            StringBuilder words = new StringBuilder();

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

            StringBuilder words = new StringBuilder();

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
                    operator_buttons(e.KeyChar.ToString());
                    e.Handled = true;
                    return;
                case '.':
                    UtilsForm.InsertDecimalIfApplicable(main_textBox);
                    e.Handled = true;
                    return;
                case '\r': // Enter
                    UtilsForm.Calculate(main_textBox, label_first_number, label_operator);
                    e.Handled = true;
                    return;
            }
        }
    }

}
