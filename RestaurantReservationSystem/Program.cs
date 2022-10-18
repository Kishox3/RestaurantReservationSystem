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
            //   0       1   2   3   4   5   6   7   8   9
            string[] registeredUsers = new string[10] { "EDUARDO", "-table 2", "-table 3", "-table 4", "-table 5", "-table 6", "-table 7", "-table 8", "-table 9", "-table 10" };
            int arrayCurrentIndex = 1;
            string reservationCheck;
            string newRegister;
            string checkRegister;
            Console.WriteLine("Welcome to best restaurant in the World!");
            while (arrayCurrentIndex < 10)
            {
                Console.WriteLine("Are you already make your reservation? Y/N:");
                reservationCheck = Convert.ToString(Console.ReadLine());

                if (reservationCheck == "n" || reservationCheck == "N")
                {   
                    
                    Console.WriteLine("Type your name for making your reservation");
                    newRegister = Console.ReadLine();
                    registeredUsers[arrayCurrentIndex] = newRegister.ToUpper();
                    arrayCurrentIndex++;
                    Console.WriteLine("------------------------ \n Actual registration list: \n ------------------------");
                    for (int i = 0; i < registeredUsers.Length; i++)
                    {
                        Console.WriteLine(registeredUsers[i]);
                    }
                                  
                }
                else if (reservationCheck == "y" || reservationCheck == "Y")
                {
                    Console.WriteLine("Type your name for check you reservation");
                    checkRegister = Console.ReadLine();
                    for (int i = 0; i < registeredUsers.Length; i++)
                    {
                        if (registeredUsers[i].ToUpper() == checkRegister.ToUpper())
                        {
                            Console.WriteLine(registeredUsers[i] + " you already have the table #" + (i+1));
                        }
                    };
                }
             }
            Console.WriteLine("------------------------ \n There's no more tables available: \n ------------------------");
            for (int i = 0; i < registeredUsers.Length; i++)
            {
                Console.WriteLine(registeredUsers[i]);
            }
            Console.WriteLine("------------------------ \n Thank you for use our service \n ------------------------");
        }
    }
}
