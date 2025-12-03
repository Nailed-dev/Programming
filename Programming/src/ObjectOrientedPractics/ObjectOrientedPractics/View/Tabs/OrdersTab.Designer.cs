namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            OrdersDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            CustomerFullName = new DataGridViewTextBoxColumn();
            DeliveryAddress = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel2 = new Panel();
            AmountLabel = new Label();
            label7 = new Label();
            OrderItemsListBox = new ListBox();
            label6 = new Label();
            OrderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            OrderStatusComboBox = new ComboBox();
            OrderDateTextBox = new TextBox();
            OrderIdTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cartBindingSource = new BindingSource(components);
            itemBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1733, 1280);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(OrdersDataGridView);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 1274);
            panel1.TabIndex = 0;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Created, OrderStatus, CustomerFullName, DeliveryAddress, Amount });
            OrdersDataGridView.Location = new Point(3, 53);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersWidth = 72;
            OrdersDataGridView.Size = new Size(857, 1217);
            OrdersDataGridView.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 9;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 175;
            // 
            // Created
            // 
            Created.HeaderText = "Created";
            Created.MinimumWidth = 9;
            Created.Name = "Created";
            Created.ReadOnly = true;
            Created.Width = 175;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.MinimumWidth = 9;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Width = 175;
            // 
            // CustomerFullName
            // 
            CustomerFullName.HeaderText = "Customer Full Name";
            CustomerFullName.MinimumWidth = 9;
            CustomerFullName.Name = "CustomerFullName";
            CustomerFullName.ReadOnly = true;
            CustomerFullName.Width = 175;
            // 
            // DeliveryAddress
            // 
            DeliveryAddress.HeaderText = "Delivery Address";
            DeliveryAddress.MinimumWidth = 9;
            DeliveryAddress.Name = "DeliveryAddress";
            DeliveryAddress.ReadOnly = true;
            DeliveryAddress.Width = 175;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 9;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 175;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(AmountLabel);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(OrderItemsListBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(OrderAddressControl);
            panel2.Controls.Add(OrderStatusComboBox);
            panel2.Controls.Add(OrderDateTextBox);
            panel2.Controls.Add(OrderIdTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(869, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(861, 1274);
            panel2.TabIndex = 1;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(612, 908);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(246, 65);
            AmountLabel.TabIndex = 11;
            AmountLabel.Text = "4, 990.90";
            AmountLabel.TabIndexChanged += OrdersDataGridView_SelectionChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(731, 876);
            label7.Name = "label7";
            label7.Size = new Size(118, 32);
            label7.TabIndex = 10;
            label7.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.IntegralHeight = false;
            OrderItemsListBox.Location = new Point(20, 566);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(824, 306);
            OrderItemsListBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(20, 531);
            label6.Name = "label6";
            label6.Size = new Size(153, 32);
            label6.TabIndex = 8;
            label6.Text = "Order Items";
            // 
            // OrderAddressControl
            // 
            OrderAddressControl.Location = new Point(20, 254);
            OrderAddressControl.Name = "OrderAddressControl";
            OrderAddressControl.Size = new Size(837, 309);
            OrderAddressControl.TabIndex = 7;
            // 
            // OrderStatusComboBox
            // 
            OrderStatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderStatusComboBox.FormattingEnabled = true;
            OrderStatusComboBox.Location = new Point(156, 180);
            OrderStatusComboBox.Name = "OrderStatusComboBox";
            OrderStatusComboBox.Size = new Size(299, 40);
            OrderStatusComboBox.TabIndex = 6;
            OrderStatusComboBox.SelectedIndexChanged += OrderStatusComboBox_SelectedIndexChanged;
            // 
            // OrderDateTextBox
            // 
            OrderDateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderDateTextBox.BorderStyle = BorderStyle.FixedSingle;
            OrderDateTextBox.Location = new Point(156, 116);
            OrderDateTextBox.Name = "OrderDateTextBox";
            OrderDateTextBox.ReadOnly = true;
            OrderDateTextBox.Size = new Size(299, 39);
            OrderDateTextBox.TabIndex = 5;
            // 
            // OrderIdTextBox
            // 
            OrderIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            OrderIdTextBox.Location = new Point(156, 51);
            OrderIdTextBox.Name = "OrderIdTextBox";
            OrderIdTextBox.ReadOnly = true;
            OrderIdTextBox.Size = new Size(299, 39);
            OrderIdTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 183);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 3;
            label5.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 118);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 2;
            label4.Text = "Created:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 53);
            label3.Name = "label3";
            label3.Size = new Size(42, 32);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(20, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 0;
            label2.Text = "Selected Order";
            // 
            // cartBindingSource
            // 
            cartBindingSource.DataSource = typeof(Model.Cart);
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Model.Item);
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrdersTab";
            Size = new Size(1733, 1280);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cartBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView OrdersDataGridView;
        private BindingSource itemBindingSource;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private BindingSource cartBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn CustomerFullName;
        private DataGridViewTextBoxColumn DeliveryAddress;
        private DataGridViewTextBoxColumn Amount;
        private Label label3;
        private TextBox OrderIdTextBox;
        private Label label5;
        private Label label4;
        private ComboBox OrderStatusComboBox;
        private TextBox OrderDateTextBox;
        private Controls.AddressControl OrderAddressControl;
        private Label label7;
        private ListBox OrderItemsListBox;
        private Label label6;
        private Label AmountLabel;
    }
}
