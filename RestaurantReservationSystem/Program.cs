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
            string[] registeredUsers = new string[10] { "EDUARDO", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 1;
            string reservationCheck;
            string newRegister;
            string checkRegister;
            Console.WriteLine("Welcome to best restaurant in the World!");
            while (true)
            {
                Console.WriteLine("Are you already make your reservation? Y/N:");
                reservationCheck = Convert.ToString(Console.ReadLine());

                if (reservationCheck == "n" || reservationCheck == "N")
                {
                    Console.WriteLine("Type your name for making your reservation");
                    newRegister = Console.ReadLine();
                    registeredUsers[arrayCurrentIndex] = newRegister.ToUpper();
                    arrayCurrentIndex++;
                }
                else if (reservationCheck == "y" || reservationCheck == "Y")
                {
                    Console.WriteLine("Type your full name for you reservation");
                    checkRegister = Convert.ToString(Console.ReadLine());
                }
             }
        }
    }
}
