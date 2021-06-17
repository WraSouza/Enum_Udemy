using System;
using Enum_Udemy.Entities;
using Enum_Udemy.Entities.Enums;
using System.Globalization;

namespace Enum_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre Nome do Departamento: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Entre Dados do Funcionário");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Nível (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando o departamento
            Department dept = new Department(deptName);

            //Instanciando o trabalhador
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantos Contratos para esse trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i <= n; i++)
            {
                Console.WriteLine($"Entre com contrato #{i}");
                Console.Write("Data (DD/MM/YYYY: )");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor Por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duracao(Horas): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valorPorHora, hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Entre com Mês e Ano para Calcular Rendimento (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Department.Name);
            Console.WriteLine("Rendimento: " + monthAndYear + ": " + worker.Income(year, month));


            //Order order = new Order
            //{
            //    Id = 1080,
            //    Moment = DateTime.Now,
            //    Status = OrderStatus.PendingPayment
            //};

            //Console.WriteLine(order);

            ////Valor Enum para String
            //string txt = OrderStatus.PendingPayment.ToString();
            //Console.WriteLine(txt);

            ////Valor string para Enum. Para converter a string precisa estar escrita corretamente
            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
        }
    }
}
