


class TesteCalculadora
{
    static void Main(string[] args)
    {
        Console.WriteLine("Teste Unitario Iniciado...");
        TesteSomar();
        TesteSomarNegativo();
    }

    private static void TesteSomarNegativo()
    {
        var calc = new Calculadora();
        int resultadoEsperado = -100;

        int resultado = calc.Somar(-50,-50);

        if (resultado == resultadoEsperado)
        {
            Console.WriteLine("TesteSomarNegativo: OK");
        }
        else
        {
            Console.WriteLine("TesteSomarNegativo: FAILLED");
        }
    }

    private static void TesteSomar()
    {
        var calc = new Calculadora();
        int resultadoEsperado = 350;

        int resultado = calc.Somar(100, 250);

        if(resultado == resultadoEsperado)
        {
            Console.WriteLine("TesteSomar: OK");
        }
        else
        {
            Console.WriteLine("TesteSomar: FAILLED");
        }
    }
}