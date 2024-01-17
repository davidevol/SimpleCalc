namespace SimpleCalc
{
    partial class CalculatorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorFrm));
            main_textBox = new TextBox();
            button_7 = new Button();
            button_8 = new Button();
            button_9 = new Button();
            button_div = new Button();
            button_mult = new Button();
            button_6 = new Button();
            button_5 = new Button();
            button_4 = new Button();
            button_minus = new Button();
            button_3 = new Button();
            button_2 = new Button();
            button_1 = new Button();
            button_plus = new Button();
            button_erase = new Button();
            button_0 = new Button();
            button_decimal = new Button();
            button_equal = new Button();
            clear_button = new Button();
            label_first_number = new Label();
            label_operator = new Label();
            toolTip_read_number = new ToolTip(components);
            SuspendLayout();
            // 
            // main_textBox
            // 
            main_textBox.AcceptsReturn = true;
            main_textBox.AcceptsTab = true;
            main_textBox.BorderStyle = BorderStyle.FixedSingle;
            main_textBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            main_textBox.Location = new Point(25, 45);
            main_textBox.MaxLength = 100;
            main_textBox.Name = "main_textBox";
            main_textBox.ScrollBars = ScrollBars.Vertical;
            main_textBox.Size = new Size(423, 61);
            main_textBox.TabIndex = 0;
            main_textBox.Text = "0";
            main_textBox.TextAlign = HorizontalAlignment.Center;
            main_textBox.TextChanged += main_textBox_TextChanged;
            main_textBox.KeyPress += main_textBox_KeyPress;
            main_textBox.MouseLeave += main_textBox_MouseLeave;
            main_textBox.MouseHover += main_textBox_MouseHover;
            // 
            // button_7
            // 
            button_7.Cursor = Cursors.Hand;
            button_7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_7.Location = new Point(11, 233);
            button_7.Name = "button_7";
            button_7.Size = new Size(105, 88);
            button_7.TabIndex = 1;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += button_7_Click;
            // 
            // button_8
            // 
            button_8.Cursor = Cursors.Hand;
            button_8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_8.Location = new Point(127, 233);
            button_8.Name = "button_8";
            button_8.Size = new Size(105, 88);
            button_8.TabIndex = 2;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += button_8_Click;
            // 
            // button_9
            // 
            button_9.Cursor = Cursors.Hand;
            button_9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_9.Location = new Point(243, 233);
            button_9.Name = "button_9";
            button_9.Size = new Size(105, 88);
            button_9.TabIndex = 3;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += button_9_Click;
            // 
            // button_div
            // 
            button_div.Cursor = Cursors.Hand;
            button_div.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_div.Image = (Image)resources.GetObject("button_div.Image");
            button_div.Location = new Point(359, 233);
            button_div.Name = "button_div";
            button_div.Size = new Size(105, 88);
            button_div.TabIndex = 4;
            button_div.UseVisualStyleBackColor = true;
            button_div.Click += button_div_Click;
            // 
            // button_mult
            // 
            button_mult.Cursor = Cursors.Hand;
            button_mult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_mult.Image = (Image)resources.GetObject("button_mult.Image");
            button_mult.Location = new Point(359, 333);
            button_mult.Name = "button_mult";
            button_mult.Size = new Size(105, 88);
            button_mult.TabIndex = 8;
            button_mult.UseVisualStyleBackColor = true;
            button_mult.Click += button_mult_Click;
            // 
            // button_6
            // 
            button_6.Cursor = Cursors.Hand;
            button_6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_6.Location = new Point(243, 333);
            button_6.Name = "button_6";
            button_6.Size = new Size(105, 88);
            button_6.TabIndex = 7;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += button_6_Click;
            // 
            // button_5
            // 
            button_5.Cursor = Cursors.Hand;
            button_5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_5.Location = new Point(127, 333);
            button_5.Name = "button_5";
            button_5.Size = new Size(105, 88);
            button_5.TabIndex = 6;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += button_5_Click;
            // 
            // button_4
            // 
            button_4.Cursor = Cursors.Hand;
            button_4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_4.Location = new Point(11, 333);
            button_4.Name = "button_4";
            button_4.Size = new Size(105, 88);
            button_4.TabIndex = 5;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += button_4_Click;
            // 
            // button_minus
            // 
            button_minus.Cursor = Cursors.Hand;
            button_minus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_minus.Location = new Point(359, 435);
            button_minus.Name = "button_minus";
            button_minus.Size = new Size(105, 88);
            button_minus.TabIndex = 12;
            button_minus.Text = "-";
            button_minus.UseVisualStyleBackColor = true;
            button_minus.Click += button_minus_Click;
            // 
            // button_3
            // 
            button_3.Cursor = Cursors.Hand;
            button_3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_3.Location = new Point(243, 435);
            button_3.Name = "button_3";
            button_3.Size = new Size(105, 88);
            button_3.TabIndex = 11;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += button_3_Click;
            // 
            // button_2
            // 
            button_2.Cursor = Cursors.Hand;
            button_2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_2.Location = new Point(127, 435);
            button_2.Name = "button_2";
            button_2.Size = new Size(105, 88);
            button_2.TabIndex = 10;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += button_2_Click;
            // 
            // button_1
            // 
            button_1.Cursor = Cursors.Hand;
            button_1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_1.Location = new Point(11, 435);
            button_1.Name = "button_1";
            button_1.Size = new Size(105, 88);
            button_1.TabIndex = 9;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_1_Click;
            // 
            // button_plus
            // 
            button_plus.Cursor = Cursors.Hand;
            button_plus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_plus.Image = (Image)resources.GetObject("button_plus.Image");
            button_plus.Location = new Point(359, 534);
            button_plus.Name = "button_plus";
            button_plus.Size = new Size(105, 88);
            button_plus.TabIndex = 16;
            button_plus.UseVisualStyleBackColor = true;
            button_plus.Click += button_plus_Click;
            // 
            // button_erase
            // 
            button_erase.Cursor = Cursors.Hand;
            button_erase.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_erase.Image = (Image)resources.GetObject("button_erase.Image");
            button_erase.Location = new Point(243, 534);
            button_erase.Name = "button_erase";
            button_erase.Size = new Size(105, 88);
            button_erase.TabIndex = 15;
            button_erase.UseVisualStyleBackColor = true;
            button_erase.Click += button_erase_Click;
            // 
            // button_0
            // 
            button_0.Cursor = Cursors.Hand;
            button_0.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_0.Location = new Point(127, 534);
            button_0.Name = "button_0";
            button_0.Size = new Size(105, 88);
            button_0.TabIndex = 14;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += button_0_Click;
            // 
            // button_decimal
            // 
            button_decimal.Cursor = Cursors.Hand;
            button_decimal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_decimal.Location = new Point(11, 534);
            button_decimal.Name = "button_decimal";
            button_decimal.Size = new Size(105, 88);
            button_decimal.TabIndex = 13;
            button_decimal.Text = ".";
            button_decimal.UseVisualStyleBackColor = true;
            button_decimal.Click += button_decimal_Click;
            // 
            // button_equal
            // 
            button_equal.Cursor = Cursors.Hand;
            button_equal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_equal.Location = new Point(243, 142);
            button_equal.Name = "button_equal";
            button_equal.Size = new Size(221, 78);
            button_equal.TabIndex = 18;
            button_equal.Text = "=";
            button_equal.UseVisualStyleBackColor = true;
            button_equal.Click += button_equal_Click;
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
            clear_button.Click += clear_button_Click;
            // 
            // label_first_number
            // 
            label_first_number.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_first_number.Location = new Point(324, 4);
            label_first_number.Name = "label_first_number";
            label_first_number.Size = new Size(88, 38);
            label_first_number.TabIndex = 19;
            label_first_number.Text = "100";
            label_first_number.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_operator
            // 
            label_operator.Location = new Point(407, 11);
            label_operator.Name = "label_operator";
            label_operator.Size = new Size(59, 25);
            label_operator.TabIndex = 19;
            label_operator.Text = "+";
            label_operator.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CalculatorFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 640);
            Controls.Add(label_operator);
            Controls.Add(label_first_number);
            Controls.Add(button_equal);
            Controls.Add(clear_button);
            Controls.Add(button_plus);
            Controls.Add(button_erase);
            Controls.Add(button_0);
            Controls.Add(button_decimal);
            Controls.Add(button_minus);
            Controls.Add(button_3);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(button_mult);
            Controls.Add(button_6);
            Controls.Add(button_5);
            Controls.Add(button_4);
            Controls.Add(button_div);
            Controls.Add(button_9);
            Controls.Add(button_8);
            Controls.Add(button_7);
            Controls.Add(main_textBox);
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

        private TextBox main_textBox;
        private Button button_7;
        private Button button_8;
        private Button button_9;
        private Button button_div;
        private Button button_mult;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_minus;
        private Button button_3;
        private Button button_2;
        private Button button_1;
        private Button button_plus;
        private Button button_erase;
        private Button button_0;
        private Button button_decimal;
        private Button button_equal;
        private Button clear_button;
        private Label label_first_number;
        private Label label_operator;
        private ToolTip toolTip_read_number;
    }
}
