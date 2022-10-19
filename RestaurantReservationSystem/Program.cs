using System;

/*Instrucciones:
 * 1. Validar si es usuario existe o si se debe registrar
 * 2. Dar bievenida a usuario existente
 * 3. Debe repetirse hasta que se llenen las 10 reservaciones
 */


namespace RestaurantReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] registeredUsers = new string[10] { "EDUARDO", "-table 2", "-table 3", "-table 4", "-table 5", "-table 6", "-table 7", "-table 8", "-table 9", "-table 10" }; //LISTA DE MESAS DISPONIBLES
            int arrayCurrentIndex = 1;
            string reservationCheck;
            string newRegister;
            string checkRegister;
            Console.WriteLine("Welcome to best restaurant in the World!");
            while (arrayCurrentIndex < 10)
            {
                Console.WriteLine("Type [ 1 ] for making a reservation\nType [ 2 ] for check a reservation\nType [ 3 ] to see the actual registration list");
                reservationCheck = Convert.ToString(Console.ReadLine());

                if (reservationCheck == "1")  //OPCION DE REGISTRO
                {   
                    
                    Console.WriteLine("Type your name for making your reservation");
                    newRegister = Console.ReadLine();
                    for (int i = 0; i < registeredUsers.Length; i++)
                    {
                        if (registeredUsers[i].ToUpper() == newRegister.ToUpper()) //VERIFICACION DE QUE NO EXISTA UNA RESERVA YA HECHA CON ESE NOMBRE
                        {
                            Console.WriteLine("Already exist a registration with the name " + newRegister.ToUpper() + " on table #" + (i+1) + "\nTry a new registration with other name");
                            break;
                        }
                        else  //SI NO EXISTE SE RESERVA LA MESA
                        {
                            registeredUsers[arrayCurrentIndex] = newRegister.ToUpper();
                            arrayCurrentIndex++;
                            Console.WriteLine("Registration complete! You have the table #" + (i+1));
                            break;
                        }
                    };            
                }
                else if (reservationCheck == "2")
                {
                    Console.WriteLine("Type your name for check you reservation"); //VERIFICACION DE MESA SEGUN NOMBRE
                    checkRegister = Console.ReadLine();
                    for (int i = 0; i < registeredUsers.Length; i++)
                    {
                        if (registeredUsers[i].ToUpper() == checkRegister.ToUpper())
                        {
                            Console.WriteLine(registeredUsers[i] + " you already have the table #" + (i+1));
                            break;
                        }
                    };
                }
                else if (reservationCheck == "3") //DESPLIEGUE DE LISTA COMPLETA DE RESERVACIONES
                {
                    Console.WriteLine("------------------------ \n Actual registration list: \n ------------------------");
                    for (int i = 0; i < registeredUsers.Length; i++)
                    {
                        Console.WriteLine(registeredUsers[i]);
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

/*SE ME OCURRE AGREGAR EN ALGUNA VERSION FUTURA:
-Eleccion de # mesa a la hora de hacer el registro (habria que cambiar la verificacion de nombre) de momento no se puede registar varias mesas a nombre de una sola persona y tampoc se puede elegir la mesa
-Cancelacion de registro de mesa
-Edicion de nombre o # de mesa
*/
