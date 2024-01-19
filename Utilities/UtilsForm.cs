namespace SimpleCalc.Utilities;

public static class UtilsForm
{


    public static void EraseOne(TextBox textBox)
        {
            string currentText = textBox.Text;

            if (!string.IsNullOrEmpty(currentText))
            {
            textBox.Text = currentText.Substring(0, currentText.Length - 1);
            }
        }

    public static double PerformOperation(string firstNumberStr, string secondNumberStr, string operatorStr)
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
}
