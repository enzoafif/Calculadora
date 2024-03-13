namespace Atv
{
    public class Calculo
    {
        private double Resultado;
        public double ValorA;
        public double ValorB;

        public void CalcularSoma()
        {
            double soma = ValorA + ValorB;
            Resultado = soma;
            Console.WriteLine($"\nA soma é {Resultado}");
        }

        public void CalcularSubtracao()
        {
            double subtracao = ValorA + ValorB;
            Resultado = subtracao;
            Console.WriteLine($"A subtraçao é {Resultado}");
        }
        public void CalcularMultiplicacao()
        {
            double multiplicacao = ValorA * ValorB;
            Resultado = multiplicacao;
            Console.WriteLine($"A multiplicação é {Resultado}\n");
        }
        public double RetornarMaior()
        {
            if (ValorA > ValorB)
            {
                return ValorA;
            }
          
            return ValorB;
            
        }
        public double SomarGeral(double valor)
        {
            return ValorA + ValorB + valor;
        }
    
    }
}
