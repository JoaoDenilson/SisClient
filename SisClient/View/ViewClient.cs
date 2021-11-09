using Lib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisClient.View
{
    class ViewClient
    {
        public void CreatClient()
        {
            Client client = new Client();
            Console.Clear();

            Console.WriteLine("CADASTRAR CLIENT");

            Console.Write("Name: ");
            client.Name = Console.ReadLine();

            Console.Write("DateBirth: ");
            client.DateBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("CPF (Digitar apenas números): ");
            client.CPF = int.Parse(Console.ReadLine());

            Console.Write("RG: ");
            client.RG = Console.ReadLine();

            Console.Write("Phone: ");
            client.Phone = Console.ReadLine();

            Console.Write("CEP: ");
            client.CEP = Console.ReadLine();

            Console.Write("Address: ");
            client.Address = Console.ReadLine();

            Console.Write("City: ");
            client.City = Console.ReadLine();

            Console.Write("UF: ");
            client.UF = Console.ReadLine();
        }
        public void ListClient()
        {

        }
    }
}
