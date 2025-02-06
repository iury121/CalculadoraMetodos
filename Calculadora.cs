namespace Calculadora
{
    class Operacoes
    {

        public static decimal ObterValor()
        {
        repetir:
            Console.Write("Informar o valor: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Console.WriteLine("Valor inválido!");
                goto repetir;
            }
            else
            {
                return valor;
            }
        }

        public static void RealizarAdicao()
        {
            decimal valor1 = Operacoes.ObterValor();
            decimal valor2 =  Operacoes.ObterValor();
            Console.WriteLine($"A soma dos valores {valor1} e {valor2} é: {valor1 + valor2}");
        }

        public static void RealizarSubtracao(){
            
        }
    }
}