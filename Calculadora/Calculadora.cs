namespace Atv
{
    public class Calculadora
    {
        Calculo calculo = new Calculo();
        public void LerValores()
        {
            Console.Write("Digite o valor A: ");
            calculo.ValorA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            calculo.ValorB = Convert.ToInt32(Console.ReadLine());
        }
        public void ExecutarCalculadora()
        {
            LerValores();
            calculo.CalcularSoma();
            calculo.CalcularSubtracao();
            calculo.CalcularMultiplicacao();
            calculo.RetornarMaior();

            Console.Write("Digite um valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            double somaGeral = calculo.SomarGeral(valor);

            Console.WriteLine($"A soma geral é {somaGeral}");

        }
    }
}
