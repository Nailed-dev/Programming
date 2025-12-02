using System.Security.Cryptography.X509Certificates;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.View;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.View.Controls;


namespace ObjectOrientedPractics

{
    public partial class MainForm : Form
    {
        private Store _store = new Store();


        /// <summary>
        /// Предоставляет реализацию расположения элементов на форме.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = Store.Items;
            CustomersTab.Customers = Store.Customers;
            CartsTab.Items = Store.Items;
            CartsTab.Customers = Store.Customers;
           
        }

        public Store Store
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
            }
        }

        private void SelectedTabChanged(object sender, EventArgs e)
        {
            CartsTab.RefreshData();

        }
    }
}
