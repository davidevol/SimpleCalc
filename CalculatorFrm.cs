using System.Text;

namespace SimpleCalc
{
    public partial class CalculatorFrm : Form
    {
        public CalculatorFrm()
        {
            InitializeComponent();
        }

        void clear_all()
        {
            this.main_textBox.Text = "0";
            this.label_first_number.Text = "";
            this.label_operator.Text = "";
            this.main_textBox.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear_all();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all();
        }


        private void button_0_Click(object sender, EventArgs e)
        {
            numeric_calc("0");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            numeric_calc("1");
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            numeric_calc("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            numeric_calc("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            numeric_calc("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            numeric_calc("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            numeric_calc("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            numeric_calc("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            numeric_calc("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            numeric_calc("9");

        }
        void numeric_calc(string button_number)
        {
            if (this.main_textBox.Text == "0")
            {
                this.main_textBox.Text = button_number;
            }
            else
            {
                this.main_textBox.Text += button_number;
            }
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

        private void button_plus_Click(object sender, EventArgs e)
        {
            operator_buttons("+");
        }


        private void button_minus_Click(object sender, EventArgs e)
        {
            operator_buttons("-");
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            operator_buttons("x");
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            operator_buttons("/");
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            string firstNumberStr = this.label_first_number.Text;
            string secondNumberStr = this.main_textBox.Text;

            try
            {
                double result = PerformOperation(firstNumberStr, secondNumberStr, this.label_operator.Text);

                this.main_textBox.Text = result.ToString();

                this.main_textBox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure that the operators are accompanied by numerical values.", ":/");
            }

        }

        private void button_decimal_Click(object sender, EventArgs e)
        {
            if (this.main_textBox.Text.Contains(".") == true)
            {
                return;
            }
            else
            {
                numeric_calc(".");
            }
        }
        private double PerformOperation(string firstNumberStr, string secondNumberStr, string operatorStr)
        {
            double fn = double.Parse(firstNumberStr);
            double sn = double.Parse(secondNumberStr);
            double result = 0;

            switch (operatorStr)
            {
                case "+":
                    result = fn + sn;
                    break;
                case "-":
                    result = fn - sn;
                    break;
                case "x":
                    result = fn * sn;
                    break;
                case "/":
                    result = fn / sn;
                    break;

                default:
                    result = 0;
                    break;
            }

            return result;
        }

        private void button_erase_Click(object sender, EventArgs e)
        {
            EraseOne();
        }

        private void EraseOne()
        {
            string currentText = this.main_textBox.Text;

            if (!string.IsNullOrEmpty(currentText))
            {
                this.main_textBox.Text = currentText.Substring(0, currentText.Length - 1);
            }
        }

        private void main_textBox_MouseHover(object sender, EventArgs e)
        {

            toolTip_read_number.AutoPopDelay = 30000;
            toolTip_read_number.InitialDelay = 1000;
            toolTip_read_number.ReshowDelay = 500;

            string result = this.main_textBox.Text;
            double number;
            string digits = "It was not possible to read this number.";



            try
            {
                double.TryParse(result, out number);
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

            string charactersAllowed = "0123456789+-/x.";

            if (!char.IsControl(e.KeyChar) && !charactersAllowed.Contains(e.KeyChar) && e.KeyChar != '\r')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\r')
            {
                Calculate();
                e.Handled = true;
            }
            switch (e.KeyChar)
            {
                case '+':
                case '-':
                case 'x':
                case '/':
                    e.Handled = true;
                    operator_buttons(e.KeyChar.ToString());
                    break;
            }


        }
    }

}
