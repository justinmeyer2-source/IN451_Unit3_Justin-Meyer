using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace IN451_Unit3_Justin_Meyer.Data
{
    public class NorthwindRepository
    {
        private readonly string _connectionString;

        public NorthwindRepository(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public bool TestConnection(out string error)
        {
            error = string.Empty;
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("SELECT 1", conn))
                {
                    conn.Open();
                    cmd.ExecuteScalar();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public int GetCustomerCount()
        {
            const string sql = "SELECT COUNT(*) FROM dbo.Customers;";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public List<string> GetCustomerNames()
        {
            const string sql = "SELECT ContactName FROM dbo.Customers ORDER BY ContactName;";
            var results = new List<string>();
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var name = rdr.IsDBNull(0) ? string.Empty : rdr.GetString(0);
                        if (!string.IsNullOrWhiteSpace(name))
                            results.Add(name);
                    }
                }
            }
            return results;
        }

        public List<string> GetCustomerLastNames()
        {
            var lastNames = new List<string>();
            const string sql = "SELECT ContactName FROM dbo.Customers WHERE ContactName IS NOT NULL;";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var contact = rdr.GetString(0).Trim();
                        if (string.IsNullOrEmpty(contact)) continue;
                        var parts = contact.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var last = parts.Length > 1 ? parts[parts.Length - 1] : parts[0];
                        lastNames.Add(last);
                    }
                }
            }
            lastNames.Sort(StringComparer.CurrentCultureIgnoreCase);
            return lastNames;
        }

        public int GetEmployeeCount()
        {
            const string sql = "SELECT COUNT(*) FROM dbo.Employees;";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public List<string> GetEmployeeNames()
        {
            const string sql = "SELECT LastName, FirstName FROM dbo.Employees ORDER BY LastName, FirstName;";
            var list = new List<string>();
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var last = rdr.IsDBNull(0) ? "" : rdr.GetString(0);
                        var first = rdr.IsDBNull(1) ? "" : rdr.GetString(1);
                        var display = string.IsNullOrWhiteSpace(first) ? last : $"{last}, {first}";
                        if (!string.IsNullOrWhiteSpace(display))
                            list.Add(display);
                    }
                }
            }
            return list;
        }

        public List<string> GetEmployeeLastNames()
        {
            const string sql = "SELECT LastName FROM dbo.Employees WHERE LastName IS NOT NULL ORDER BY LastName;";
            var list = new List<string>();
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var last = rdr.IsDBNull(0) ? "" : rdr.GetString(0);
                        if (!string.IsNullOrWhiteSpace(last))
                            list.Add(last);
                    }
                }
            }
            return list;
        }

        public int GetOrderCount()
        {
            const string sql = "SELECT COUNT(*) FROM dbo.Orders;";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public List<string> GetOrderList()
        {
            const string sql = "SELECT OrderID, OrderDate FROM dbo.Orders ORDER BY OrderID;";
            var list = new List<string>();
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var id = rdr.GetInt32(0);
                        string date = rdr.IsDBNull(1) ? "" : rdr.GetDateTime(1).ToString("yyyy-MM-dd");
                        list.Add(string.IsNullOrEmpty(date) ? $"Order {id}" : $"Order {id} - {date}");
                    }
                }
            }
            return list;
        }
    }
}
