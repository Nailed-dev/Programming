using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View;


namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        private bool _readOnly;

        internal Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                UpdateAddressTextBoxes(_address);
            }
        }

        public bool ReadOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
                _readOnly = value;

                if (value)
                {
                    AddressIndexTextBox.ReadOnly = true;
                    AddressCountryTextBox.ReadOnly = true;
                    AddressCityTextBox.ReadOnly = true;
                    AddressStreetTextBox.ReadOnly = true;
                    AddressBuildingTextBox.ReadOnly = true;
                    AddressApartmentTextBox.ReadOnly = true;
                }
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        public void UpdateAddressTextBoxes(Address address)
        {
            AddressIndexTextBox.Text = address.Index.ToString();
            AddressCountryTextBox.Text = address.Country;
            AddressCityTextBox.Text = address.City;
            AddressStreetTextBox.Text = address.Street;
            AddressBuildingTextBox.Text = address.Building;
            AddressApartmentTextBox.Text = address.Apartment;
        }

        private void AddressIndexTextBoxes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = int.Parse(AddressIndexTextBox.Text);
                AddressIndexTextBox.BackColor = Colors.NormalColor;
            }
            catch
            {
                AddressIndexTextBox.BackColor = Colors.ErrorColor;
            }

        }

        private void AddressCountryTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                _address.Country = AddressCountryTextBox.Text;
                AddressCountryTextBox.BackColor = Colors.NormalColor;

            }
            catch
            {
                AddressCountryTextBox.BackColor = Colors.ErrorColor;
            }
        }

        private void AddressCityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = AddressCityTextBox.Text;
                AddressCityTextBox.BackColor = Colors.NormalColor;
            }
            catch
            {
                AddressCityTextBox.BackColor = Colors.ErrorColor;
            }

        }

        private void AddressStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = AddressStreetTextBox.Text;
                AddressStreetTextBox.BackColor = Colors.NormalColor;
            }
            catch
            {
                AddressStreetTextBox.BackColor = Colors.ErrorColor;
            }
        }

        private void AddressBuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = AddressBuildingTextBox.Text;
                AddressBuildingTextBox.BackColor = Colors.NormalColor;

            }
            catch
            {
                AddressBuildingTextBox.BackColor = Colors.ErrorColor;
            }
        }

        private void AddressApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = AddressApartmentTextBox.Text;
                AddressApartmentTextBox.BackColor = Colors.NormalColor;
            }
            catch
            {
                AddressApartmentTextBox.BackColor = Colors.ErrorColor;
            }
        }
            
        
    }
}
