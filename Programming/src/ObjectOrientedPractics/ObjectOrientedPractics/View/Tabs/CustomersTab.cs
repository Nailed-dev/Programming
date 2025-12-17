using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ObjectOrientedPractics.View.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        

        /// <summary>
        /// Выбранный пользователь.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            AddressControl.Address = new Address();
            IsPriorityCheckBox.Enabled = false;

        }

        /// <summary>
        /// Очистка тексбоксов.
        /// </summary>
        private void ClearTextBoxes()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            IsPriorityCheckBox.Checked = false;
            IdTextBox.BackColor = Colors.NormalColor;
            FullNameTextBox.BackColor = Colors.NormalColor;
            AddressControl.Address = new Address();

        }

        /// <summary>
        /// Обновление текстбоксов в зависимости от выбранного пользователя.
        /// </summary>
        /// <param name="customer">Пользователь</param>
        private void UpdateTextBoxes(Customer customer)
        {
            IdTextBox.Text = customer.Id.ToString();
            FullNameTextBox.Text = customer.Fullname;
            AddressControl.Address = customer.Address;

        }

        /// <summary>
        /// Добавление нового пользователя.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("Empy user", new Address(), new Cart(),false);
            Customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.Fullname);
            CustomersListBox.SelectedIndex = Customers.Count - 1;
            UpdateTextBoxes(_currentCustomer);
            
            UpdateDiscountsListBox();
        }

        /// <summary>
        /// Удаление пользователя.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0) return;
            int index = CustomersListBox.SelectedIndex;
            Customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            if (CustomersListBox.Items.Count > index)
                CustomersListBox.SelectedIndex = index;
            else if (CustomersListBox.Items.Count != 0)
                CustomersListBox.SelectedIndex = 0;
            else
                CustomersListBox.SelectedIndex = -1;

            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[CustomersListBox.SelectedIndex];
                UpdateTextBoxes(_currentCustomer);
            }
            else
            {
                ClearTextBoxes();
            }
        }

        

        /// <summary>
        /// Обновляет данные в списке CustomersListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Customer> customers = Customers;

            CustomersListBox.Items.Clear();

            foreach (var customer in customers)
            {
                if (customer.Fullname != "")
                {
                    CustomersListBox.Items.Add(customer.Fullname);
                }
                else
                {
                    CustomersListBox.Items.Add($"Customer {customer.Id}");
                }
            }

            if (-1 <= index && index < CustomersListBox.Items.Count)
            {
                CustomersListBox.SelectedIndex = index;
            }
        }


        /// <summary>
        /// Изменение имени пользователя, когда изменяется имя в FullNameTextBox.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Customers.Count == 0) return;

            try
            {
                FullNameTextBox.BackColor = Colors.NormalColor;
                _currentCustomer.Fullname = FullNameTextBox.Text;
                CustomersListBox.Items[Customers.IndexOf(_currentCustomer)] = _currentCustomer.Fullname;
            }
            catch
            {

                FullNameTextBox.BackColor = Colors.ErrorColor;
            }
        }
        
        
        

        /// <summary>
        /// Обновление данных при выборе пользователя в CustomersListBox.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                IsPriorityCheckBox.Enabled = false;
                return;
            }
            IsPriorityCheckBox.Enabled = true;

           
            _currentCustomer = Customers[CustomersListBox.SelectedIndex];
            IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
            IdTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.Fullname;
            AddressControl.Address = _currentCustomer.Address;
            UpdateDiscountsListBox();
        }
        /// <summary>
        /// Возвращает и задает коллекцию покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
        }

        private void UpdateDiscountsListBox()
        {
            DiscountsListBox.Items.Clear();
            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscountForm addDiscountForm = new AddDiscountForm();
            if (addDiscountForm.ShowDialog() == DialogResult.OK)
            {
                foreach (var discount in _currentCustomer.Discounts)
                {
                    if (discount is PointsDiscount) continue;
                    if (((PercentDiscount)discount).Category ==
                        addDiscountForm.PercentDiscount.Category) return;
                }
                _currentCustomer.Discounts.Add(addDiscountForm.PercentDiscount);
                UpdateDiscountsListBox();
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            int index = DiscountsListBox.SelectedIndex;
            if (index == -1) return;
            if (index == 0) return;
            _currentCustomer.Discounts.RemoveAt(index);
            UpdateDiscountsListBox();
        }
        
    }


}
