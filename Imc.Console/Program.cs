
//Declaración de variables
double peso, estatura, imc;
string estado;

//Entrada de datos
Console.WriteLine("Ingresa tu peso en kg: ");
peso =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa tu estatura en metros: ");
estatura=Convert.ToDouble(Console.ReadLine());

//Proceso
imc = CalcularIMC(peso, estatura);
estado = EstadoNut(imc);

//Salida
Console.WriteLine("Tu IMC es: " + imc);
Console.WriteLine("Estado nutricional: " +estado);

//Método que calcula IMC
static double CalcularIMC(double peso, double estatura)
{
    return peso/(estatura * estatura);

}

//Método que determina el estado nutricional

static string EstadoNut(double imc)
{
    if (imc < 18.5)
    {
        return "Peso bajo";
    }
    else if (imc < 25.0)
    {
        return "Peso normal";
    }
    else if (imc < 40.0)
    {
        return "Obesidad";
    }
    else
    {
        return "Obesidad extrema";
    }
}
