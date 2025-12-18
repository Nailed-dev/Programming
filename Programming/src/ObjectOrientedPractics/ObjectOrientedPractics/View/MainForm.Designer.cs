namespace ObjectOrientedPractics
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTabControl = new TabControl();
            ItemsPage = new TabPage();
            ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            CustomersPage = new TabPage();
            CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            CartPage = new TabPage();
            CartsTab = new ObjectOrientedPractics.View.CartsTab();
            OrdersPage = new TabPage();
            OrdersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            PriorityOrders = new TabPage();
            PriorityOrdersTab = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            MainTabControl.SuspendLayout();
            ItemsPage.SuspendLayout();
            CustomersPage.SuspendLayout();
            CartPage.SuspendLayout();
            OrdersPage.SuspendLayout();
            PriorityOrders.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsPage);
            MainTabControl.Controls.Add(CustomersPage);
            MainTabControl.Controls.Add(CartPage);
            MainTabControl.Controls.Add(OrdersPage);
            MainTabControl.Controls.Add(PriorityOrders);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1461, 1225);
            MainTabControl.TabIndex = 0;
            MainTabControl.SelectedIndexChanged += ItemsTab_ItemsChanged;
            // 
            // ItemsPage
            // 
            ItemsPage.Controls.Add(ItemsTab);
            ItemsPage.Location = new Point(8, 46);
            ItemsPage.Name = "ItemsPage";
            ItemsPage.Padding = new Padding(3);
            ItemsPage.Size = new Size(1445, 1171);
            ItemsPage.TabIndex = 0;
            ItemsPage.Text = "Items";
            ItemsPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Items = null;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(1439, 1165);
            ItemsTab.TabIndex = 0;
            // 
            // CustomersPage
            // 
            CustomersPage.Controls.Add(CustomersTab);
            CustomersPage.Location = new Point(8, 46);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(3);
            CustomersPage.Size = new Size(1445, 1171);
            CustomersPage.TabIndex = 1;
            CustomersPage.Text = "Customers";
            CustomersPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Customers = null;
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(1439, 1165);
            CustomersTab.TabIndex = 0;
            // 
            // CartPage
            // 
            CartPage.Controls.Add(CartsTab);
            CartPage.Location = new Point(8, 46);
            CartPage.Name = "CartPage";
            CartPage.Padding = new Padding(3);
            CartPage.Size = new Size(1445, 1171);
            CartPage.TabIndex = 2;
            CartPage.Text = "Cart";
            CartPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Location = new Point(3, 3);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(1439, 1165);
            CartsTab.TabIndex = 0;
            // 
            // OrdersPage
            // 
            OrdersPage.Controls.Add(OrdersTab);
            OrdersPage.Location = new Point(8, 46);
            OrdersPage.Name = "OrdersPage";
            OrdersPage.Padding = new Padding(3);
            OrdersPage.Size = new Size(1445, 1171);
            OrdersPage.TabIndex = 3;
            OrdersPage.Text = "Orders";
            OrdersPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Customers = null;
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(3, 3);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(1439, 1165);
            OrdersTab.TabIndex = 0;
            // 
            // PriorityOrders
            // 
            PriorityOrders.Controls.Add(PriorityOrdersTab);
            PriorityOrders.Location = new Point(8, 46);
            PriorityOrders.Name = "PriorityOrders";
            PriorityOrders.Padding = new Padding(3);
            PriorityOrders.Size = new Size(1445, 1171);
            PriorityOrders.TabIndex = 4;
            PriorityOrders.Text = "Priority Orders";
            PriorityOrders.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTab
            // 
            PriorityOrdersTab.Dock = DockStyle.Fill;
            PriorityOrdersTab.Location = new Point(3, 3);
            PriorityOrdersTab.Name = "PriorityOrdersTab";
            PriorityOrdersTab.Size = new Size(1439, 1165);
            PriorityOrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 1225);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            Text = "Form1";
            MainTabControl.ResumeLayout(false);
            ItemsPage.ResumeLayout(false);
            CustomersPage.ResumeLayout(false);
            CartPage.ResumeLayout(false);
            OrdersPage.ResumeLayout(false);
            PriorityOrders.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ItemsPage;
        private View.Tabs.ItemsTab ItemsTab;
        private TabPage CustomersPage;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage CartPage;
        private View.CartsTab CartsTab;
        private TabPage OrdersPage;
        private View.Tabs.OrdersTab OrdersTab;
        private TabPage PriorityOrders;
        private View.Tabs.PriorityOrdersTab PriorityOrdersTab;
    }
}