class Exercicio5
    {
        public static void InverterString()
        {
            Console.WriteLine("Informe uma string para inverter:");
            string input = Console.ReadLine();
            char[] caracteres = input.ToCharArray();
            string invertida = "";

            for (int i = caracteres.Length - 1; i >= 0; i--)
            {
                invertida += caracteres[i];
            }

            Console.WriteLine("String invertida: " + invertida);
        }
    }