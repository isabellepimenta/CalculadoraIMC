
namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
         
            
            Console.WriteLine("Bem vindo ao IMC, digite seu nome");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Agora, qual é a sua altura?");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("E o seu peso?");
            float peso = Convert.ToSingle(Console.ReadLine());

            Pessoas pessoa = new Pessoas(nome, altura, peso);

            double imc = peso / (altura * altura);

             double PerderPeso = peso-(24.9 * (altura*altura));
            double GanharPeso = (18.5 * (altura*altura)-peso);

            Console.WriteLine("\nNome: {0}\nAltura: {1}\nPeso: {2}\nIMC: {3}\nFaixa: {4}", nome, altura, peso, imc, StatusPeso(imc));
            if(imc < 18.50 || imc > 24.99)
            {
                if(imc < 18.49) {
                    Console.WriteLine("\nPara chegar no peso ideal você precisa ganhar {0}Kg", GanharPeso);
                }
                if(imc > 25) {
                    Console.WriteLine("\nPara chegar no peso ideal você precisa perder {0}kg",PerderPeso);
                }
            }else{
                Console.WriteLine("\nVocê está no peso ideal");
            }   
        }

        public static String StatusPeso(double imc)
        {
            if (imc < 17)
            {
            return "Muito abaixo do peso";
            }

            if (imc >= 17 && imc <= 18.49)
            {
            return "Abaixo do peso";
            }

            if(imc >= 18.50 && imc <= 24.99)
            {
            return "Peso normal";
            }

            if(imc >= 25 && imc <= 29.99)
            {
            return "Acima do peso";
            }

            if(imc >= 30 && imc <= 34.99)
            {
            return "Obesidade I";
            }

            if(imc >= 35 && imc <= 39.99)
            {
            return "Obesidade II (severa)";
            }

            if(imc > 40)
            {
            return "Obesidade III (mórbida)";
            }
            return "Valor inválido";
        }
        
    }
}