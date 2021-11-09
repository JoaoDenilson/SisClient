using System;
using System.Collections.Generic;
using System.Text;
using Lib.Model;

namespace SisClient.Converter
{
    class ClientText
    {
        public static string ConverterToText(Client client)
        {
            string text = string.Format("{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}",
                client.Name,
                client.DateBirth,
                client.Phone,
                client.CPF,
                client.RG,
                client.CEP,
                client.UF,
                client.City,
                client.Address
                );
            return text;
        }

        public static Client ConverterToClient(string line)
        {
            string[] elements = line.Split(',');

            Client client = new Client();
            client.Name = elements[0];
            client.DateBirth = DateTime.Parse(elements[1]);
            client.Phone = elements[2];
            client.CPF = int.Parse(elements[3]);
            client.RG = elements[4];
            client.CEP = elements[5];
            client.UF = elements[6];
            client.City = elements[7];
            client.Address = elements[8];

            return client;

        }
    }
}
