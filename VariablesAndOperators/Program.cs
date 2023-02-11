/*
 * 1. Crea un algoritmo que pida al usuario su nombre, su DNI y fecha de nacimiento y a
continuación muestre esa información por pantalla de manera ordenada. Pej: Si el
usuario se llama Juan, su DNI es 56789123D y nació el 23/02/1998 se mostrará:
Nombre...............: Juan
DNI..................: 56789123D
Fecha de Nacimiento..: 23/02/1998
 */
using System.Text;

namespace variablesAndOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please write your name: ");
                string? name = Console.ReadLine();
                Console.Write("Please write your id: ");
                string? id = Console.ReadLine();
                Console.Write("Please enter your birth date(dd/mm/yyyy): ");
                string? userDate = Console.ReadLine();

                while ((userDate.Length == 0 || name.Length == 0 || id.Length == 0) || (name == null || id == null || userDate == null))
                {
                    if (name.Length == 0 || name == null)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("Please enter your name again");
                        name = Console.ReadLine();
                    }
                    else if (id.Length == 0 || id == null)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("Please enter id again");
                        id = Console.ReadLine();
                    }
                    else if (userDate.Length == 0 || userDate == null)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("Please enter your birth date(dd / mm / yyyy)");
                        userDate = Console.ReadLine();
                    }

                }
                DateOnly birhtDate = DateOnly.Parse(userDate);
                GetMessage(name, id, birhtDate);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("ERROR: The birth date format is incorrect. Please enter a date in the format dd/mm/yyyy");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(fe.Message);
                Console.ForegroundColor = ConsoleColor.White;
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
                throw;
            }

        }
        public static void GetMessage(string name, string id, DateOnly birthDate)
        {
            StringBuilder sp = new StringBuilder();
            sp.Append($"Name..........: {name}\n");
            sp.Append($"Id..........: {id}\n");
            sp.Append($"Birth Date..........: {birthDate}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sp.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
