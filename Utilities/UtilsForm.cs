﻿namespace SimpleCalc.Utilities;

public static class UtilsForm
{
    public static void ClearAll(TextBox textBox, Label firstNumber, Label labelOperator)
    {
        textBox.Text = "0";
        firstNumber.Text = "";
        labelOperator.Text = "";
        textBox.Focus();
    }

    public static void InsertNumber(TextBox textbox, string Button_number)
    {
        if (textbox.Text == "0")
        {
            textbox.Text = Button_number;
        }
        else
        {
            textbox.Text += Button_number;
        }
    }

    public static void InsertDecimalIfApplicable(TextBox textBox)
    {
        if (textBox.Text.Contains('.'))
        {

        }
        else
        {
            InsertNumber(textBox, ".");
        }
    }

    public static void Calculate(TextBox textBox, Label firstNumber, Label labelOperator)
    {
        string firstNumberStr = firstNumber.Text;
        string secondNumberStr = textBox.Text;

        try
        {
            double result = PerformOperation(firstNumberStr, secondNumberStr, labelOperator.Text);

            textBox.Text = result.ToString();

            textBox.Focus();
        }
        catch (Exception)
        {
            MessageBox.Show("Make sure that the operators are accompanied by numerical values.", ":/");
        }

    }

    public static void EraseOne(TextBox textBox)
    {
        string currentText = textBox.Text;

        if (!string.IsNullOrEmpty(currentText))
        {
            textBox.Text = currentText.Substring(0, currentText.Length - 1);
        }
    }

    private static double PerformOperation(string firstNumberStr, string secondNumberStr, string operatorStr)
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
