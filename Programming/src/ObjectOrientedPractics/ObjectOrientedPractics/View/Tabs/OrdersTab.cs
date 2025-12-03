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
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View;
using ObjectOrientedPractics.Model.Enums;
using Accessibility;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {

        private List<Customer> _customers;

        private List<Order> _orders;

        private Order _currentOrder;


        public OrdersTab()
        {
            InitializeComponent();

            _orders = new List<Order>();

            OrderAddressControl.Enabled = false;
            var orderStatuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var value in orderStatuses)
            {
                OrderStatusComboBox.Items.Add(value);
            }
            OrderStatusComboBox.Enabled = false;
        }

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                if (_customers != null) UpdateOrders();
            }
        }

        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            _orders = new List<Order>();
            UpdateOrders();
        }

        private void UpdateOrders()
        {
            foreach (var customer in _customers)
            {
                Address address = customer.Address;
                string fullAddress = $"{address.Index}, {address.Country}, {address.City}," +
                    $"{address.Street}, {address.Building}, {address.Apartment}";
                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    OrdersDataGridView.Rows.Add(order.Id.ToString(), order.Date.ToString(), order.OrderStatus, customer.Fullname, fullAddress, order.Amount.ToString());
                }
            }


        }

        private void SetValueInTextBoxes()
        {
            OrderStatusComboBox.Enabled = true;
            OrderIdTextBox.Text = _currentOrder.Id.ToString();
            OrderDateTextBox.Text = _currentOrder.Date.ToString();
            OrderStatusComboBox.SelectedIndex = (int)_currentOrder.OrderStatus;
            OrderAddressControl.Address = _currentOrder.Address;
            AmountLabel.Text = _currentOrder.Amount.ToString();
            OrderItemsListBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;
            if (index == -1) return;

            _currentOrder = _orders[index];
            SetValueInTextBoxes();

        }

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;

            _currentOrder.OrderStatus = (OrderStatus)OrderStatusComboBox.SelectedIndex;
            OrdersDataGridView.Rows[index].Cells[2].Value = (OrderStatus)OrderStatusComboBox.SelectedIndex;
        }

    }
}
