namespace WindowsFormsApplication1
{
    using System.Data;
    using System.Collections.Generic;
    using MySql.Data.MySqlClient;
    using System;
    static class Database
    {
        private const string ConnectionString = "Server=localhost;Database=test;Uid=root;Pwd=";

        public static Product GetProduct(string productName)
        {
            var command = new MySqlCommand("SELECT * FROM products WHERE Name = @name");
            command.Parameters.AddWithValue("name", productName);

            using (var reader = GetReader(command))
            {
                if (!reader.Read()) return null;

                var product = GetProductFromReader(reader);
                reader.Close();
                return product;
            }
        }
        public static void AddProduct(string productName, int quantity)
        {
            var product = GetProduct(productName);
            if (product != null)
            {
                var command = new MySqlCommand("UPDATE products SET quantity=@quantity WHERE ID=@id");
                command.Parameters.AddWithValue("quantity", quantity + product.Quantity);
                command.Parameters.AddWithValue("id", product.ID);
                ExecutePreparedCommand(command);

                AddTransaction(new Transaction
                {
                    Date = DateTime.Now,
                    Product = product,
                    Type = Transaction.TransactionType.ProductAdded,
                    Quantity = quantity,
                    Employee = GetEmployee("","")
                });
            }
            else
            {
                var command = new MySqlCommand("INSERT INTO products (Name, Quantity) VALUES (@name, @quantity)");
                command.Parameters.AddWithValue("name", productName);
                command.Parameters.AddWithValue("quantity", quantity);
                ExecutePreparedCommand(command);
                product = GetProduct(productName);

                AddTransaction(new Transaction
                {
                    Date = DateTime.Now,
                    Product = product,
                    Type = Transaction.TransactionType.ProductAdded,
                    Quantity = quantity,
                    Employee = GetEmployee("", "")
                });
            }
        }   
        public static void RemoveProduct(Product product, int quantity, Employee employee)
        {
            var command = new MySqlCommand("UPDATE products SET quantity=@quantity WHERE id=@id");
            command.Parameters.AddWithValue("quantity", product.Quantity - quantity);
            command.Parameters.AddWithValue("id", product.ID);
            ExecutePreparedCommand(command);

            AddTransaction(new Transaction
            {
                Date = DateTime.Now,
                Type = Transaction.TransactionType.ProductRemoved,
                Quantity = quantity,
                Employee = employee,
                Product = product
            });
        }
        public static Employee[] GetEmployees(string employeeName)
        {
            var command = new MySqlCommand("SELECT * FROM employees WHERE LOWER(Name) = @name");
            command.Parameters.AddWithValue("name", employeeName.ToLower());

            using (var reader = GetReader(command))
            {
                var employees = new List<Employee>();

                while (reader.Read())
                {
                    employees.Add(GetEmployeeFromReader(reader));
                }

                reader.Close();
                return employees.ToArray();
            }
        }
        public static Employee GetEmployee(string employeeName, string employeeSector)
        {
            var command = new MySqlCommand("SELECT * FROM employees WHERE LOWER(Name) = @name AND Sector = @sector");
            command.Parameters.AddWithValue("name", employeeName.ToLower());
            command.Parameters.AddWithValue("sector", employeeSector);

            using (var reader = GetReader(command))
            {
                if (!reader.Read()) return null;

                var employee = GetEmployeeFromReader(reader);
                reader.Close();
                return employee;
            }
        }

        public static Employee GetEmployee(int employeeID)
        {
            var command = new MySqlCommand("SELECT * FROM employees WHERE ID = @id");
            command.Parameters.AddWithValue("id", employeeID);

            using (var reader = GetReader(command))
            {
                if (!reader.Read()) return null;

                var employee = GetEmployeeFromReader(reader);
                reader.Close();
                return employee;
            }
        }
        public static void AddEmployee(string employeeName, string employeeSector)
        {
            var command = new MySqlCommand("INSERT INTO employees (Name, Sector) VALUES (@name, @sector)");
            command.Parameters.AddWithValue("name", employeeName);
            command.Parameters.AddWithValue("sector", employeeSector);
            ExecutePreparedCommand(command);
        }

