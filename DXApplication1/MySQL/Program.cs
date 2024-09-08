using System;
using System.Threading;
using MySql.Data.MySqlClient;
using Microsoft.AspNet.SignalR.Client;

namespace DXApplication1.MySQL
{
    internal class Program
    {
        private static IHubProxy _hubProxy;
        private static HubConnection _hubConnection;
        private static bool _running = true;

        static void Main(string[] args)
        {
            // Bước 1: Kết nối đến SignalR Hub
            _hubConnection = new HubConnection("http://localhost:44317/"); // URL của SignalR server
            _hubProxy = _hubConnection.CreateHubProxy("NotificationHub"); // Tên của Hub (định nghĩa trong ứng dụng SignalR server)

            try
            {
                _hubConnection.Start().Wait(); // Khởi động kết nối đến SignalR Hub
                Console.WriteLine("Connected to SignalR Hub");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not connect to SignalR Hub: {ex.Message}");
                return;
            }

            // Bước 2: Khởi động một thread để lắng nghe thay đổi từ MySQL
            Thread listenerThread = new Thread(new ThreadStart(ListenForDatabaseChanges));
            listenerThread.Start();

            // Bước 3: Giữ ứng dụng chạy
            Console.WriteLine("Press Enter to stop the application...");
            Console.ReadLine(); // Đợi người dùng nhấn Enter để dừng ứng dụng
            _running = false;
            listenerThread.Join(); // Đợi thread kết thúc trước khi thoát
        }

        // Hàm lắng nghe thay đổi từ MySQL
        private static void ListenForDatabaseChanges()
        {
            string connectionString = "Server=localhost;Database=your_database;User ID=root;Password=your_password;"; // Chuỗi kết nối đến MySQL
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                while (_running)
                {
                    // Gọi hàm kiểm tra thay đổi
                    CheckForChanges(connection);
                    Thread.Sleep(5000); // Kiểm tra mỗi 5 giây
                }
            }
        }

        // Hàm kiểm tra sự thay đổi trong bảng log
        private static void CheckForChanges(MySqlConnection connection)
        {
            string query = "SELECT * FROM audit_log WHERE timestamp > NOW() - INTERVAL 1 MINUTE"; // Thay đổi câu lệnh SQL phù hợp với audit log của bạn
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Lấy thông tin từ kết quả truy vấn
                        string tableName = reader["table_name"].ToString();
                        string action = reader["action"].ToString();
                        string newData = reader["new_data"].ToString();

                        // Gửi thông báo qua SignalR
                        _hubProxy.Invoke("SendNotification", $"Change detected in table {tableName}: {action} - {newData}");
                        Console.WriteLine($"Change detected in table {tableName}: {action} - {newData}");
                    }
                }
            }
        }
    }

}
