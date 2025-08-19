using System;
using System.Windows.Forms;
using IN451_Unit3_Justin_Meyer.Business;

namespace IN451_Unit3_Justin_Meyer.UI
{
    public partial class Form1 : Form
    {
        private readonly CustomerService _service;

        public Form1(CustomerService service)
        {
            InitializeComponent();
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        private void btnLoadCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                lstCustomers.DataSource = _service.GetCustomerNames();
                lblCustomersCount.Text = $"Customers: {_service.GetCustomerCount()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
        }

        private void btnLoadCustomerLast_Click(object sender, EventArgs e)
        {
            try
            {
                lstCustomers.DataSource = _service.GetCustomerLastNames();
                lblCustomersCount.Text = $"Customers: {_service.GetCustomerCount()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
        }

        private void btnLoadEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                lstEmployees.DataSource = _service.GetEmployeeNames();
                lblEmployeesCount.Text = $"Employees: {_service.GetEmployeeCount()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}");
            }
        }

        private void btnLoadEmployeeLast_Click(object sender, EventArgs e)
        {
            try
            {
                lstEmployees.DataSource = _service.GetEmployeeLastNames();
                lblEmployeesCount.Text = $"Employees: {_service.GetEmployeeCount()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}");
            }
        }

        private void btnLoadOrders_Click(object sender, EventArgs e)
        {
            try
            {
                lstOrders.DataSource = _service.GetOrderList();
                lblOrdersCount.Text = $"Orders: {_service.GetOrderCount()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}");
            }
        }
    }
}
