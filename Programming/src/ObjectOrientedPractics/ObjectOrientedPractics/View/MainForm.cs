using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;


namespace ObjectOrientedPractics

{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var customer = new Customer();
            customer.Fullname = "Brandon Vicle Jhon";
            
            MessageBox.Show(customer.Id.ToString());
            





        }
    }
}
