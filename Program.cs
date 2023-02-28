//Natalia Andrea Bohorquez Chevejoni
//cc: 1035869600
//Evelin Carolina Montoya Gomez
//CC: 1152709204

//Punto_1:

 
//Solución:
namespace DeclaracionRenta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario que ingrese los valores trimestrales del año
            Console.WriteLine("Ingrese la renta del primer trimestre: ");
            double trimestre1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la renta del segundo trimestre: ");
            double trimestre2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la renta del tercer trimestre: ");
            double trimestre3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la renta del cuarto trimestre: ");
            double trimestre4 = double.Parse(Console.ReadLine());

            // Calcular la renta anual
            double rentaAnual = trimestre1 + trimestre2 + trimestre3 + trimestre4;

            // Calcular el impuesto a pagar
            double impuesto = 0;
            if (rentaAnual < 10000)
            {
                impuesto = rentaAnual * 0.05;
            }
            else if (rentaAnual < 20000)
            {
                impuesto = 500 + (rentaAnual - 10000) * 0.1;
            }
            else if (rentaAnual < 35000)
            {
                impuesto = 1500 + (rentaAnual - 20000) * 0.15;
            }
            else if (rentaAnual < 45000)
            {
                impuesto = 4500 + (rentaAnual - 35000) * 0.2;
            }
            else
            {
                impuesto = 8250 + (rentaAnual - 45000) * 0.3;
            }

            // Calcular el porcentaje de impuesto agregado
            double porcentajeImpuesto = impuesto / rentaAnual * 100;

            // Mostrar los resultados en pantalla
            Console.WriteLine("Renta anual: " + rentaAnual.ToString("C"));
            Console.WriteLine("Total de renta a pagar: " + impuesto.ToString("C"));
            Console.WriteLine("% de impuesto agregado: " + porcentajeImpuesto.ToString("F2") + "%");

            Console.ReadLine();
        }
    }
}


//Punto_2:

 
//Solución:


// namespace Juegos
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             string NombreComp;
//             int edad;
//             float precioEntrada=15000;
//             float descuento1=5;
//             float descuento2=3;
//             double precioCobrar;
//             double entrada=0;
//             string linea;

//             Console.WriteLine("Nombre  completo");
//             NombreComp=Console.ReadLine();
//             Console.WriteLine("Edad");
//             linea=Console.ReadLine();
//             edad=int.Parse(linea);

            


//             if ( edad<4) {
//                 precioCobrar = precioEntrada - precioEntrada;
//             }
//             else if (edad>=4 && edad<=18) {
//                 precioCobrar = precioEntrada * descuento1 / 100;
//                 entrada = precioEntrada - precioCobrar;
//             }
//             else {
//                 precioCobrar = precioEntrada * descuento2 /100;
//                 entrada = precioEntrada - precioCobrar;
//             }


            

//             Console.WriteLine("señor/a " + NombreComp + " el valor de su entrada es " + entrada + " y su descuneto fue de "+precioCobrar + "pesos");

//             Console.ReadKey();
//         }
//     }
// }

//Punto_3:

 
//Solución:

// class Program {
//     static void Main(string[] args) {
//         Console.WriteLine("Bienvenido a Pizzas el Fercho!");
//         Console.WriteLine("¿Qué tipo de pizza le gustaría? (V) Vegetariana o (NV) No vegetariana");
//         string tipoPizza = Console.ReadLine();
//         bool esVegetariana = false;

//         if (tipoPizza.ToLower() == "v") {
//             esVegetariana = true;
//         } else if (tipoPizza.ToLower() == "nv") {
//             esVegetariana = false;
//         } else {
//             Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
//             return;
//         }

//         Console.WriteLine("Ingredientes disponibles: ");

//         if (esVegetariana) {
//             Console.WriteLine("- Pimiento");
//             Console.WriteLine("- Champiñones");
//         } else {
//             Console.WriteLine("- Pepperoni");
//             Console.WriteLine("- Salami");
//             Console.WriteLine("- Pollo");
//         }

//         Console.WriteLine("Por favor, seleccione un ingrediente de la lista anterior: ");
//         string ingrediente = Console.ReadLine();

//         Console.WriteLine("\nLa pizza que ha elegido es: " + (esVegetariana ? "Vegetariana" : "No Vegetariana"));
//         Console.WriteLine("Ingredientes: ");
//         Console.WriteLine("- Mozzarella");
//         Console.WriteLine("- Tomate");
//         Console.WriteLine("- " + ingrediente);
//     }
// }



//Punto_4:

 
//Solución:


// namespace EvaluacionDeRendimiento
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Pedir al usuario que ingrese la puntuación del empleado
//             Console.WriteLine("Por favor, ingrese la puntuación del empleado (0.0 - 0.6): ");
//             double puntuacion = Convert.ToDouble(Console.ReadLine());

//             // Determinar el nivel de rendimiento del empleado basado en su puntuación
//             string nivel;
//             if (puntuacion == 0.0)
//             {
//                 nivel = "Inaceptable";
//             }
//             else if (puntuacion == 0.4)
//             {
//                 nivel = "Aceptable";
//             }
//             else if (puntuacion == 0.6)
//             {
//                 nivel = "Meritorio";
//             }
//             else
//             {
//                 nivel = "Puntuación inválida";
//             }

//             // Calcular la bonificación del empleado basado en su nivel de rendimiento
//             double bonificacion = 50000 * puntuacion;

//             // Imprimir los resultados
//             Console.WriteLine("El nivel de rendimiento del empleado es: " + nivel);
//             Console.WriteLine("La bonificación del empleado es: " + bonificacion.ToString("C"));
//         }
//     }
// }




