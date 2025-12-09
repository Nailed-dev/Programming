namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            CategoryComboBox = new ComboBox();
            OKButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 0;
            label1.Text = "Percent Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DrawMode = DrawMode.Normal;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(159, 73);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(519, 40);
            CategoryComboBox.TabIndex = 2;
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK; 
            OKButton.Location = new Point(224, 192);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(183, 78);
            OKButton.TabIndex = 3;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel; 
            CancelButton.Location = new Point(444, 192);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(183, 78);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddDiscountForm
            // 
            AcceptButton = OKButton; 
            CancelButton = CancelButton; 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 335);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddDiscountForm";
            Text = "AddDiscountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox CategoryComboBox;
        private Button OKButton;
        private Button CancelButton;
    }
}