using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name, email, password;
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                email = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                password = Console.ReadLine();

                if(name.Length < 6)
                {
                    throw new CustomException("Name should have minimum 6 characters");
                }
                else if(password.Length < 8) 
                {
                    throw new CustomException("Password length should be of more than 8");
                }
                else
                {
                    Console.WriteLine("User Registration Success");
                    Console.WriteLine($"Name: {name} \nEmail: {email} \nPassword: {password}");
                }
            }
            catch(CustomException ce)
            {
                Console.WriteLine("Validation Exception!! "+ce.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!! "+ex.Message);
            }
            finally
            {
                Console.WriteLine("***End of Program***");
                Console.ReadKey();
            }
        }
    }
}
