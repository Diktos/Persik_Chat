using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Persik_Chat_Classes
{
    public class Client
    {
        public static void Main(string[] args)
        {
            var client = new Client();
            Task cl = Task.Run(() =>
            {
                client.Start();
            });
            cl.Wait();  
        }

        public void Start()
        {

            var tcpClient = new TcpClient("127.0.0.1", 10000);
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            NetworkStream stream = tcpClient.GetStream();
            //// Надсилаємо ім'я клієнта серверу
            byte[] data = Encoding.UTF8.GetBytes($"connect {name}\r\n");
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            var bytes = stream.Read(data, 0, data.Length);
            var responce = Encoding.UTF8.GetString(data, 0, bytes);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Responce from server: {responce}");
            Console.ResetColor();

            // Читання повідомлень 
            Task ReceiveMsgTask = Task.Run(() =>
            {

                while (true)
                {
                    data = new byte[1024];
                    bytes = stream.Read(data, 0, data.Length);
                    if (bytes > 0)
                    {
                        var serverMessage = Encoding.UTF8.GetString(data, 0, bytes);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(serverMessage);
                        Console.ResetColor();
                    }
                }
            });
            // Надсилання повідомлень від користувача.
            // Послідовне виконання завдань і контрольоване закриття з'єднання запобігає конфліктам і помилкам.
            while (true)
            {
                var inputMessage = Console.ReadLine();
                // Щоб не відправляти пробіли помилкові
                if (string.IsNullOrEmpty(inputMessage)) { continue; }
                if (inputMessage.ToLower() == "exit") { break; }

                byte[] dataMessage = Encoding.UTF8.GetBytes(inputMessage + "\r\n");
                stream.Write(dataMessage, 0, dataMessage.Length);
            }
            stream.Close();
            tcpClient.Close();

        }
    }

}
