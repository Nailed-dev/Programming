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
            AmountTextLabel = new Label();
            AmountLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            CreateOrderButton = new Button();
            ClearCartButton = new Button();
            RemoveItemButton = new Button();
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
            tableLayoutPanel1.Size = new Size(1408, 1173);
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
            panel1.Size = new Size(557, 1167);
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
            tableLayoutPanel2.Location = new Point(3, 1052);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(550, 112);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // AddToCartButton
            // 
            AddToCartButton.BackColor = SystemColors.Control;
            AddToCartButton.Dock = DockStyle.Fill;
            AddToCartButton.Location = new Point(3, 3);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(177, 106);
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
            ItemsListBox.Location = new Point(3, 42);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(550, 996);
            ItemsListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // panel2
            // 
            panel2.Controls.Add(AmountTextLabel);
            panel2.Controls.Add(AmountLabel);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(CartListBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(CustomersComboBox);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(566, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 1167);
            panel2.TabIndex = 1;
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AmountTextLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AmountTextLabel.Location = new Point(3, 398);
            AmountTextLabel.Margin = new Padding(6, 0, 6, 0);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(819, 32);
            AmountTextLabel.TabIndex = 14;
            AmountTextLabel.Text = "Amount:";
            AmountTextLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AmountLabel.Location = new Point(6, 435);
            AmountLabel.Margin = new Padding(6, 0, 6, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.RightToLeft = RightToLeft.No;
            AmountLabel.Size = new Size(816, 75);
            AmountLabel.TabIndex = 13;
            AmountLabel.Text = "0,00";
            AmountLabel.TextAlign = ContentAlignment.MiddleRight;
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
            tableLayoutPanel3.Location = new Point(3, 511);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(819, 106);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.BackColor = SystemColors.Control;
            CreateOrderButton.Dock = DockStyle.Fill;
            CreateOrderButton.Location = new Point(3, 3);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(198, 100);
            CreateOrderButton.TabIndex = 0;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = false;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.BackColor = SystemColors.Control;
            ClearCartButton.Dock = DockStyle.Fill;
            ClearCartButton.Location = new Point(615, 3);
            ClearCartButton.MaximumSize = new Size(1083, 1067);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(201, 100);
            ClearCartButton.TabIndex = 2;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = false;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.BackColor = SystemColors.Control;
            RemoveItemButton.Dock = DockStyle.Fill;
            RemoveItemButton.Location = new Point(411, 3);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(198, 100);
            RemoveItemButton.TabIndex = 1;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = false;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.BorderStyle = BorderStyle.FixedSingle;
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(3, 169);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(819, 226);
            CartListBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 133);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 2;
            label3.Text = "Cart:";
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(151, 38);
            CustomersComboBox.MaximumSize = new Size(1083, 0);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(671, 40);
            CustomersComboBox.TabIndex = 1;
            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 0;
            label2.Text = "Customer:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CartsTab";
            Size = new Size(1408, 1173);
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
        private Button AddToCartButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button CreateOrderButton;
        private Button ClearCartButton;
        private Button RemoveItemButton;
        private Label AmountTextLabel;
        private Label AmountLabel;
    }
}
