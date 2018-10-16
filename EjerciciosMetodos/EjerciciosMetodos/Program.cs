using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMetodos
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //1)Diseña un método esPar() que reciba como parámetro un entero y devuelva si ese número es par o no. 
        //Utilízalo en un programa que lea un número por teclado y determine si es par o no.

        //Console.WriteLine("Escribe un número");
        //int num = Convert.ToInt32(Console.ReadLine());
        //esPar(num);
        //Console.ReadLine();

        //}
        //Diseñamos el método: TIENE QUE IR FUERA DE LA LLAVE DE MAIN Y SE SUELE PONER DEBAJO

        //public static void esPar(int numRecibido)
        //{
        //    if (numRecibido % 2 == 0) // no puedo poner num porque num está fuera de la llave
        //    {
        //        Console.WriteLine("Es Par");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Es impar");
        //    }

        //}
        //Sencillos:
        //Escribe una función que escriba “Hola” 3 veces.Llámala desde el programa principal.

        //static void Main(string[] args)
        //{
        //    esTresHola();
        //}
        //public static void esTresHola()
        //{
        //    Console.WriteLine("Hola");
        //    Console.WriteLine("Hola");
        //    Console.WriteLine("Hola");
        //    Console.ReadLine();
        //}

        //Escribe una función que escriba “Hola” tantas veces como el número que le pasamos de parámetro.
        //Llámala desde el programa principal dos veces, primero con 5 y después con 3.

        //static void Main(string[] args)
        //{
        //    VecesHola(5);   // llamo al método y le pido que me lo haga 5 veces
        //    VecesHola(3);

        //}
        //public static void VecesHola(int veces)// el parámetro de  VecesHola es veces
        //                                       // no puedo poner (int veces=5, int veces=3) porque tienen el
        //                                       // mismo nombre de variable
        //{
        //    for (int i = 0; i < veces; i++) // si pongo i<2 me lo escribe 2 veces, que no es lo que quiero, quiero que 
        //                                    // primero me lo escriba 5 veces y luego 3)
        //    {
        //        Console.WriteLine("Hola");
        //    }
        //    Console.ReadLine();
        //}
        //Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos.
        //Asigna el valor de llamar a la función en una variable en el programa principal y muestra el resultado
        //en la pantalla.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Escribe un número");
        //    int param1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Escribe un número");
        //    int param2 = Convert.ToInt32(Console.ReadLine());
        //    MetodoSuma(param1, param2); //lamo al método y le digo que sus parámetros son param1 y param2
        //    Console.ReadLine();
        //}
        //public static int MetodoSuma(int param1,int param2)   //como está fuera de la llave tengo que volver a 
        //decirle que tiene  2 parámetros
        //                                                   

        //{
        //    Console.WriteLine("la suma es: " + (param1 + param2));
        //    int suma = param1 + param2;
        //    return suma;
        //}

        // Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos.
        //En el programa principal, pide al usuario 2 números. 
        //Usa esos 2 números como parámetros de la función y después asigna el valor que devuelve la función
        //a una tercera variable en el programa. Finalmente, muestra el valor de la variable en la pantalla.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Escribe un número");
        //    int param1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Escribe un número");
        //    int param2 = Convert.ToInt32(Console.ReadLine());               
        //    int suma= MetodoSuma(param1,param2); // llamo al método y lo meto directamente en la variable suma
        //    Console.WriteLine(suma);
        //    Console.ReadLine();

        //}
        //public static int MetodoSuma(int param1, int param2)
        //{
        //    int suma = param1 + param2;
        //    return suma;
        //}

        //Escribe un programa que pida al usuario dos números. 
        //Usa esos 2 números en una función que divide el primero por el segundo y devuelve el resultado.
        //Muestra el resultado que devuelve la función en pantalla. 
        //Después vuelve a pedir los números y hacer todo otra vez hasta que el usuario introduzca un 0 
        //como segundo número.

        //static void Main(string[] args)
        //{
        //    int param2; // tengo que declarar esta variable fuera porque el while está fuera del loop
        //    double division;
        //    do
        //    {
        //        Console.WriteLine("Escribe un número");
        //        int param1 = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Escribe un número");
        //        param2 = Convert.ToInt32(Console.ReadLine());
        //        if (param2 != 0)// para que no me eche del programa hago que me entre en el método sólo si param2!=0
        //        {
        //            division = MetodoDivision(param1, param2); // llamo al método y lo meto directamente en la variable division
        //            Console.WriteLine("La división de los números es:" + division);
        //        }
        //    } while (param2 != 0);
        //    Console.WriteLine("El 0 no puede ser divisor");
        //   // Console.ReadLine();
        //}
        //public static double MetodoDivision(int param1, int param2)
        //{
        //    return param1*(1.0) / param2;
        //}

        //Escribe una función a la que le damos dos números y que devuelva true si el primer número es
        //más grande que el segundo número y false en el caso contrario.
        //En el programa principal, pide dos números al usuario, y pasalos a la función.
        //Muestra en pantalla “El primer número es más grande” o “El primer número no es más grande”.


        //static void Main(string[] args)
        //{
        //    bool mayor;

        //    Console.WriteLine("Escribe un número");
        //    int param1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Escribe un número");
        //    int param2 = Convert.ToInt32(Console.ReadLine());
        //    mayor = MetodoMayor(param1, param2);
        //    if (mayor)
        //    {

        //        Console.WriteLine("El primer número es más grande");
        //    }
        //    else
        //    {
        //        Console.WriteLine("El primer número no es más grande");
        //    }
        //    Console.ReadLine();

        //}
        //public static bool MetodoMayor(int param1, int param2) // 
        //{
        //    return param1 > param2;// no es necesario lo siguiente porque es una condición lógica
        //                            //if (param1 > param2)
        //                            //{
        //                            //    return true;
        //                            //}
        //                            //else
        //                            //{
        //                            //    return false;
        //                            //}

        //}

        //Escribe una función a la que le pasamos un año y devuelve true si es bisiesto.
        //En el programa principal, pídele al usuario un número y muestra en pantalla “El año … es bisiesto” o
        //“El año … no es bisiesto” y sigue pidiendo números y diciendo si es o no bisiesto hasta que
        //introduzca un 0.

        //static void Main(string[] args)
        //{
        //    int year;
        //    do
        //    {
        //        Console.WriteLine("Escribe un año");
        //        year = Convert.ToInt32(Console.ReadLine());
        //        if (year != 0)// se pone aquí porque el 0 no hay que evaluarlo, directamente sale pasaría al while
        //        {
        //            if (EsBisiesto(year))
        //            {
        //                Console.WriteLine(year + " es bisiesto");
        //            }
        //            else
        //            {
        //                Console.WriteLine(year + " no es bisiesto");
        //            }
        //        }
        //    } while (year != 0);

        //    Console.ReadKey();
        //}


        //public static bool EsBisiesto(int year)
        //{
        //    return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        //}
        //    //if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        //    //{
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    return false;
        //    //}

        //Escribe una función que reciba un array y lo muestre en pantalla de modo ascendente.
        //Después escribe otra función que reciba un array y lo muestre en pantalla de modo descendencte.
        //Crea un array en el programa principal y pásalo a cada una de las funciones.

        //static void Main(string[] args)
        //{
        //int[] array = { 9, 6, 4, 25, 2, 0 };
        ////int ascendente = MetodoAscendente();
        //MetodoAscendente(array);
        ////int descendente = MetodoDescendente();
        //MetodoDescendente(array);
        //}


        //public static void MetodoAscendente(int[] array)
        //{
        //    Array.Sort(array);//Esto ya me ordena el array

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(array[i]+ ", ");                                
        //    }
        //    Console.ReadLine();
        //}

        //public static void MetodoDescendente(int[] array)
        //{
        //    Array.Sort(array);//Esto ya me ordena el array

        //    for (int i = array.Length-1; i >= 0; i--)// el -1 por el tema de la posición, 
        //                                            //mientras i sea mayor que 0
        //    {
        //        Console.Write(array[i] + ", ");
        //    }
        //    Console.ReadLine();
        //}

        //Escriba una función que reciba un array y un valor booleano.
        //Si el booleano es true, mostrar el array de modo ascendente,
        //si es false, mostrarlo de modo descendente. 
        //En el programa principal, crear un array y hacer que la función lo muestre 
        //primero en modo ascendente y después en modo descendente.

        //static void Main(string[] args)
        //{
        //    bool valor=true;// cambio el valor yo para comprobar si funciona
        //    int[] array = { 9, 6, 4, 25, 2, 0 };
        //    if (valor == true)
        //    {
        //        Ascendente(array);
        //    }
        //    else
        //    {
        //        Descendente(array);
        //    }
        //    Console.ReadLine();            
        //}
        //public static void Ascendente(int[] array)
        //{
        //    Array.Sort(array);//Esto ya me ordena el array

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(array[i] + ", ");
        //    }

        //}
        //public static void Descendente(int[] array)
        //{
        //    Array.Sort(array);//Esto ya me ordena el array

        //    for (int i = array.Length -1; i >=0 ; i--)
        //    {
        //        Console.Write(array[i] + ", ");
        //    }
        //    Console.ReadLine();
        //}







        //10) Diseña  un  método  pedirMes().  Solicita  un  número  de  mes  y  valida  que  se  trata 
        // de  un número de mes correcto. Devuelve dicho número de mes. 
        //Diseña un método PedirAnio(). Recibe como parámetros los límites entre los que debe de estar el año
        //que se debe solicitar por teclado. Devuelve el año aleatorio entre dichos límites. 
        //Validar que el límite máximo sea mayor que el límite mínimo y en caso contrario, cambiarles el valor.
        //Diseña un método pedirDia(). Solicita un número de día por teclado, y dado un mes y un año válidos  
        //recibidos por  parámetro, devuelve un  día correcto.  (Nota:  puede llamar  al método esBisiesto)
        //Crea un nuevo método mostrarSiguienteDia() que recibe un día, un mes y un año válido(estos tres datos forman la
        //fecha actual) y muestra en pantalla 2 fechas: la actual y la del día siguiente, a calcular a partir del día actual.
        //Pruébalo en  un programa  que pida  al usuario  una fecha(pedirDia(), pedirMes(), pedirAnio()) y 
        //muestre la fecha del día siguiente.

        static void Main(string[] args)
        {
            int mes = PedirMes();
            Console.WriteLine("Introduce un año");
            int limSup = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro año");
            int limInf = Convert.ToInt32(Console.ReadLine());
            int anio = PedirAnio(limInf, limSup);
            Console.ReadLine();
            int dia = PedirDia(anio, mes);
            bool bisiesto = EsBisiesto(anio);
        }
        public static int PedirMes() //MÉTODO PEDIR MES
        {
            int mes;
            do
            {
                Console.WriteLine("Escribe un mes del 1 al 12");
                mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(mes);
            } while (mes < 1 || mes > 12);// ESTA ES LA CONDICIÓN QUE NO SE CUMPLE
            return mes;
        }
        public static int PedirAnio(int limInf, int limSup) //METODO PEDIR ANIO
        {
                int anio, traspuesto;

        Random rnd = new Random();// instanciamos la clase random
                if (limSup>limInf)
                {
                     anio = rnd.Next(limInf, limSup+1); //le sumamos 1 porque si no no nos coge el limSup
                     return anio; 
                }
                else 
                {
                    traspuesto = limSup; // Validar que el límite máximo sea mayor que el límite mínimo 
                                         //y en caso contrario, cambiarles el valor
                    limSup = limInf;
                    limInf = traspuesto;
                    anio = rnd.Next(limInf, limSup + 1);
                    return anio;                
                }
        }     
        public static int PedirDia(int anio, int mes) //METODO PEDIR DIA
        {
            EsBisiesto(anio);
            int dia;
            bool bisiesto = false; //me comprueba si el dia es correcto o incorrecto
            do
            {
                Console.WriteLine("Escribe un día del 1 al 31");
                dia = Convert.ToInt32(Console.ReadLine());
                if ((mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes == 12))
                {
                    if ((dia >= 1) && (dia <= 31))
                    {
                        return dia;
                    }
                    else
                    {
                        Console.WriteLine("El día no es correcto");
                    }
                }
                if ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))
                {
                    if ((dia >= 1) && (dia <= 30))
                    {
                        return dia;
                    }
                    else
                    {
                        Console.WriteLine("El día no es correcto");
                    }
                }
                if (bisiesto && mes == 2)
                {
                    if ((dia >= 1) && (dia <= 29))
                    {
                        bisiesto = true;
                    }
                }
                if ((dia >= 1) && (dia <= 28))
                {
                    return dia;
                }
                else
                {
                    Console.WriteLine("El día no es correcto");
                }
            } while (!bisiesto);
        }
        public static bool EsBisiesto(int anio)
        {
            bool bisiesto = true;
            if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0) //es bisiesto?
            {
                Console.WriteLine("El año es bisiesto");
                return bisiesto;
            }
            else
            {
                Console.WriteLine("El año  no es bisiesto");
                return false;
            }
        }
    }
}


        //SOLUCION ARRATE
        // static void Main(string[] args)
        //    {
        //        int month, year, day, maxYear, minYear;

        //    //Generamos un mes
        //    month = AskMonth();

        //    //Generamos un año
        //    Console.WriteLine("Introduce un límite mínimo:");
        //        minYear= Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Introduce un límite máximo:");
        //        maxYear = Convert.ToInt32(Console.ReadLine());
        //        year = AskYear(minYear, maxYear);

        //    //Generamos día
        //    day = AskDay(month, year);

        //    //Generamos el día siguiente
        //    NextDay(day, month, year);


        //}
        //public static void NextDay(int day, int month, int year)
        //{
        //    Console.WriteLine("Fecha actual: " + day + "/" + month + "/" + year);

        //    if (DateTime.IsLeapYear(year) && month == 2 && day == 29)
        //    {
        //        month++;
        //        day = 1;

        //    }
        //    else if (!DateTime.IsLeapYear(year) && month == 2 && day == 28)
        //    {
        //        month++;
        //        day = 1;
        //    }
        //    else if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 30)
        //    {
        //        month++;
        //        day = 1;
        //    }
        //    else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 31)
        //    {
        //        month++;
        //        day = 1;
        //    }
        //    else if (month == 12 && day == 31)
        //    {
        //        year++;
        //        month = 1;
        //        day = 1;
        //    }
        //    else
        //    {
        //        day++;
        //    }
        //    Console.WriteLine("Fecha día siguiente: " + day + "/" + month + "/" + year);
        //    Console.ReadLine();
        //}

        //public static int AskDay(int month, int year)
        //{
        //    int day;
        //    bool correcto = false;
        //    do
        //    {
        //        Console.WriteLine("Introduce un día");
        //        day = Convert.ToInt32(Console.ReadLine());

        //        if (DateTime.IsLeapYear(year) && month == 2)
        //        {
        //            if (day > 0 && day < 30)
        //            {
        //                correcto = true;
        //            }
        //        }
        //        else if (!DateTime.IsLeapYear(year) && month == 2)
        //        {

        //            if (day > 0 && day < 29)
        //            {
        //                correcto = true;
        //            }
        //        }
        //        else if (month == 4 || month == 6 || month == 9 || month == 11)
        //        {
        //            if (day > 0 && day < 31)
        //            {
        //                correcto = true;
        //            }
        //        }
        //        else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        //        {
        //            if (day > 0 && day < 32)
        //            {
        //                correcto = true;
        //            }
        //        }

        //    } while (!correcto);

        //    return day;
        //}


        //public static int AskMonth()
        //{
        //    int month;
        //    do
        //    {
        //        Console.WriteLine("Introduce un mes");
        //        month = Convert.ToInt32(Console.ReadLine());

        //    } while (month < 1 || month > 12);

        //    return month;
        //}

        //public static int AskYear(int minYear, int maxYear)
        //{
        //    int aux, year;
        //    Random rnd = new Random();

        //    if (minYear > maxYear)
        //    {
        //        //Creo la variable auxiliar para guardar el valor de minYear para que
        //        //cuando lo cambie no se pierda
        //        aux = minYear;
        //        minYear = maxYear;
        //        maxYear = aux;
        //        year = rnd.Next(minYear, maxYear + 1);
        //        return year;
        //    }
        //    else
        //    {
        //        year = rnd.Next(minYear, maxYear + 1);
        //        return year;
    





