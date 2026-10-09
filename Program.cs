Console.WriteLine("Hello, World!");
Console.WriteLine("SISTEMA DE MONITOREO DE MOTORES");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();

// Capturar la información del objeto
Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin identificador";

Console.Write("Ingrese la temperatura (°C): ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente (A): ");
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad (RPM): ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());

// Solicitar al objeto que evalúe su temperatura y estado de marcha
string estadoTemperatura = motor1.EvaluarTemperatura();
string estadoMarcha = motor1.CompararVelocidad();+

// Mostrar resultados
Console.WriteLine();
Console.WriteLine("--- DATOS DEL MOTOR ---");
Console.WriteLine($"Identificador: {motor1.Identificador}");
Console.WriteLine($"Temperatura:   {motor1.Temperatura:F2} °C");
Console.WriteLine($"Corriente:     {motor1.Corriente:F2} A");
Console.WriteLine($"Velocidad:     {motor1.Velocidad:F2} RPM");
Console.WriteLine();
Console.WriteLine("--- DIAGNÓSTICO ---");
Console.WriteLine($"Diagnóstico Temperatura: {estadoTemperatura}");
Console.WriteLine($"Estado de Operación:     {estadoMarcha}");


// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";

    public double Temperatura { get; set; }

    public double Corriente { get; set; }

    public double Velocidad { get; set; }


    // Método para evaluar si la temperatura supera el límite de 70 °C
    public string EvaluarTemperatura()
    {
        if (Temperatura > 70)
        {
            return "ALERTA: TEMPERATURA ELEVADA (Mayor a 70 °C)";
        }
        else
        {
            return "TEMPERATURA NORMAL (Menor o igual a 70 °C)";
        }
    }


    // Método para determinar si el motor está en marcha o detenido
    public string CompararVelocidad()
    {
        if (Velocidad > 0)
        {
            return "EN MARCHA";
        }
        else
        {
            return "DETENIDO";
 
        }
    }
}