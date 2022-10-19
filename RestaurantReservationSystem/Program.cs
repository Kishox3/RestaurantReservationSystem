/*Instrucciones:
 * 1. Validar si es usuario existe o si se debe registrar
 * 2. Dar bievenida a usuario existente
 * 3. Debe repetirse hasta que se llenen las 10 reservaciones
 */
using System;
namespace RestaurantReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] registeredUsers = new string[10] { "EDUARDO", "#2 [EMPTY]", "#3 [EMPTY]", "#4 [EMPTY]", "#5 [EMPTY]", "#6 [EMPTY]", "#7 [EMPTY]", "#8 [EMPTY]", "#9 [EMPTY]", "#10 [EMPTY]" }; //LISTA DE MESAS DISPONIBLES
            int arrayCurrentIndex = 1;   
            string reservationCheck;     
            string newRegister;          
            string checkRegister;        
            Console.WriteLine("Welcome to Xion Restaurant | Table Registration System"); 
            while (arrayCurrentIndex < 10) //define el registro por secuencia y la finalizacion del programa
            {
                Console.WriteLine("Type [ 1 ] for making a reservation\nType [ 2 ] for check a reservation\nType [ 3 ] to see the actual registration list");
                reservationCheck = Convert.ToString(Console.ReadLine());
                if (reservationCheck == "1")  //OPCION DE REGISTRO
                {
                    Console.WriteLine("Type your name for making your reservation");
                    newRegister = Console.ReadLine();
                    int checkN = Array.IndexOf(registeredUsers, newRegister.ToUpper());
                    if (checkN >= 0) //VERIFICACION DE QUE NO EXISTA UNA RESERVA YA HECHA CON ESE NOMBRE
                    {
                        Console.WriteLine("Already exist a registration with the name " + registeredUsers[checkN] + " on table #" + (checkN+1) + "\nTry a new registration with other name");
                    }
                    else  //SI NO EXISTE SE RESERVA LA MESA
                    {
                        registeredUsers[arrayCurrentIndex] = newRegister.ToUpper();
                        arrayCurrentIndex++;
                        Console.WriteLine("Registration complete! You have the table #" + (checkN+1));
                    }
                }
                else if (reservationCheck == "2")
                {
                    Console.WriteLine("Type your name for check you reservation"); //VERIFICACION DE MESA SEGUN NOMBRE
                    checkRegister = Console.ReadLine();
                    int checkR = Array.IndexOf(registeredUsers, checkRegister.ToUpper());
                    if (checkR >= 0)
                    {
                        Console.WriteLine(registeredUsers[checkR] + " you already have the table #" + (checkR+1));
                    }
                }
                else if (reservationCheck == "3") //DESPLIEGUE DE LISTA COMPLETA DE RESERVACIONES
                {                    
                    string password = "Pa$$word1234";
                    Console.WriteLine("Authorized Personnel Only - Please enter a password: ");
                    string passCheck = Console.ReadLine();
                    if (passCheck == password)
                    {
                        Console.WriteLine("------------------------ \n Actual registration list: \n ------------------------");
                        for (int i = 0; i < registeredUsers.Length; i++)
                        {
                            Console.WriteLine(registeredUsers[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password, Authorized Personnel Only");
                    }                    
                }
                else
                {
                    Console.WriteLine("Incorrect option, type [ 1 ] , [ 2 ] , or [ 3 ] without spaces");
                }
             }
            //CUANDO SE ACABAN LAS MESAS SE DESPLIEGA ESTE MENSAJE Y SE TERMINA EL PROGRAMA
            Console.WriteLine("------------------------ \n There's no more tables available: \n ------------------------");
            for (int i = 0; i < registeredUsers.Length; i++)
            {
                Console.WriteLine(registeredUsers[i]);
            }
            Console.WriteLine("------------------------ \n Thank you for use our service \n ------------------------");
        }
    }
}
/*version v1.1
 * SE ME OCURRE AGREGAR EN ALGUNA VERSION FUTURA:
-Eleccion de # mesa a la hora de hacer el registro (habria que cambiar la verificacion de nombre) de momento no se puede registar varias mesas a nombre de una sola persona y tampoc se puede elegir la mesa
-Cancelacion de registro de mesa
-Edicion de nombre o # de mesa
*/
