namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            tableLayoutPanel3 = new TableLayoutPanel();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ClearOrderButton = new Button();
            DeliveryTimeSelectedOrderComboBox = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            SelectedOrderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            AmountSelectedOrderLabel = new Label();
            AmountTextLabel = new Label();
            OrderItemsListBox = new ListBox();
            StatusSelectedOrderComboBox = new ComboBox();
            CreatedSelectedOrderTextBox = new TextBox();
            IDSelectedOrderTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(DeliveryTimeSelectedOrderComboBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SelectedOrderAddressControl);
            panel1.Controls.Add(AmountSelectedOrderLabel);
            panel1.Controls.Add(AmountTextLabel);
            panel1.Controls.Add(OrderItemsListBox);
            panel1.Controls.Add(StatusSelectedOrderComboBox);
            panel1.Controls.Add(CreatedSelectedOrderTextBox);
            panel1.Controls.Add(IDSelectedOrderTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 1100);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(RemoveItemButton, 1, 0);
            tableLayoutPanel3.Controls.Add(AddItemButton, 0, 0);
            tableLayoutPanel3.Controls.Add(ClearOrderButton, 3, 0);
            tableLayoutPanel3.Location = new Point(3, 980);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1194, 117);
            tableLayoutPanel3.TabIndex = 29;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.BackColor = SystemColors.Control;
            RemoveItemButton.Dock = DockStyle.Fill;
            RemoveItemButton.Location = new Point(301, 3);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(292, 111);
            RemoveItemButton.TabIndex = 3;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = false;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.BackColor = SystemColors.Control;
            AddItemButton.Dock = DockStyle.Fill;
            AddItemButton.Location = new Point(3, 3);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(292, 111);
            AddItemButton.TabIndex = 0;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = false;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.BackColor = SystemColors.Control;
            ClearOrderButton.Dock = DockStyle.Fill;
            ClearOrderButton.Location = new Point(897, 3);
            ClearOrderButton.MaximumSize = new Size(1083, 1067);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(294, 111);
            ClearOrderButton.TabIndex = 2;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = false;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // DeliveryTimeSelectedOrderComboBox
            // 
            DeliveryTimeSelectedOrderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeSelectedOrderComboBox.FormattingEnabled = true;
            DeliveryTimeSelectedOrderComboBox.Location = new Point(820, 50);
            DeliveryTimeSelectedOrderComboBox.MaximumSize = new Size(500, 0);
            DeliveryTimeSelectedOrderComboBox.Name = "DeliveryTimeSelectedOrderComboBox";
            DeliveryTimeSelectedOrderComboBox.Size = new Size(327, 40);
            DeliveryTimeSelectedOrderComboBox.TabIndex = 28;
            DeliveryTimeSelectedOrderComboBox.SelectedIndexChanged += DeliveryTimeSelectedOrderComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(628, 53);
            label6.Name = "label6";
            label6.Size = new Size(166, 32);
            label6.TabIndex = 27;
            label6.Text = "Delivery Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(628, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 26;
            label1.Text = "Priority Options";
            // 
            // SelectedOrderAddressControl
            // 
            SelectedOrderAddressControl.Location = new Point(3, 226);
            SelectedOrderAddressControl.Name = "SelectedOrderAddressControl";
            SelectedOrderAddressControl.ReadOnly = false;
            SelectedOrderAddressControl.Size = new Size(1194, 337);
            SelectedOrderAddressControl.TabIndex = 25;
            // 
            // AmountSelectedOrderLabel
            // 
            AmountSelectedOrderLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AmountSelectedOrderLabel.Location = new Point(0, 911);
            AmountSelectedOrderLabel.Margin = new Padding(6, 0, 6, 0);
            AmountSelectedOrderLabel.Name = "AmountSelectedOrderLabel";
            AmountSelectedOrderLabel.RightToLeft = RightToLeft.No;
            AmountSelectedOrderLabel.Size = new Size(1197, 75);
            AmountSelectedOrderLabel.TabIndex = 24;
            AmountSelectedOrderLabel.Text = "0,00";
            AmountSelectedOrderLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AmountTextLabel.Location = new Point(0, 875);
            AmountTextLabel.Margin = new Padding(6, 0, 6, 0);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(1197, 32);
            AmountTextLabel.TabIndex = 23;
            AmountTextLabel.Text = "Amount:";
            AmountTextLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.IntegralHeight = false;
            OrderItemsListBox.Location = new Point(3, 569);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(1194, 306);
            OrderItemsListBox.TabIndex = 22;
            // 
            // StatusSelectedOrderComboBox
            // 
            StatusSelectedOrderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusSelectedOrderComboBox.FormattingEnabled = true;
            StatusSelectedOrderComboBox.Location = new Point(136, 180);
            StatusSelectedOrderComboBox.MaximumSize = new Size(700, 0);
            StatusSelectedOrderComboBox.Name = "StatusSelectedOrderComboBox";
            StatusSelectedOrderComboBox.Size = new Size(353, 40);
            StatusSelectedOrderComboBox.TabIndex = 20;
            StatusSelectedOrderComboBox.SelectedIndexChanged += StatusSelectedOrderComboBox_SelectedIndexChanged;
            // 
            // CreatedSelectedOrderTextBox
            // 
            CreatedSelectedOrderTextBox.BorderStyle = BorderStyle.FixedSingle;
            CreatedSelectedOrderTextBox.Location = new Point(136, 116);
            CreatedSelectedOrderTextBox.MaximumSize = new Size(700, 0);
            CreatedSelectedOrderTextBox.Name = "CreatedSelectedOrderTextBox";
            CreatedSelectedOrderTextBox.ReadOnly = true;
            CreatedSelectedOrderTextBox.Size = new Size(353, 39);
            CreatedSelectedOrderTextBox.TabIndex = 19;
            // 
            // IDSelectedOrderTextBox
            // 
            IDSelectedOrderTextBox.BorderStyle = BorderStyle.FixedSingle;
            IDSelectedOrderTextBox.Location = new Point(136, 51);
            IDSelectedOrderTextBox.MaximumSize = new Size(700, 0);
            IDSelectedOrderTextBox.Name = "IDSelectedOrderTextBox";
            IDSelectedOrderTextBox.ReadOnly = true;
            IDSelectedOrderTextBox.Size = new Size(353, 39);
            IDSelectedOrderTextBox.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 183);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 17;
            label5.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 118);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 16;
            label4.Text = "Created:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 53);
            label3.Name = "label3";
            label3.Size = new Size(42, 32);
            label3.TabIndex = 15;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 14;
            label2.Text = "Selected Order";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PriorityOrdersTab";
            Size = new Size(1200, 1100);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label AmountSelectedOrderLabel;
        private Label AmountTextLabel;
        private ListBox OrderItemsListBox;
        private ComboBox StatusSelectedOrderComboBox;
        private TextBox CreatedSelectedOrderTextBox;
        private TextBox IDSelectedOrderTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Controls.AddressControl SelectedOrderAddressControl;
        private ComboBox DeliveryTimeSelectedOrderComboBox;
        private Label label6;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button AddItemButton;
        private Button ClearOrderButton;
        private Button RemoveItemButton;
    }
}
