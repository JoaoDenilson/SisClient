using System;
using System.Collections.Generic;
using System.Text;
using Lib.Model;

namespace SisClient.Converter
{
    class EmployeeText
    {
        public static string ConverterToText(Employee employee)
        {
            string text = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}",
                employee.Name,
                employee.DateBirth,
                employee.Phone,
                employee.CPF,
                employee.RG,
                employee.CEP,
                employee.UF,
                employee.City,
                employee.Address,
                employee.Occupation,
                employee.Wage,
                employee.DateHiring
                );
            return text;
        }

        public static Employee ConverterToEmployee(string line)
        {
            string[] elements = line.Split(',');

            Employee employee = new Employee();
            employee.Name = elements[0];
            employee.DateBirth = DateTime.Parse(elements[1]);
            employee.Phone = elements[2];
            employee.CPF = int.Parse(elements[3]);
            employee.RG = elements[4];
            employee.CEP = elements[5];
            employee.UF = elements[6];
            employee.City = elements[7];
            employee.Address = elements[8];
            employee.Occupation = elements[9];
            employee.Wage = double.Parse(elements[10]);
            employee.DateHiring = DateTime.Parse(elements[11]);
            return employee;

        }
    }
}
