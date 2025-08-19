using System.Collections.Generic;
using IN451_Unit3_Justin_Meyer.Data;

namespace IN451_Unit3_Justin_Meyer.Business
{
    public class CustomerService
    {
        private readonly NorthwindRepository _repo;

        public CustomerService(string connectionString)
        {
            _repo = new NorthwindRepository(connectionString);
        }

        public CustomerService(string server, string database, string user, string password)
        {
            string cs = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};Integrated Security=False;Encrypt=True;TrustServerCertificate=True";
            _repo = new NorthwindRepository(cs);
        }

        public bool TestConnection(out string error) => _repo.TestConnection(out error);

        public int GetCustomerCount() => _repo.GetCustomerCount();
        public List<string> GetCustomerNames() => _repo.GetCustomerNames();
        public List<string> GetCustomerLastNames() => _repo.GetCustomerLastNames();

        public int GetEmployeeCount() => _repo.GetEmployeeCount();
        public List<string> GetEmployeeNames() => _repo.GetEmployeeNames();
        public List<string> GetEmployeeLastNames() => _repo.GetEmployeeLastNames();

        public int GetOrderCount() => _repo.GetOrderCount();
        public List<string> GetOrderList() => _repo.GetOrderList();
    }
}
