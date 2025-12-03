using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Order _currentOrder;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            _orders = new List<Order>();

            OrderAddressControl.ReadOnly = true;
            var orderStatuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var value in orderStatuses)
            {
                OrderStatusComboBox.Items.Add(value);
            }
            OrderStatusComboBox.Enabled = false;
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
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

        /// <summary>
        /// Обновляет информацию на вкладке <see cref="OrdersTab"/>.
        /// </summary>
        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            _orders = new List<Order>();
            UpdateOrders();
        }

        /// <summary>
        /// Обновляет информацию о заказах.
        /// </summary>
        private void UpdateOrders()
        {
            foreach (var customer in _customers)
            {
                Address address = customer.Address;
                string fullAddress = $"{address.Index}, {address.Country}, {address.City}," +
                                     $" {address.Street}, {address.Building}, {address.Apartment}";

                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    OrdersDataGridView.Rows.Add(order.Id.ToString(), order.Date.ToString(), order.OrderStatus,
                        customer.Fullname, fullAddress, order.Amount.ToString());
                }
            }
        }

        /// <summary>
        /// Устанавливает значения в элементы управления.
        /// </summary>
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