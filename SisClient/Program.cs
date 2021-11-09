using SisClient.View;
using System;

namespace SisClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int options = 0;
            while(options != 5)
            {
                Console.WriteLine("O que deseja fazer? \n1 = Cadastrar cliente \n2 = Listar cliente \n3 = Cadastrar funcionário \n4 Listar funcionário \n5 Sair)");

                options = int.Parse(Console.ReadLine());

                ViewClient viewClient = new ViewClient();
                ViewEmployee viewEmployee = new ViewEmployee();

                switch (options)
                {
                    case 1:
                        
                        viewClient.CreatClient();
                        break;
                    case 2:
                        viewClient.ListClient();
                        break;
                    case 3:
                        viewEmployee.CreatEmployee();
                        break;
                    case 4:
                        viewEmployee.ListEmployee();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Comando não encontrado!");
                        break;
                }
            }
        }
    }
}
