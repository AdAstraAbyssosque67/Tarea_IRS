namespace FlujodeControl_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su Sueldo:");
            double Sueldo = Convert.ToDouble(Console.ReadLine());
            double ISR = Sueldo switch
            {
                <= 34685 => 0,
                <= 52027 => (Sueldo - 34685) * 0.15,
                <= 72260 => 2601 + (Sueldo - 52027) * 0.20,
                _ => 6648 + (Sueldo - 72260) * 0.25,
            };
        Console.Clear();    
        Console.WriteLine($"Su sueldo es:  RD${Sueldo}");
        Console.WriteLine();
            if (ISR > 0)
        Console.WriteLine($"Debe pagar de ISR: RD${ISR}");
            else
        Console.WriteLine("N/A");
        }
    }
}
