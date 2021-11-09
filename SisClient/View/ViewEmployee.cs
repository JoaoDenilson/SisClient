using System;
using System.Collections.Generic;
using System.Text;
using Lib.Model;
using Lib.Files;
using SisClient.Converter;

namespace SisClient.View
{
    class ViewEmployee
    {
        public void CreatEmployee()
        {
            Employee employee = new Employee();
            Console.Clear();

            Console.WriteLine("CADASTRAR EMPLOYEE");

            Console.Write("Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("DateBirth: ");
            employee.DateBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("CPF (Digitar apenas números): ");
            employee.CPF = int.Parse(Console.ReadLine());

            Console.Write("RG: ");
            employee.RG = Console.ReadLine();

            Console.Write("Phone: ");
            employee.Phone = Console.ReadLine();

            Console.Write("CEP: ");
            employee.CEP = Console.ReadLine();

            Console.Write("Address: ");
            employee.Address = Console.ReadLine();

            Console.Write("City: ");
            employee.City = Console.ReadLine();

            Console.Write("UF: ");
            employee.UF = Console.ReadLine();

            Console.Write("Occupation: ");
            employee.Occupation = Console.ReadLine();

            Console.Write("Wage: ");
            employee.Wage = double.Parse(Console.ReadLine());

            Console.Write("DateHiring: ");
            employee.DateHiring = DateTime.Parse(Console.ReadLine());

            ManagerFiles.RegisterFile("Employee", EmployeeText.ConverterToText(employee));
        }
        public void ListEmployee()
        {
            Console.Clear();

            Console.WriteLine("LIST EMPLOYES");

            string[] lines = ManagerFiles.ReadFiles("Employee");

            foreach (string line in lines)
            {
                Employee employee = EmployeeText.ConverterToEmployee(line);
                Console.WriteLine("Name: " + employee.Name + "Occupation:" + employee.Occupation);
            }
        }

    }
}
