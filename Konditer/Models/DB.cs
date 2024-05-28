using Npgsql;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Konditer.Models;
using System.Linq;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Models
{
    public class DB
    {
        public NpgsqlConnection conn;
        public const string CONN_STRING = @"host=79.174.88.114; port=15201; database=Konditer_DB; username=www74; password=ProAwpGGX1488$;";

        public DB()
        {
            try
            {
                var isConnected = CrossConnectivity.Current.IsConnected;

                if (isConnected)
                {
                    conn = new NpgsqlConnection(CONN_STRING);
                }
                else
                {
                    return;
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Open();
                Console.WriteLine("CONNECTION GOOD");
            }
        }

        public async Task<User> GetUser(string username)
        {
            string commandText = "select * from users where username = @username";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("username", username);
                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                while (await reader.ReadAsync())
                {
                    User user = ReadUser(reader);
                    return user;
                }
            }
            return null;
        }

        private static User ReadUser(NpgsqlDataReader reader)
        {
            int? id = reader["id_user"] as int?;
            string username = reader["username"] as string;
            string password = reader["user_pass"] as string;
            string name = reader["name"] as string;
            string email = reader["mail"] as string;
            string phone = reader["phone"] as string;

            User user = new User
            {
                Id = id.Value,
                Username = username,
                Password = password,
                Name = name,
                Email = email,
                Phone = phone
            };
            return user;
        }

        public async Task Add_User(User user)
        {
            string commandText = "INSERT INTO users (username, user_pass) VALUES (@username, @user_pass)";
            using (var cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("username", user.Username);
                cmd.Parameters.AddWithValue("user_pass", user.Password);

                await cmd.ExecuteNonQueryAsync();
            }
        }
        public async Task UpdateUserInfo(string first_name, string mail, string number, string username)
        {
            var commandText = @"UPDATE users SET name = @name, mail = @mail, phone = @num WHERE username = @username";

            using (var cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("name", first_name);
                cmd.Parameters.AddWithValue("mail", mail);
                cmd.Parameters.AddWithValue("num", number);
                cmd.Parameters.AddWithValue("username", username);

                await cmd.ExecuteNonQueryAsync();
            }
            conn.Close();
        }

        public async Task<Sale_Item> GetSaleItem(int id)
        {
            string commandText = "select product.id, product.name, product.image, product.price, sale_item.count_sale from product, sale_item where sale_item.id_item = @id and sale_item.id_item = product.id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("id", id);
                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        Sale_Item sale_item = ReadSaleItem(reader);
                        return sale_item;
                    }
            }
            return null;
        }

        private static Sale_Item ReadSaleItem(NpgsqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["id"]);
            string name = reader["name"] as string;
            string image = reader["image"] as string;
            float price = Convert.ToSingle(reader["price"]);
            float count = Convert.ToSingle(reader["count_sale"]);

            Sale_Item sale_item = new Sale_Item
            {
                Id = id,
                Name = name,
                Image = image,
                Price = price.ToString(),
                Count_Sale = count.ToString()
            };
            return sale_item;
        }

        public async Task<Item> GetItem(int id)
        {
            string commandText = "select * from product where id = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("id", id);
                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                while (await reader.ReadAsync())
                {
                    Item item = ReadItem(reader);
                    return item;
                }
            }
            return null;
        }

        private static Item ReadItem(NpgsqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["id"]);
            string category = reader["category"] as string;
            string name = reader["name"] as string;
            float price = Convert.ToSingle(reader["price"]);
            string image = reader["image"] as string;
            float ccal = Convert.ToSingle(reader["ccal"]);
            float belok = Convert.ToSingle(reader["belok"]);
            float jir = Convert.ToSingle(reader["jir"]);
            float uglevod = Convert.ToSingle(reader["uglevod"]);
            string sostav = reader["sostav"] as string;
            string srok = reader["srok"] as string;
            string proizvod = reader["proizvod"] as string;

            Item item = new Item
            {
                Id = id,
                Category = category,
                Name = name,
                Price = price,
                Image = image,
                Ccal = ccal,
                Belok = belok,
                Jir = jir,
                Uglevod = uglevod,
                Sostav = sostav,
                Srok = srok,
                Proizod = proizvod
            };
            return item;
        }
        public async Task AddBasketItem(int id_item, int count, float start_price, float end_price, string username)
        {
            string commandText = "INSERT INTO basket (id_product, count, username, start_price, end_price) VALUES (@id_item, @count, @username, @start_price, @end_price)";
            using (var cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("id_item", id_item);
                cmd.Parameters.AddWithValue("count", count);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("start_price", start_price);
                cmd.Parameters.AddWithValue("end_price", end_price);

                await cmd.ExecuteNonQueryAsync();
            }
        }
        public async Task AddMoreBasketItem(int count, float end_price, int id_item)
        {
            string commandText = "UPDATE basket SET count = @count, end_price = @end_price WHERE id_product = @id_item";
            using (var cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("id_item", id_item);
                cmd.Parameters.AddWithValue("count", count);
                cmd.Parameters.AddWithValue("end_price", end_price);

                await cmd.ExecuteNonQueryAsync();
            }
        }
        public async Task<Basket_Item> GetBasketItem(int id, string username)
        {
            string commandText = "SELECT basket.id, basket.id_product, basket.count, product.image, product.name, basket.start_price, basket.end_price FROM basket, product WHERE basket.id_product = @id_item and basket.id_product = product.id and basket.username = @username";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("id_item", id);
                cmd.Parameters.AddWithValue("username", username);
                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        Basket_Item basket_item = ReadBasketItem(reader);
                        return basket_item;
                    }
            }
            return null;
        }

        private static Basket_Item ReadBasketItem(NpgsqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["id"]);
            int id_item = Convert.ToInt32(reader["id_product"]);
            string image = reader["image"] as string;
            string name = reader["name"] as string;
            int count = Convert.ToInt32(reader["count"]);
            float price = Convert.ToSingle(reader["start_price"]);
            float end_price = Convert.ToSingle(reader["end_price"]);

            Basket_Item basket_item = new Basket_Item
            {
                Id = id,
                Id_Item = id_item,
                Image = image,
                Name = name,
                Start_Price = price,
                End_Price = end_price,
                Count = count
            };
            return basket_item;
        }
        public async Task<int> GetCountBasketItem(string username)
        {
            string commandText = "SELECT MAX(id_product) FROM basket WHERE username = @username";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("username", username);

                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        int count = Convert.ToInt32(reader["max"]);
                        return count;
                    }
            }
            return 0;
        }
        public async Task<float> GetPriceBasketItems(string username)
        {
            string commandText = "SELECT SUM(end_price) from basket where username = @username";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("username", username);

                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        float count = Convert.ToInt32(reader["sum"]);
                        return count;
                    }
            }
            return 0;
        }
        public async Task<long> GetCountItems(string username)
        {
            string commandText = "SELECT SUM(count) FROM basket WHERE username = @username";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("username", username);

                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        long count = Convert.ToInt32(reader["sum"]);
                        return count;
                    }
            }
            return 0;
        }
        public async Task ClearBasket(string username)
        {
            string commandText = "DELETE FROM basket WHERE username = @username";
            using (var cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("username", username);

                await cmd.ExecuteNonQueryAsync();
            }
        }
        public async Task AddOrder(float summ, string id_items, string username)
        {
            string commandText = "INSERT INTO orders (summ, id_items, username) values (@summ, @id_items, @username)";
            using (var cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("summ", summ);
                cmd.Parameters.AddWithValue("id_items", id_items);
                cmd.Parameters.AddWithValue("username", username);

                await cmd.ExecuteNonQueryAsync();
            }
        }
        public async Task DeleteOrder(int id, string username)
        {
            string commandText = "DELETE FROM orders WHERE id = @id AND username = @username";
            using (var cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("username", username);

                await cmd.ExecuteNonQueryAsync();
            }
        }
        public async Task<int> GetCountOrderItem(string username)
        {
            string commandText = "SELECT MAX(id) FROM orders WHERE username = @username";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("username", username);

                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        int count = Convert.ToInt32(reader["max"]);
                        return count;
                    }
            }
            return 0;
        }
        public async Task<Order> GetOrderItem(int id, string username)
        {
            string commandText = "SELECT * FROM orders WHERE id = @id and username = @username";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("username", username);
                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                    {
                        Order order_item = ReadOrderItem(reader);
                        return order_item;
                    }
            }
            return null;
        }
        private static Order ReadOrderItem(NpgsqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["id"]);
            float summ = Convert.ToSingle(reader["summ"]);
            string date = reader["date_order"].ToString();
            string id_items = reader["id_items"].ToString();
            string count_items = reader["count_items"].ToString();

            Order order_item = new Order
            {
                Id = id,
                Summ = summ,
                Date = date,
                Id_items = id_items,
                Count_items = count_items
            };
            return order_item;
        }

        public async Task<Basket_Item> GetOrderContentItem(int id)
        {
            string commandText = "SELECT id, image, name FROM product WHERE id = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("id", id);
                await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
                while (await reader.ReadAsync())
                {
                    Basket_Item basket_item = ReadOrderContentItem(reader);
                    return basket_item;
                }
            }
            return null;
        }

        private static Basket_Item ReadOrderContentItem(NpgsqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["id"]);
            string image = reader["image"] as string;
            string name = reader["name"] as string;

            Basket_Item basket_item = new Basket_Item
            {
                Id = id,
                Image = image,
                Name = name,
            };
            return basket_item;
        }
    }
}
