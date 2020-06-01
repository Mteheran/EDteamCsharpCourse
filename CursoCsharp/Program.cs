using CursoCsharp.Enumerations;
using System;

namespace CursoCsharp
{
    /// <summary>
    /// Clase principal del programa
    /// </summary>
    class Program
    {
        // este es el método principal
        static void Main(string[] args)
        {
            #region variables

            const string nombre = "Miguel"; // esta variable guarda el nombre
            var apellido = "Teheran";
            apellido = " Teheran Garrido ";
            short? edad = 30;
            Int16 altura = 178;
            float alturaEnMetros = 1.78f;

            #endregion

            Console.WriteLine("Hola " + nombre + " " + apellido);

            Console.WriteLine(string.Format("Mi nombre tiene {0} letras", nombre.Length));

            Console.WriteLine($"Mi apellido tiene {apellido.Trim().Replace(" ","").Length} letras");

            Console.WriteLine($"Mi edad es: {edad}");

            Console.WriteLine($"Mi altura es: {altura} cms");

            Console.WriteLine($"Mi altura en metros es: {alturaEnMetros}");

            DateTime fechaNacimiento = new DateTime(1990,4,1);
            var fechaActual = DateTime.Now;

            Console.WriteLine($"Mi fecha de nacimiento es: {fechaNacimiento.Date.ToString("MM/dd/yy")}");

            Console.WriteLine($"La fecha actual es {fechaActual.Date.ToString("MM/dd/yy")}");

            var diferenciaDeFechas = fechaActual - fechaNacimiento;

            Console.WriteLine($"Mi edad de acuerdo a mi fecha de nacimiento es {diferenciaDeFechas.Days / 365}");

            var migenero = Genero.Masculino;

            Console.WriteLine($"Mi genero es: {migenero}");

            DateTime? fechaTerminacionCurso = null;

            Console.WriteLine($"Fechas terminación curso: {fechaTerminacionCurso?.Date} ");

            bool? tieneMascota = null;

            Console.WriteLine($"Tengo mascota?: {tieneMascota}");


        }
    }

}
