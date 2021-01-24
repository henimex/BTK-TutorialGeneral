using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll() //List ile yapılan
        {
            string connectionString1 = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ETrade; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            //SqlConnection connection = new SqlConnection(@"Data Source=DELL-E5\SQLEXPRESS;Initial Catalog=Trade;Integrated Security=True");
            //Data Source=DELL-E5\SQLEXPRESS;Initial Catalog=Trade;Integrated Security=True
            //SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            //SqlConnection connection = new SqlConnection(@"server =ipadres;initial catalog=ETrade;integrated security=false;uid=Administrator;password=123456");
            //emin olmamakla birlikte uzak sunucuya baglanmak icin yazılacak olan kod budur.

            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);
            SqlDataReader reader = command.ExecuteReader();//sorgu sonucu tablo ise execute reader

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    Stock = Convert.ToInt32(reader["Stock"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Products values(@name,@unitPrice,@stock)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stock", product.Stock);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("UPDATE Products SET Name=@name, UnitPrice=@unitPrice, Stock=@stock WHERE Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stock", product.Stock);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("DELETE Products WHERE Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public DataTable GetAll2() //Data Table ile yapılan tavsiyeedilmiyor.
        {
            string connectionString1 = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ETrade; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
            //SqlConnection connection = new SqlConnection(@"Data Source=DELL-E5\SQLEXPRESS;Initial Catalog=Trade;Integrated Security=True");
            //Data Source=DELL-E5\SQLEXPRESS;Initial Catalog=Trade;Integrated Security=True
            //SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            //SqlConnection connection = new SqlConnection(@"server =ipadres;initial catalog=ETrade;integrated security=false;uid=Administrator;password=123456");
            //emin olmamakla birlikte uzak sunucuya baglanmak icin yazılacak olan kod budur.

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);
            SqlDataReader reader = command.ExecuteReader();//sorgu sonucu tablo ise execute reader
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
        }
    }
}
