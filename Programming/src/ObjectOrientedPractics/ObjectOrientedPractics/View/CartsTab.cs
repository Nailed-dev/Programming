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
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View
{
    public partial class CartsTab : UserControl
    {
        private Customer _currentCustomer;

        private List<Item> _items = new();

        private List<Customer> _customers = new();
        public CartsTab()
        {
            InitializeComponent();
        }


        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
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
            }
        }
        private void UpdateItemsListBox(int index)
        {
            var items = Items;
            ItemsListBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.Name != "")
                {
                    ItemsListBox.Items.Add(item);
                }
                else
                {
                    ItemsListBox.Items.Add($"Item {item.Id}");
                }
            }
            if (-1 <= index && index < ItemsListBox.Items.Count)
            {
                ItemsListBox.SelectedIndex = index;
            }

        }

        private void UpdateCartListBox(int index)
        {
            CartListBox.Items.Clear();

            if (CustomersComboBox.SelectedIndex == -1) return;

            _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
            var items = _currentCustomer.Cart.Items;

            if (Items == null) return;

            foreach (var item in items)
            {
                if (item.Name != "")
                {
                    CartListBox.Items.Add(item.Name);
                }
                else
                {
                    CartListBox.Items.Add($"Item {item.Id}");
                }
            }
            if (-1 <= index && index < CustomersComboBox.Items.Count)
            {
                CustomersComboBox.SelectedIndex = index;
            }
            UpdateAmountLabel();
        }

        private void UpdateAmountLabel()
        {
            if (_currentCustomer == null) AmountLabel.Text = "0.00";
            else AmountLabel.Text = _currentCustomer.Cart.Amount.ToString("f");
        }

        private void UpdateComboBox(int index)
        {
            var customers = Customers;

            CustomersComboBox.Items.Clear();

            foreach (var customer in customers)
            {
                if (customer.Fullname != "")
                {
                    CustomersComboBox.Items.Add(customer.Fullname);
                }
                else
                {
                    CustomersComboBox.Items.Add($"Customer {customer.Id}");
                }
            }

            if (-1 <= index && index < CustomersComboBox.Items.Count)
            {
                CustomersComboBox.SelectedIndex = index;
            }
        }

        public void RefreshData()
        {
            _currentCustomer = null;
            UpdateItemsListBox(-1);
            UpdateComboBox(-1);
            UpdateCartListBox(-1);
            UpdateAmountLabel();
        }
        
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCartListBox(CustomersComboBox.SelectedIndex);

            if (CustomersComboBox.SelectedIndex == -1) return;

            _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
            
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || _currentCustomer == null) return;

            _currentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
            UpdateCartListBox(CustomersComboBox.SelectedIndex);

        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1 || _currentCustomer == null) return;

            _currentCustomer.Cart.Items.Remove(_currentCustomer.Cart.Items[CartListBox.SelectedIndex]);
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
        }
        private void ClearCartButton_Click(Object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            _currentCustomer.Orders.Add(new Order(IdGenerator.GetNextId(), OrderStatus.New, DateTime.Now, _currentCustomer.Address, _currentCustomer.Cart));
        }

    }
}
