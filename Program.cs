using System;
using System.Linq.Expressions;

namespace Labo 
{
    public class UFG
    {
        public void Main(string[] args)
        {
            MenuPrincipal();
        }
        public static void MenuPrincipal()
        {
            int numero = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1. For");
                Console.WriteLine("2. While");
                Console.WriteLine("3. Do-While");
                Console.WriteLine("4. Salir");
                Console.Write("Digite una opción: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (numero)
                {
                    case 1:
                        ModuloFor();
                        break;
                    case 2:
                        ModuloWhile();
                        break;
                    case 3:
                        ModuloDoWhile();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        ModuloSalir();
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.WriteLine();
            } while (numero != 4);
        }
        public static void ModuloFor()
        {
            int numero = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Modulo For");
                Console.WriteLine("1. Promedio de ventas");
                Console.WriteLine("2. Muestra de mayusculas");
                Console.WriteLine("3. Regresar al menu principal");
                Console.Write("Digite una opción: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Ejecutando Promedio de ventas");
                        Modulo_For_1();
                        break;
                    case 2:
                        Console.WriteLine("Ejecutando Muestra de mayusculas");
                        Modulo_For_2();
                        break;
                    case 3:
                        Console.WriteLine("Regresando al menu principal...");
                        MenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.WriteLine();
            } while (numero != 3);
        }
        public static void ModuloWhile()
        {
            int numero = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Modulo While");
                Console.WriteLine("1. Pares del 1 al 100");
                Console.WriteLine("2. Los primeros 100");
                Console.WriteLine("3. Suma de positivos y negativos");
                Console.WriteLine("4. Lectura de caracteres");
                Console.WriteLine("5. Suma de numeros enteros");
                Console.WriteLine("6. Regresar al menu principal");
                Console.Write("Digite una opción: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Ejecutando Pares del 1 al 100...");
                        Modulo_While_1();
                        break;
                    case 2:
                        Console.WriteLine("Ejecutando Los primeros 100...");
                        Modulo_While_2();
                        break;
                    case 3:
                        Console.WriteLine("Ejecutando Suma de positivos y negativos...");
                        Modulo_While_3();
                        break;
                    case 4:
                        Console.WriteLine("Ejecutando Lectura de caracteres...");
                        Modulo_While_4();
                        break;
                    case 5:
                        Console.WriteLine("Ejecutando Suma de numeros enteros...");
                        Modulo_While_5();
                        break;
                    case 6:
                        Console.WriteLine("Regresando al menu principal...");
                        MenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.WriteLine();
            } while (numero != 6);

        }
        public static void ModuloDoWhile()
        {
            int numero = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Modulo Do-While");
                Console.WriteLine("1. Conteo de Mayusculas");
                Console.WriteLine("2. Suma de digitos");
                Console.WriteLine("3. Regresar al menu principal");
                Console.Write("Digite una opción: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Ejecutando Conteo de Mayusculas...");
                        Modulo_DoWhile_1();
                        break;
                    case 2:
                        Console.WriteLine("Ejecutando Suma de digitos...");
                        Modulo_DoWhile_2();
                        break;
                    case 3:
                        Console.WriteLine("Regresando al menu principal...");
                        MenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.WriteLine();
            } while (numero != 3);
        }
        public static void ModuloSalir()
        {
            Console.WriteLine();
            Console.WriteLine("Modulo For creado por RC100923");
            Console.WriteLine();
            Console.WriteLine("Modulo While creado por GG100923");
            Console.WriteLine();
            Console.WriteLine("Modulo Do-While creado por RM102323");
            Console.WriteLine();
        }
        public static void RegresarMenu()
        {
            while (true)
            {
                Console.WriteLine("Presiona 'Q' para salir:");
                char input = Console.ReadKey().KeyChar;

                // Verifica si el usuario ingresó el carácter especial 'Q'.
                if (input == 'Q' || input == 'q')
                {
                    Console.WriteLine("\n¡Módulo finalizado! Presiona cualquier tecla para salir.");
                    break; // Sale del bucle y finaliza el programa.
                }
            }
            // Espera a que el usuario presione una tecla antes de salir.
            Console.ReadKey();
        }
        public static void Modulo_For_1()
        {
            Console.Clear();
            string texto = "Modulo For #1";
            int AnchoCuadro = texto.Length + 4;
            string BordeSuperior = "+" + new string('-', AnchoCuadro - 2) + "+";
            string BordeMedio = $"| {texto} |";
            string BordeInferior = BordeSuperior;
            Console.WriteLine(BordeSuperior);
            Console.WriteLine(BordeMedio);
            Console.WriteLine(BordeInferior);
            Console.WriteLine("se calculara la venta de producto espepcificos");
            // solicitamos al usuario que ingrese el numero dias 
            Console.Write("Por Favor ingrese el número de días: ");
            int numDias = Convert.ToInt32(Console.ReadLine());
            while (numDias <= 0)
            {
                Console.WriteLine("El número de días debe ser mayor que 0. Por favor inténtalo de nuevo.");
                Console.Write("Por favor ingrese el número de días: ");
                numDias = Convert.ToInt32(Console.ReadLine());
            }
            // incluimos un arreglo para almacenar las ventas de cada día
            double[] ventasPorDia = new double[numDias];
            for (int i = 0; i < numDias; i++)
            {
                Console.Write($"Ingrese las ventas para el día {i + 1}: ");
                ventasPorDia[i] = Convert.ToDouble(Console.ReadLine());
            }
            // aqui calculamos el total de ventas y el promedio diario
            double totalVentas = 0;
            foreach (double ventasDia in ventasPorDia)
            {
                totalVentas += ventasDia;
            }
            double promedioDiario = totalVentas / numDias;
            // Mostrar resultados
            Console.WriteLine($"El total de ventas en {numDias} días es: {totalVentas}");
            Console.WriteLine($"El promedio diario de ventas es: {promedioDiario}");
            Console.WriteLine();
            Console.WriteLine("Código creado por RC100923");
            Console.WriteLine();
            RegresarMenu();
        }
        public static void Modulo_For_2()
        {
            Console.Clear();
            string texto = "Modulo For #1";
            int AnchoCuadro = texto.Length + 4;
            string BordeSuperior = "+" + new string('-', AnchoCuadro - 2) + "+";
            string BordeMedio = $"| {texto} |";
            string BordeInferior = BordeSuperior;
            Console.WriteLine(BordeSuperior);
            Console.WriteLine(BordeMedio);
            Console.WriteLine(BordeInferior);
            Console.WriteLine("Ingrese una cadena de texto:");
            string cadena = Console.ReadLine();
            Console.WriteLine("Las letras mayúsculas en la cadena son:");
            for (int i = 0; i < cadena.Length; i++)
            {
                char caracter = cadena[i];
                if (char.IsUpper(caracter))
                {
                    Console.Write(caracter);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Código creado por RC100923");
            Console.WriteLine();
            RegresarMenu();
        }
        public static void Modulo_While_1()
        {
            Console.Clear();
            string texto = "Modulo While #1";
            int AnchoCuadro = texto.Length + 4;
            string BordeSuperior = "+" + new string('-', AnchoCuadro - 2) + "+";
            string BordeMedio = $"| {texto} |";
            string BordeInferior = BordeSuperior;
            Console.WriteLine(BordeSuperior);
            Console.WriteLine(BordeMedio);
            Console.WriteLine(BordeInferior);
            Console.WriteLine();
            int i = 1;
            while (i <= 100)// inicializamos el metodo while
            {
                if (i % 2 == 0) // usuamos el modulo para sacar los numeros pares
                {
                    Console.WriteLine($"numero par {i} ");// hacemos la impresion solo de los numeros pares
                }
                i++;// incrementamos
            }
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("Código creado por GG100923");
            Console.WriteLine();
            RegresarMenu();
        }
        public static void Modulo_While_2()
        {
            Console.Clear();
            string texto = "Modulo While #2";
            int AnchoCuadro = texto.Length + 4;
            string BordeSuperior = "+" + new string('-', AnchoCuadro - 2) + "+";
            string BordeMedio = $"| {texto} |";
            string BordeInferior = BordeSuperior;
            Console.WriteLine(BordeSuperior);
            Console.WriteLine(BordeMedio);
            Console.WriteLine(BordeInferior);
            Console.WriteLine();
            int numeroI = 1;
            while (numeroI <= 100)//hacemos la evaluacion de que se el conteo de el 1 al 100
            {
                Console.WriteLine(numeroI); // imprimimos  los numeros
                numeroI++;
            }
            Console.WriteLine();
            Console.WriteLine("Código creado por GG100923");
            Console.WriteLine();
            RegresarMenu();
        }
        public static void Modulo_While_3()
        {
            Console.Clear();
            string texto = "Modulo While #3";
            int AnchoCuadro = texto.Length + 4;
            string BordeSuperior = "+" + new string('-', AnchoCuadro - 2) + "+";
            string BordeMedio = $"| {texto} |";
            string BordeInferior = BordeSuperior;
            Console.WriteLine(BordeSuperior);
            Console.WriteLine(BordeMedio);
            Console.WriteLine(BordeInferior);
            Console.WriteLine();
            Console.WriteLine();
            int numero;
            int sumaPositivos = 0;
            int sumaNegativos = 0;
            Console.WriteLine("Ingrese números enteros ( -999 para terminar):");
            //  un bucle while que se ejecuta mientras el usuario no ingrese -999
            while (true)
            {
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
                // Si el número ingresado es -999, salimos del bucle
                if (numero == -999)
                {
                    break;
                }
                // Si el número ingresado es positivo lo sumamos a la variable sumaPositivos
                if (numero > 0)
                {
                    sumaPositivos += numero;
                }
                // Si el número ingresado es negativo lo sumamos a la variable sumaNegativos
                else
                {
                    sumaNegativos += numero;
                }
            }
            // Mostramos la suma de los números positivos y negativos
            Console.WriteLine($"La suma de los números positivos es: {sumaPositivos}");
            Console.WriteLine($"La suma de los números negativos es: {sumaNegativos}");
            Console.WriteLine();
            Console.WriteLine("Código creado por GG100923");
            Console.WriteLine();
            RegresarMenu();
        }
        public static void Modulo_While_4()
        {
            Console.Clear();
            string texto = "Modulo While #4";
            int AnchoCuadro = texto.Length + 4;
            string BordeSuperior = "+" + new string('-', AnchoCuadro - 2) + "+";
            string BordeMedio = $"| {texto} |";
            string BordeInferior = BordeSuperior;
            Console.WriteLine(BordeSuperior);
            Console.WriteLine(BordeMedio);
            Console.WriteLine(BordeInferior);
            Console.WriteLine();
            char caracter;
            while (true)
            {
                Console.WriteLine("ingresa un caracter ");// pedimos que ingrese un caracter
                caracter = char.Parse(Console.ReadLine());
                if (caracter == '$') // hacemos la evaluacion para que termine el bucle al ingresar el caracter $
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Código creado por GG100923");
            Console.WriteLine();
            RegresarMenu();
        }
        public static void Modulo_While_5()
        {
            Console.Clear();
            string texto = "Modulo While #5";
            int AnchoCuadro = texto.Length + 4;
            string BordeSuperior = "+" + new string('-', AnchoCuadro - 2) + "+";
            string BordeMedio = $"| {texto} |";
            string BordeInferior = BordeSuperior;
            Console.WriteLine(BordeSuperior);
            Console.WriteLine(BordeMedio);
            Console.WriteLine(BordeInferior);
            Console.WriteLine();
            int numero;
            int sumaTotal = 0;
            while (true)
            {
                Console.WriteLine("Ingresa -999 para mostrar el resultado"); // le indicamos como  hacer para visualizar el resultado
                Console.WriteLine();
                Console.Write("Ingresa un numero entero: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (numero == -999) // indicamos que al ingresar -999 acabe el bucle
                {
                    break;
                }
                else
                {
                    sumaTotal += numero;// vamos haciendo la suma en cada iteracion
                }
            }
            Console.WriteLine("==================");
            Console.WriteLine("Suma total = " + sumaTotal);
            Console.WriteLine("==================");
            Console.WriteLine();
            Console.WriteLine("Código creado por GG100923");
            Console.WriteLine();
            RegresarMenu();
        }
        public static void Modulo_DoWhile_1()
        {
            Console.Clear();
            string texto = "Modulo Do-While #1";
            int AnchoCuadro = texto.Length + 4;
            string BordeSuperior = "+" + new string('-', AnchoCuadro - 2) + "+";
            string BordeMedio = $"| {texto} |";
            string BordeInferior = BordeSuperior;
            Console.WriteLine(BordeSuperior);
            Console.WriteLine(BordeMedio);
            Console.WriteLine(BordeInferior);
            Console.WriteLine();
            string palabra = ""; // Palabra ingresada por el usuario
            int mayusculas = 0; // Cantidad de letras mayúsculas
            do
            {
                Console.WriteLine("Digite '$' para finalizar el modulo.");
                Console.Write("Digite una palabra: ");
                palabra = Console.ReadLine(); // Leer la palabra
                Console.WriteLine();
                Console.WriteLine("===========================================");
                mayusculas = 0; // Reiniciar la cantidad de mayúsculas
                foreach (char letra in palabra) // Recorrer cada letra de la palabra
                {
                    if (char.IsUpper(letra)) // Si la letra es mayúscula
                    {
                        mayusculas++; // Incrementar la cantidad de mayúsculas
                    }
                }
                Console.WriteLine("Cantidad de letras mayúsculas: " + mayusculas); // Imprimir la cantidad de mayúsculas
                Console.WriteLine("===========================================");
                Console.WriteLine();
            } while (palabra != "$"); // Mientras la palabra sea diferente de $
            Console.WriteLine();
            Console.WriteLine("Código creado por RM102323");
            Console.WriteLine();
            RegresarMenu();
        }
        public static void Modulo_DoWhile_2()
        {
            Console.Clear();
            string texto = "Modulo Do-While #2";
            int AnchoCuadro = texto.Length + 4;
            string BordeSuperior = "+" + new string('-', AnchoCuadro - 2) + "+";
            string BordeMedio = $"| {texto} |";
            string BordeInferior = BordeSuperior;
            Console.WriteLine(BordeSuperior);
            Console.WriteLine(BordeMedio);
            Console.WriteLine(BordeInferior);
            Console.WriteLine();
            int numero = 0; // Número ingresado por el usuario
            int suma = 0; // Suma de los dígitos
            do
            {
                Console.Write("Digite un número entero: ");
                numero = int.Parse(Console.ReadLine()); // Leer el número
                Console.WriteLine();
                Console.WriteLine("===========================================");
                suma = 0; // Reiniciar la suma
                while (numero > 0) // Mientras el número sea mayor a 0
                {
                    suma += numero % 10; // Sumar el último dígito
                    numero /= 10; // Eliminar el último dígito
                }
                Console.WriteLine("La suma de los dígitos es: " + suma); // Imprimir la suma
                Console.WriteLine("===========================================");
            } while (numero != 0); // Mientras el número sea diferente de 0
            Console.WriteLine();
            Console.WriteLine("Código creado por RM102323");
            Console.WriteLine();
            RegresarMenu();
        }
    }
}
