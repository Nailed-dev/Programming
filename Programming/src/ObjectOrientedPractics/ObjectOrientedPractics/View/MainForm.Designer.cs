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
            MainTabControl.SuspendLayout();
            ItemsPage.SuspendLayout();
            CustomersPage.SuspendLayout();
            CartPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsPage);
            MainTabControl.Controls.Add(CustomersPage);
            MainTabControl.Controls.Add(CartPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1349, 1148);
            MainTabControl.TabIndex = 0;
            // 
            // ItemsPage
            // 
            ItemsPage.Controls.Add(ItemsTab);
            ItemsPage.Location = new Point(4, 39);
            ItemsPage.Name = "ItemsPage";
            ItemsPage.Padding = new Padding(3);
            ItemsPage.Size = new Size(1341, 1105);
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
            ItemsTab.Size = new Size(1335, 1099);
            ItemsTab.TabIndex = 0;
            // 
            // CustomersPage
            // 
            CustomersPage.Controls.Add(CustomersTab);
            CustomersPage.Location = new Point(4, 39);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(3);
            CustomersPage.Size = new Size(1341, 1105);
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
            CustomersTab.Size = new Size(1335, 1099);
            CustomersTab.TabIndex = 0;
            // 
            // CartPage
            // 
            CartPage.Controls.Add(CartsTab);
            CartPage.Location = new Point(4, 39);
            CartPage.Name = "CartPage";
            CartPage.Padding = new Padding(3);
            CartPage.Size = new Size(1341, 1105);
            CartPage.TabIndex = 2;
            CartPage.Text = "Cart";
            CartPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Location = new Point(3, 3);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(1335, 1099);
            CartsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 1148);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            Text = "Form1";
            MainTabControl.ResumeLayout(false);
            ItemsPage.ResumeLayout(false);
            CustomersPage.ResumeLayout(false);
            CartPage.ResumeLayout(false);
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
    }
}