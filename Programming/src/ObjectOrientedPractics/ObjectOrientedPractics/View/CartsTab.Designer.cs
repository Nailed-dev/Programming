namespace ObjectOrientedPractics.View
{
    partial class CartsTab
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            AddToCartButton = new Button();
            ItemsListBox = new ListBox();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            CreateOrderButton = new Button();
            ClearCartButton = new Button();
            RemoveItemButton = new Button();
            AmountLabel = new Label();
            label4 = new Label();
            CartListBox = new ListBox();
            label3 = new Label();
            CustomersComboBox = new ComboBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1300, 1100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 1094);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(AddToCartButton, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 986);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(508, 105);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // AddToCartButton
            // 
            AddToCartButton.BackColor = SystemColors.Control;
            AddToCartButton.Dock = DockStyle.Fill;
            AddToCartButton.Location = new Point(3, 3);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(163, 99);
            AddToCartButton.TabIndex = 0;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = false;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.BorderStyle = BorderStyle.FixedSingle;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.IntegralHeight = false;
            ItemsListBox.ItemHeight = 30;
            ItemsListBox.Location = new Point(3, 39);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(508, 934);
            ItemsListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(AmountLabel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(CartListBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(CustomersComboBox);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(523, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 1094);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(CreateOrderButton, 0, 0);
            tableLayoutPanel3.Controls.Add(ClearCartButton, 3, 0);
            tableLayoutPanel3.Controls.Add(RemoveItemButton, 2, 0);
            tableLayoutPanel3.Location = new Point(3, 465);
            tableLayoutPanel3.MaximumSize = new Size(1000, 100);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(756, 99);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.BackColor = SystemColors.Control;
            CreateOrderButton.Dock = DockStyle.Fill;
            CreateOrderButton.Location = new Point(3, 3);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(183, 93);
            CreateOrderButton.TabIndex = 0;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = false;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.BackColor = SystemColors.Control;
            ClearCartButton.Dock = DockStyle.Fill;
            ClearCartButton.Location = new Point(570, 3);
            ClearCartButton.MaximumSize = new Size(1000, 1000);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(183, 93);
            ClearCartButton.TabIndex = 2;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = false;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.BackColor = SystemColors.Control;
            RemoveItemButton.Dock = DockStyle.Fill;
            RemoveItemButton.Location = new Point(381, 3);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(183, 93);
            RemoveItemButton.TabIndex = 1;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = false;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(558, 405);
            AmountLabel.MaximumSize = new Size(1000, 1000);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(201, 57);
            AmountLabel.TabIndex = 5;
            AmountLabel.Text = "4 990,90";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(655, 375);
            label4.Name = "label4";
            label4.Size = new Size(104, 30);
            label4.TabIndex = 4;
            label4.Text = "Amount:";
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.BorderStyle = BorderStyle.FixedSingle;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 30;
            CartListBox.Location = new Point(3, 158);
            CartListBox.MaximumSize = new Size(1000, 800);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(756, 212);
            CartListBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 125);
            label3.Name = "label3";
            label3.Size = new Size(56, 30);
            label3.TabIndex = 2;
            label3.Text = "Cart:";
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(139, 36);
            CustomersComboBox.MaximumSize = new Size(1000, 0);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(620, 38);
            CustomersComboBox.TabIndex = 1;
            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 39);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 0;
            label2.Text = "Customer:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CartsTab";
            Size = new Size(1300, 1100);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ListBox ItemsListBox;
        private TableLayoutPanel tableLayoutPanel2;
        private ListBox CartListBox;
        private Label label3;
        private ComboBox CustomersComboBox;
        private Label label2;
        private Label AmountLabel;
        private Label label4;
        private Button AddToCartButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button CreateOrderButton;
        private Button ClearCartButton;
        private Button RemoveItemButton;
    }
}
