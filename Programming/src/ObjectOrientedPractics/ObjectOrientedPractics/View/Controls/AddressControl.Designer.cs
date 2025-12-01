namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            AddressApartmentTextBox = new TextBox();
            AddressBuildingTextBox = new TextBox();
            AddressCityTextBox = new TextBox();
            AddressStreetTextBox = new TextBox();
            AddressCountryTextBox = new TextBox();
            AddressIndexTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AddressApartmentTextBox);
            panel1.Controls.Add(AddressBuildingTextBox);
            panel1.Controls.Add(AddressCityTextBox);
            panel1.Controls.Add(AddressStreetTextBox);
            panel1.Controls.Add(AddressCountryTextBox);
            panel1.Controls.Add(AddressIndexTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 289);
            panel1.TabIndex = 0;
            // 
            // AddressApartmentTextBox
            // 
            AddressApartmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressApartmentTextBox.BorderStyle = BorderStyle.FixedSingle;
            AddressApartmentTextBox.Location = new Point(469, 198);
            AddressApartmentTextBox.Name = "AddressApartmentTextBox";
            AddressApartmentTextBox.Size = new Size(175, 35);
            AddressApartmentTextBox.TabIndex = 12;
            AddressApartmentTextBox.TextChanged += AddressApartmentTextBox_TextChanged;
            // 
            // AddressBuildingTextBox
            // 
            AddressBuildingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressBuildingTextBox.BorderStyle = BorderStyle.FixedSingle;
            AddressBuildingTextBox.Location = new Point(123, 198);
            AddressBuildingTextBox.Name = "AddressBuildingTextBox";
            AddressBuildingTextBox.Size = new Size(175, 35);
            AddressBuildingTextBox.TabIndex = 11;
            AddressBuildingTextBox.TextChanged += AddressBuildingTextBox_TextChanged;
            // 
            // AddressCityTextBox
            // 
            AddressCityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressCityTextBox.BorderStyle = BorderStyle.FixedSingle;
            AddressCityTextBox.Location = new Point(509, 96);
            AddressCityTextBox.Name = "AddressCityTextBox";
            AddressCityTextBox.Size = new Size(237, 35);
            AddressCityTextBox.TabIndex = 10;
            AddressCityTextBox.TextChanged += AddressCityTextBox_TextChanged;
            // 
            // AddressStreetTextBox
            // 
            AddressStreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressStreetTextBox.BorderStyle = BorderStyle.FixedSingle;
            AddressStreetTextBox.Location = new Point(120, 147);
            AddressStreetTextBox.Name = "AddressStreetTextBox";
            AddressStreetTextBox.Size = new Size(626, 35);
            AddressStreetTextBox.TabIndex = 9;
            AddressStreetTextBox.TextChanged += AddressStreetTextBox_TextChanged;
            // 
            // AddressCountryTextBox
            // 
            AddressCountryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressCountryTextBox.BorderStyle = BorderStyle.FixedSingle;
            AddressCountryTextBox.Location = new Point(118, 96);
            AddressCountryTextBox.Name = "AddressCountryTextBox";
            AddressCountryTextBox.Size = new Size(284, 35);
            AddressCountryTextBox.TabIndex = 8;
            AddressCountryTextBox.TextChanged += AddressCountryTextBox_TextChanged;
            // 
            // AddressIndexTextBox
            // 
            AddressIndexTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressIndexTextBox.BorderStyle = BorderStyle.FixedSingle;
            AddressIndexTextBox.Location = new Point(120, 45);
            AddressIndexTextBox.Name = "AddressIndexTextBox";
            AddressIndexTextBox.Size = new Size(213, 35);
            AddressIndexTextBox.TabIndex = 7;
            AddressIndexTextBox.TextChanged += AddressIndexTextBoxes_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(325, 200);
            label7.Name = "label7";
            label7.Size = new Size(117, 30);
            label7.TabIndex = 6;
            label7.Text = "Apartment:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 200);
            label6.Name = "label6";
            label6.Size = new Size(93, 30);
            label6.TabIndex = 5;
            label6.Text = "Building:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 149);
            label5.Name = "label5";
            label5.Size = new Size(71, 30);
            label5.TabIndex = 4;
            label5.Text = "Street:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 98);
            label4.Name = "label4";
            label4.Size = new Size(53, 30);
            label4.TabIndex = 3;
            label4.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 98);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 2;
            label3.Text = "Country:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 47);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 1;
            label2.Text = "Post Index:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 0;
            label1.Text = "Delivery Address:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddressControl";
            Size = new Size(765, 289);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox AddressApartmentTextBox;
        private TextBox AddressBuildingTextBox;
        private TextBox AddressCityTextBox;
        private TextBox AddressStreetTextBox;
        private TextBox AddressCountryTextBox;
        private TextBox AddressIndexTextBox;
    }
}