        public static Employee[] GetEmployeesFromSector(string sector)
        {
            var command = new MySqlCommand("SELECT * FROM employees WHERE Sector = @sector");
            command.Parameters.AddWithValue("sector", sector);

            using (var reader = GetReader(command))
            {
                var employees = new List<Employee>();

                while(reader.Read())
                {
                    employees.Add(GetEmployeeFromReader(reader));
                }

                reader.Close();
                return employees.ToArray();
            }
        }

        public static Employee[] GetAllEmployees()
        {
            var command = new MySqlCommand("SELECT * FROM employees");

            using (var reader = GetReader(command))
            {
                var employees = new List<Employee>();

                while (reader.Read())
                {
                    employees.Add(GetEmployeeFromReader(reader));
                }

                reader.Close();
                return employees.ToArray();
            }
        }

        private static Employee GetEmployeeFromReader(MySqlDataReader reader)
        {
            return new Employee
            {
                ID = reader.GetInt32("ID"),
                Name = reader.GetString("Name"),
                Sector = reader.GetString("Sector")
            };
        }

        private static void AddTransaction(Transaction transaction)
        {
            var command = new MySqlCommand("INSERT INTO transactions (Date, ProductID, Type, Quantity, EmployeeID) VALUES (@date, @productID, @type, @quantity, @employeeID)");
            command.Parameters.AddWithValue("date", transaction.Date);
            command.Parameters.AddWithValue("productID", transaction.Product.ID);
            command.Parameters.AddWithValue("type", (int)transaction.Type);
            command.Parameters.AddWithValue("quantity", transaction.Quantity);
            command.Parameters.AddWithValue("employeeID", transaction.Employee.ID);

            ExecutePreparedCommand(command);
        }


        public static Product GetProduct(int productID)
        {
            var command = new MySqlCommand("SELECT * FROM products WHERE ID = @id");
            command.Parameters.AddWithValue("id", productID);

            using (var reader = GetReader(command))
            {
                if (!reader.Read()) return null;

                var product = GetProductFromReader(reader);
                reader.Close();
                return product;
            }
        }
        public static Product[] GetAllProducts()
        {
            var command = new MySqlCommand("SELECT * FROM products");

            using (var reader = GetReader(command))
            {
                var products = new List<Product>();
                while (reader.Read())
                {
                    products.Add(GetProductFromReader(reader));
                }

                reader.Close();
                return products.ToArray();
            }
        }

        public static Transaction[] GetTransactions()
        {
            var command = new MySqlCommand("SELECT products.Name, transactions.Date, transactions.Type, transactions.Quantity, transactions.EmployeeID FROM products, transactions " +
                                           "WHERE transactions.ProductID = products.ID");

            using (var reader = GetReader(command))
            {
                var transactions = new List<Transaction>();
                while (reader.Read())
                {
                    transactions.Add(new Transaction
                    {
                        Date = reader.GetDateTime("Date"),
                        Product = new Product
                        {
                            Name = reader.GetString("Name")
                        },
                        Type = (Transaction.TransactionType)reader.GetInt32("Type"),
                        Quantity = reader.GetInt32("Quantity"),
                        Employee = GetEmployee(reader.GetInt32("EmployeeID"))
                    });
                }

                reader.Close();
                return transactions.ToArray();
            }
        }

        private static Product GetProductFromReader(MySqlDataReader reader)
        {
            return new Product
            {
                ID = reader.GetInt32("ID"),
                Name = reader.GetString("Name"),
                Quantity = reader.GetInt32("Quantity")
            };
        }

        private static MySqlDataReader GetReader(MySqlCommand command)
        {
            var connection = new MySqlConnection(ConnectionString);
            command.Connection = connection;
            connection.Open();
            command.Prepare();

            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        private static void ExecutePreparedCommand(MySqlCommand command)
        {
            var connection = new MySqlConnection(ConnectionString);
            command.Connection = connection;
            connection.Open();
            command.Prepare();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
