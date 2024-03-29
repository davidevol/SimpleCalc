﻿namespace SimpleCalc
{
    partial class Forms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms));
            MainTextBox = new TextBox();
            Button_7 = new Button();
            Button_8 = new Button();
            Button_9 = new Button();
            Button_div = new Button();
            Button_mult = new Button();
            Button_6 = new Button();
            Button_5 = new Button();
            Button_4 = new Button();
            Button_minus = new Button();
            Button_3 = new Button();
            Button_2 = new Button();
            Button_1 = new Button();
            Button_plus = new Button();
            Button_erase = new Button();
            Button_0 = new Button();
            Button_decimal = new Button();
            Button_equal = new Button();
            clear_button = new Button();
            LabelFirstNumber = new Label();
            LabelOperator = new Label();
            ToolTipReadNumber = new ToolTip(components);
            SuspendLayout();
            // 
            // main_textBox
            // 
            MainTextBox.AcceptsReturn = true;
            MainTextBox.AcceptsTab = true;
            MainTextBox.BorderStyle = BorderStyle.FixedSingle;
            MainTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainTextBox.Location = new Point(25, 45);
            MainTextBox.MaxLength = 100;
            MainTextBox.Name = "MainTextBox";
            MainTextBox.ScrollBars = ScrollBars.Vertical;
            MainTextBox.Size = new Size(423, 61);
            MainTextBox.TabIndex = 0;
            MainTextBox.Text = "0";
            MainTextBox.TextAlign = HorizontalAlignment.Center;
            MainTextBox.TextChanged += MainTextBox_TextChanged;
            MainTextBox.KeyPress += main_textBox_KeyPress;
            MainTextBox.MouseLeave += MainTextBox_MouseLeave;
            MainTextBox.MouseHover += MainTextBox_MouseHover;
            // 
            // Button_7
            // 
            Button_7.Cursor = Cursors.Hand;
            Button_7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_7.Location = new Point(11, 233);
            Button_7.Name = "Button_7";
            Button_7.Size = new Size(105, 88);
            Button_7.TabIndex = 1;
            Button_7.Text = "7";
            Button_7.UseVisualStyleBackColor = true;
            Button_7.Click += Button7_Click;
            // 
            // Button_8
            // 
            Button_8.Cursor = Cursors.Hand;
            Button_8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_8.Location = new Point(127, 233);
            Button_8.Name = "Button_8";
            Button_8.Size = new Size(105, 88);
            Button_8.TabIndex = 2;
            Button_8.Text = "8";
            Button_8.UseVisualStyleBackColor = true;
            Button_8.Click += Button8_Click;
            // 
            // Button_9
            // 
            Button_9.Cursor = Cursors.Hand;
            Button_9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_9.Location = new Point(243, 233);
            Button_9.Name = "Button_9";
            Button_9.Size = new Size(105, 88);
            Button_9.TabIndex = 3;
            Button_9.Text = "9";
            Button_9.UseVisualStyleBackColor = true;
            Button_9.Click += Button9_Click;
            // 
            // Button_div
            // 
            Button_div.Cursor = Cursors.Hand;
            Button_div.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_div.Image = (Image)resources.GetObject("button_div.Image");
            Button_div.Location = new Point(359, 233);
            Button_div.Name = "Button_div";
            Button_div.Size = new Size(105, 88);
            Button_div.TabIndex = 4;
            Button_div.UseVisualStyleBackColor = true;
            Button_div.Click += ButtonDiv_Click;
            // 
            // Button_mult
            // 
            Button_mult.Cursor = Cursors.Hand;
            Button_mult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_mult.Image = (Image)resources.GetObject("button_mult.Image");
            Button_mult.Location = new Point(359, 333);
            Button_mult.Name = "Button_mult";
            Button_mult.Size = new Size(105, 88);
            Button_mult.TabIndex = 8;
            Button_mult.UseVisualStyleBackColor = true;
            Button_mult.Click += ButtonMult_Click;
            // 
            // Button_6
            // 
            Button_6.Cursor = Cursors.Hand;
            Button_6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_6.Location = new Point(243, 333);
            Button_6.Name = "Button_6";
            Button_6.Size = new Size(105, 88);
            Button_6.TabIndex = 7;
            Button_6.Text = "6";
            Button_6.UseVisualStyleBackColor = true;
            Button_6.Click += Button6_Click;
            // 
            // Button_5
            // 
            Button_5.Cursor = Cursors.Hand;
            Button_5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_5.Location = new Point(127, 333);
            Button_5.Name = "Button_5";
            Button_5.Size = new Size(105, 88);
            Button_5.TabIndex = 6;
            Button_5.Text = "5";
            Button_5.UseVisualStyleBackColor = true;
            Button_5.Click += Button5_Click;
            // 
            // Button_4
            // 
            Button_4.Cursor = Cursors.Hand;
            Button_4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_4.Location = new Point(11, 333);
            Button_4.Name = "Button_4";
            Button_4.Size = new Size(105, 88);
            Button_4.TabIndex = 5;
            Button_4.Text = "4";
            Button_4.UseVisualStyleBackColor = true;
            Button_4.Click += Button4_Click;
            // 
            // Button_minus
            // 
            Button_minus.Cursor = Cursors.Hand;
            Button_minus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_minus.Location = new Point(359, 435);
            Button_minus.Name = "Button_minus";
            Button_minus.Size = new Size(105, 88);
            Button_minus.TabIndex = 12;
            Button_minus.Text = "-";
            Button_minus.UseVisualStyleBackColor = true;
            Button_minus.Click += ButtonMinus_Click;
            // 
            // Button_3
            // 
            Button_3.Cursor = Cursors.Hand;
            Button_3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_3.Location = new Point(243, 435);
            Button_3.Name = "Button_3";
            Button_3.Size = new Size(105, 88);
            Button_3.TabIndex = 11;
            Button_3.Text = "3";
            Button_3.UseVisualStyleBackColor = true;
            Button_3.Click += Button3_Click;
            // 
            // Button_2
            // 
            Button_2.Cursor = Cursors.Hand;
            Button_2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_2.Location = new Point(127, 435);
            Button_2.Name = "Button_2";
            Button_2.Size = new Size(105, 88);
            Button_2.TabIndex = 10;
            Button_2.Text = "2";
            Button_2.UseVisualStyleBackColor = true;
            Button_2.Click += Button2_Click;
            // 
            // Button_1
            // 
            Button_1.Cursor = Cursors.Hand;
            Button_1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_1.Location = new Point(11, 435);
            Button_1.Name = "Button_1";
            Button_1.Size = new Size(105, 88);
            Button_1.TabIndex = 9;
            Button_1.Text = "1";
            Button_1.UseVisualStyleBackColor = true;
            Button_1.Click += Button1_Click;
            // 
            // Button_plus
            // 
            Button_plus.Cursor = Cursors.Hand;
            Button_plus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_plus.Image = (Image)resources.GetObject("button_plus.Image");
            Button_plus.Location = new Point(359, 534);
            Button_plus.Name = "Button_plus";
            Button_plus.Size = new Size(105, 88);
            Button_plus.TabIndex = 16;
            Button_plus.UseVisualStyleBackColor = true;
            Button_plus.Click += ButtonPlus_Click;
            // 
            // Button_erase
            // 
            Button_erase.Cursor = Cursors.Hand;
            Button_erase.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_erase.Image = (Image)resources.GetObject("button_erase.Image");
            Button_erase.Location = new Point(243, 534);
            Button_erase.Name = "Button_erase";
            Button_erase.Size = new Size(105, 88);
            Button_erase.TabIndex = 15;
            Button_erase.UseVisualStyleBackColor = true;
            Button_erase.Click += ButtonErase_Click;
            // 
            // Button_0
            // 
            Button_0.Cursor = Cursors.Hand;
            Button_0.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_0.Location = new Point(127, 534);
            Button_0.Name = "Button_0";
            Button_0.Size = new Size(105, 88);
            Button_0.TabIndex = 14;
            Button_0.Text = "0";
            Button_0.UseVisualStyleBackColor = true;
            Button_0.Click += Button0_Click;
            // 
            // Button_decimal
            // 
            Button_decimal.Cursor = Cursors.Hand;
            Button_decimal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_decimal.Location = new Point(11, 534);
            Button_decimal.Name = "Button_decimal";
            Button_decimal.Size = new Size(105, 88);
            Button_decimal.TabIndex = 13;
            Button_decimal.Text = ".";
            Button_decimal.UseVisualStyleBackColor = true;
            Button_decimal.Click += ButtonDecimal_Click;
            // 
            // Button_equal
            // 
            Button_equal.Cursor = Cursors.Hand;
            Button_equal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_equal.Location = new Point(243, 142);
            Button_equal.Name = "Button_equal";
            Button_equal.Size = new Size(221, 78);
            Button_equal.TabIndex = 18;
            Button_equal.Text = "=";
            Button_equal.UseVisualStyleBackColor = true;
            Button_equal.Click += ButtonEqual_Click;
            // 
            // clear_button
            // 
            clear_button.Cursor = Cursors.Hand;
            clear_button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear_button.Location = new Point(12, 142);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(221, 78);
            clear_button.TabIndex = 17;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += ClearButton_Click;
            // 
            // label_first_number
            // 
            LabelFirstNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFirstNumber.Location = new Point(324, 4);
            LabelFirstNumber.Name = "LabelFirstNumber";
            LabelFirstNumber.Size = new Size(88, 38);
            LabelFirstNumber.TabIndex = 19;
            LabelFirstNumber.Text = "100";
            LabelFirstNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_operator
            // 
            LabelOperator.Location = new Point(407, 11);
            LabelOperator.Name = "LabelOperator";
            LabelOperator.Size = new Size(59, 25);
            LabelOperator.TabIndex = 19;
            LabelOperator.Text = "+";
            LabelOperator.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CalculatorFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 640);
            Controls.Add(LabelOperator);
            Controls.Add(LabelFirstNumber);
            Controls.Add(Button_equal);
            Controls.Add(clear_button);
            Controls.Add(Button_plus);
            Controls.Add(Button_erase);
            Controls.Add(Button_0);
            Controls.Add(Button_decimal);
            Controls.Add(Button_minus);
            Controls.Add(Button_3);
            Controls.Add(Button_2);
            Controls.Add(Button_1);
            Controls.Add(Button_mult);
            Controls.Add(Button_6);
            Controls.Add(Button_5);
            Controls.Add(Button_4);
            Controls.Add(Button_div);
            Controls.Add(Button_9);
            Controls.Add(Button_8);
            Controls.Add(Button_7);
            Controls.Add(MainTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculatorFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SimpleCalc";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MainTextBox;
        private Button Button_7;
        private Button Button_8;
        private Button Button_9;
        private Button Button_div;
        private Button Button_mult;
        private Button Button_6;
        private Button Button_5;
        private Button Button_4;
        private Button Button_minus;
        private Button Button_3;
        private Button Button_2;
        private Button Button_1;
        private Button Button_plus;
        private Button Button_erase;
        private Button Button_0;
        private Button Button_decimal;
        private Button Button_equal;
        private Button clear_button;
        private Label LabelFirstNumber;
        private Label LabelOperator;
        private ToolTip ToolTipReadNumber;
    }
}
