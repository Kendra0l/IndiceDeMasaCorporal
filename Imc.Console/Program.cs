
using Imc.Model;

Console.WriteLine("Aplicación que calcula el indice de masa corporal de una persona\n");

decimal peso =
    ReadDecimal("Proporciona el peso en kilogramos de la persona: ");

decimal estatura =
    ReadDecimal("Proporciona la estatura en metros de la persona: ");

decimal imc = IndiceDeMasaCorporaLib.IndiceDeMasaCorporal(peso, estatura);

Console.WriteLine(
    $"El índice de masa coporal de la persona es: {imc:G6}");
Console.WriteLine(
    $"El estado nutricional de la persona es: {IndiceDeMasaCorporaLib.DeterminaEstadoNutricional(imc)}");

Console.WriteLine();

static decimal ReadDecimal(string indicacion)
{
    Console.Write(indicacion);
    var entradaComoTexto = Console.ReadLine();
    return Convert.ToDecimal(entradaComoTexto);
}


