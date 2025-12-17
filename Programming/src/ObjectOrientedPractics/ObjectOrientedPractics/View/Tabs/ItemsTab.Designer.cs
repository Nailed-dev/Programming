namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            OrderByComboBox = new ComboBox();
            label9 = new Label();
            FindTextBox = new TextBox();
            label8 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            AddButton = new Button();
            RemoveButton = new Button();
            ItemsListBox = new ListBox();
            label1 = new Label();
            panel2 = new Panel();
            ItemCategoryComboBox = new ComboBox();
            label7 = new Label();
            DescriptionTextBox = new TextBox();
            label6 = new Label();
            NameTextBox = new TextBox();
            label5 = new Label();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(OrderByComboBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(FindTextBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 1167);
            panel1.TabIndex = 0;
            // 
            // OrderByComboBox
            // 
            OrderByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OrderByComboBox.FormattingEnabled = true;
            OrderByComboBox.Location = new Point(137, 1001);
            OrderByComboBox.Name = "OrderByComboBox";
            OrderByComboBox.Size = new Size(416, 40);
            OrderByComboBox.TabIndex = 6;
            OrderByComboBox.SelectedIndexChanged += OrderByComboBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 1004);
            label9.Name = "label9";
            label9.Size = new Size(113, 32);
            label9.TabIndex = 5;
            label9.Text = "Order by:";
            // 
            // FindTextBox
            // 
            FindTextBox.BorderStyle = BorderStyle.FixedSingle;
            FindTextBox.Location = new Point(96, 45);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(457, 39);
            FindTextBox.TabIndex = 4;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 48);
            label8.Name = "label8";
            label8.Size = new Size(65, 32);
            label8.TabIndex = 3;
            label8.Text = "Find:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 1052);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(550, 112);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.Control;
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(177, 106);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = SystemColors.Control;
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(186, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(177, 106);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click_1;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.BorderStyle = BorderStyle.FixedSingle;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.IntegralHeight = false;
            ItemsListBox.Location = new Point(3, 97);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(550, 890);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
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
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ItemCategoryComboBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(DescriptionTextBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(CostTextBox);
            panel2.Controls.Add(IdTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(566, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 1167);
            panel2.TabIndex = 1;
            // 
            // ItemCategoryComboBox
            // 
            ItemCategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemCategoryComboBox.BackColor = Color.White;
            ItemCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemCategoryComboBox.FormattingEnabled = true;
            ItemCategoryComboBox.Location = new Point(142, 208);
            ItemCategoryComboBox.MaximumSize = new Size(650, 0);
            ItemCategoryComboBox.Name = "ItemCategoryComboBox";
            ItemCategoryComboBox.Size = new Size(236, 40);
            ItemCategoryComboBox.TabIndex = 10;
            ItemCategoryComboBox.SelectedIndexChanged += ItemCategoryComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 211);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 9;
            label7.Text = "Category:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTextBox.Location = new Point(3, 668);
            DescriptionTextBox.MaximumSize = new Size(1192, 1280);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(832, 235);
            DescriptionTextBox.TabIndex = 8;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 633);
            label6.Name = "label6";
            label6.Size = new Size(135, 32);
            label6.TabIndex = 7;
            label6.Text = "Description";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Location = new Point(3, 340);
            NameTextBox.MaximumSize = new Size(1192, 1280);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(832, 287);
            NameTextBox.TabIndex = 6;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 305);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 5;
            label5.Text = "Name:";
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.BorderStyle = BorderStyle.FixedSingle;
            CostTextBox.Location = new Point(142, 145);
            CostTextBox.MaximumSize = new Size(650, 600);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(236, 39);
            CostTextBox.TabIndex = 4;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.BackColor = SystemColors.Control;
            IdTextBox.BorderStyle = BorderStyle.FixedSingle;
            IdTextBox.Location = new Point(142, 79);
            IdTextBox.MaximumSize = new Size(542, 500);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(236, 39);
            IdTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 147);
            label4.Name = "label4";
            label4.Size = new Size(66, 32);
            label4.TabIndex = 2;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 81);
            label3.Name = "label3";
            label3.Size = new Size(42, 32);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 0;
            label2.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ItemsTab";
            Size = new Size(1408, 1173);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button AddButton;
        private Button RemoveButton;
        private ListBox ItemsListBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private TextBox DescriptionTextBox;
        private Label label6;
        private TextBox NameTextBox;
        private Label label5;
        private ComboBox ItemCategoryComboBox;
        private Label label7;
        private ComboBox OrderByComboBox;
        private Label label9;
        private TextBox FindTextBox;
        private Label label8;
    }
}
