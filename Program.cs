using ProgramaSalario;
using System.Globalization;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        CalcularSalario calc = new CalcularSalario();
        Console.WriteLine("Digite o nome do contribuinte: ");
        calc.Nome = Console.ReadLine();
        Console.WriteLine("Digite o salário bruto: ");
        calc.Bruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o imposto a ser cobrado:");
        calc.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Funcionario: " + calc);

        Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
        double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        calc.AumentarSalario(porcent);

        Console.WriteLine("Salario atualizado: " + calc);

    }
}