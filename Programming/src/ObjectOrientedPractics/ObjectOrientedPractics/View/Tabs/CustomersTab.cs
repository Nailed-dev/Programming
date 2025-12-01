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
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список всех пользователей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Выбранный пользователь.
        /// </summary>
        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
            AddressControl.Address = new Address();
        }

        /// <summary>
        /// Очистка тексбоксов.
        /// </summary>
        private void ClearTextBoxes()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            
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
            _currentCustomer = new Customer("Empy user", new Address());
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.Fullname);
            CustomersListBox.SelectedIndex = _customers.Count - 1;
            UpdateTextBoxes(_currentCustomer);
        }

        /// <summary>
        /// Удаление пользователя.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0) return;
            int index = CustomersListBox.SelectedIndex;
            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            if (CustomersListBox.Items.Count > index)
                CustomersListBox.SelectedIndex = index;
            else if (CustomersListBox.Items.Count != 0)
                CustomersListBox.SelectedIndex = 0;
            else
                CustomersListBox.SelectedIndex = -1;

            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
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
            if (_customers.Count == 0) return;

            try
            {
                FullNameTextBox.BackColor = Colors.NormalColor;
                _currentCustomer.Fullname = FullNameTextBox.Text;
                CustomersListBox.Items[_customers.IndexOf(_currentCustomer)] = _currentCustomer.Fullname;
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
            int index = CustomersListBox.SelectedIndex;
            if (index == -1) return;
            _currentCustomer = _customers[index];
            UpdateTextBoxes(_currentCustomer);
        }
        /// <summary>
        /// Возвращает и задает коллекцию покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }
    }
}
