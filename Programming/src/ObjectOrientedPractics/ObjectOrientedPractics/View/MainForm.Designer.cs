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
            CartsTab = new TabControl();
            tabPage1 = new TabPage();
            ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            tabPage2 = new TabPage();
            CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            tabPage3 = new TabPage();
            cartsTab1 = new ObjectOrientedPractics.View.CartsTab();
            CartsTab.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // CartsTab
            // 
            CartsTab.Controls.Add(tabPage1);
            CartsTab.Controls.Add(tabPage2);
            CartsTab.Controls.Add(tabPage3);
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Location = new Point(0, 0);
            CartsTab.Name = "CartsTab";
            CartsTab.SelectedIndex = 0;
            CartsTab.Size = new Size(1349, 1148);
            CartsTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ItemsTab);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1341, 1105);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(CustomersTab);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1341, 1105);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customer";
            tabPage2.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            tabPage3.Controls.Add(cartsTab1);
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1341, 1105);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cart";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(1335, 1099);
            cartsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 1148);
            Controls.Add(CartsTab);
            Name = "MainForm";
            Text = "Form1";
            CartsTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl CartsTab;
        private TabPage tabPage1;
        private View.Tabs.ItemsTab ItemsTab;
        private TabPage tabPage2;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage tabPage3;
        private View.CartsTab cartsTab1;
    }
}
