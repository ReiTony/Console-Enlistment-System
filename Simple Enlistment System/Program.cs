using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2
{
    class User
    {
        // Structure was used so that I can easily manage and reference my array.
        struct UserDetails
        {
            public string firstName;
            public string lastName;
            public string username;
            public string password;
            public string email;
            public int houseNo;
            public string street;
            public string brgy;
            public string city;
            public int zipCode;
        }; UserDetails[] us = new UserDetails[10]; //create an array that store UserDetails
        int index = 1;


        // SignUp Section For New Users
        public void SignUp()
        {
            bool stay = true;
            // Used to return back to menu if false
            while (stay)
            {
                for (int i = 1; i <= 1; i++)
                {
                    char choice;

                    Console.WriteLine("-------------");
                    Console.WriteLine("|Sign Up Now|");
                    Console.WriteLine("-------------");

                    Console.Write("Enter your username: ");
                    us[index].username = Console.ReadLine();

                    redo:
                    Console.Write("Enter your password: ");
                    us[index].password = Console.ReadLine();

                    if (us[i].password.Any(char.IsUpper) ||
                        us[i].password.Any(char.IsDigit))
                    {
                        Console.WriteLine("Password Strength: Strong");
                    }
                    else
                    {
                        Console.WriteLine("Password Strength: Weak");
                        redo2:
                        Console.Write("Would you like try again ? (Y or N): ");
                        choice = Console.ReadKey().KeyChar;
                        if (choice == 'Y' || choice == 'y')
                        {
                            Console.WriteLine("");
                            goto redo;
                        }
                        else if (choice == 'N' || choice == 'n')
                        {
                            Console.WriteLine("");
                            goto again;
                        }
                        else if (choice != 'N' || choice != 'n' || choice != 'Y' || choice != 'y')
                        {
                            Console.WriteLine("\nInvalid Input! Y or N only!");
                            goto redo2;
                        }
                        Console.WriteLine("");
                    }
                    again:
                    Console.Write("Confirm Password: ");
                    string confirmPass = Console.ReadLine();
                    if (confirmPass != us[i].password)
                    {
                        Console.WriteLine("Password doesn't match, Please try again");
                        Console.WriteLine(" ");
                        goto again;
                    }
                    else
                    {
                        Console.WriteLine("\n-----------------------------------");
                        Console.WriteLine("|Next Step! Enter Personal Details|");
                        Console.WriteLine("-----------------------------------");
                        Console.Write("Enter your first name: ");
                        us[index].firstName = Console.ReadLine();

                        Console.Write("Enter your last name: ");
                        us[index].lastName = Console.ReadLine();

                        Console.Write("Enter your email: ");
                        us[index].email = Console.ReadLine();

                        Console.WriteLine("\n-------------------------------");
                        Console.WriteLine("|Next Step! Enter Your Address|");
                        Console.WriteLine("-------------------------------");

                        Console.Write("Enter your House No.: ");
                        us[index].houseNo = int.Parse(Console.ReadLine());
                        Console.Write("Enter your street: ");
                        us[index].street = Console.ReadLine();
                        Console.Write("Enter your barangay: ");
                        us[index].brgy = Console.ReadLine();
                        Console.Write("Enter your city: ");
                        us[index].city = Console.ReadLine();
                        Console.Write("Enter your zipcode: ");
                        us[index].zipCode = int.Parse(Console.ReadLine());

                        Console.WriteLine("\n------------------------");
                        Console.WriteLine("|User Has Been Created!|");
                        Console.WriteLine("------------------------");
                        Console.WriteLine("\nReturning to Main Menu" +
                            "\nPress Any Key to continue...");
                        Console.ReadKey();
                        stay = false;
                    }
                    //So That index wont stay at 1
                    index++;
                }

            }
        }

        // After SignUp, Login Can Be Used
        public void Login()
        {
            bool stay = true;
            char choice;
            char choice1;
            for (int i = 1; i <= 1; i++)
            {
                // Used to return back to menu if false
                while (stay)
                {
                    redo1:
                    Console.Write("Username: ");
                    string uname = Console.ReadLine();
                    if (uname != us[i].username)
                    {

                     Console.WriteLine("Username Doesn't Exist, Try Again?");
                        redo2:
                         Console.Write("Y or N: ");
                         choice = Console.ReadKey().KeyChar;
                         if (choice == 'N' || choice == 'n')
                         {
                            break;
                         }

                         else if (choice == 'Y' || choice == 'y')
                         {
                             Console.WriteLine("");
                             goto redo1;                           
                         }

                         else if (choice != 'N' || choice != 'n' || choice != 'Y' || choice != 'y')
                         {
                             Console.WriteLine("\nInvalid Input! Y or N only!");
                             goto redo2;
                         } 
                    }

                    redo3:
                    Console.Write("Password: ");
                    string pass = Console.ReadLine();
                    if (pass != us[i].password)
                    {
                        Console.WriteLine("Invalid Password");
                        redo4:
                        Console.Write("Try Again (Y or N): ");
                        choice1 = Console.ReadKey().KeyChar;
                        if (choice1 == 'N' || choice1 == 'n')
                        {
                            break;
                        }
                        else if (choice1 == 'Y' || choice1 == 'y')
                        {
                            Console.WriteLine(" ");
                            goto redo3;
                        }
                        else if (choice1 != 'N' || choice1 != 'n' || choice1 != 'Y' || choice1 != 'y')
                        {
                            Console.WriteLine("\nInvalid Input! Y or N only!");
                            goto redo4;
                        }
                    }
                    else
                    {
                        // Prints Out The Users Detail
                        Console.Clear();
                        i = 1;
                        for (int k = i; k <= 1; k++)
                        {
                            Console.WriteLine("\n------------------------------");
                            Console.WriteLine("|Welcome Back! To Your Account|");
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("First Name: " + us[i].firstName);
                            Console.WriteLine("Last Name: " + us[i].lastName);
                            Console.WriteLine("Address: " + us[i].houseNo + " " + us[i].street + " St.," 
                             + " Brgy., " + us[i].brgy + " " + us[i].city + " " + us[i].zipCode);
                            Console.WriteLine("email: " + us[i].email); 
                            Console.WriteLine("\nTo Logout" +
                            "\nPress Any Key to continue...");
                            Console.ReadKey();
                            stay = false;
                        }
                    }
                }                
            }
        }
        // Used to change pass if forgotten, Only Works if email is Existing
        public void ForgotPassword()
        {
            bool stay = true;
            char choice;
            // Used to return back to menu if false
            while (stay)
            {
                redo1:
                Console.Write("Please Enter Email: ");
                string em = Console.ReadLine();
                for (int i = 1; i <= 10; i++)
                {
                    if (us[i].email == em)
                    {
                        redo2:
                        Console.Write("Enter your new password: ");
                        us[i].password = Console.ReadLine();

                        if (us[i].password.Any(char.IsUpper) ||
                            us[i].password.Any(char.IsDigit))
                        {
                            Console.WriteLine("Password Strength: Strong");
                        }
                        else
                        {
                            Console.WriteLine("Password Strength: Weak");
                            redo4:
                            Console.Write("Would you like try again ? (Y or N): ");
                            choice = Console.ReadKey().KeyChar;
                            if (choice == 'N' || choice == 'n')
                            {
                                Console.WriteLine("");
                                goto again;
                            }
                            else if (choice == 'Y' || choice == 'y')
                            {
                                Console.WriteLine("");
                                goto redo2;
                            }
                            else if (choice != 'N' || choice != 'n' || choice != 'Y' || choice != 'y')
                            {
                                Console.WriteLine("\nInvalid Input! Y or N only!");
                                goto redo4;
                            }
                        }
                        again:
                        Console.Write("Confirm Password: ");
                        string confirmPass = Console.ReadLine();
                        if (confirmPass != us[i].password)
                        {
                            Console.WriteLine("Password doesn't match, Please try again");
                            Console.WriteLine(" ");
                            goto again;
                        }
                        else
                        {
                            Console.WriteLine("\nPassword Changed!");
                            Console.WriteLine(us[i].password);
                            Console.WriteLine("Returning to Main Menu");
                            Console.WriteLine("Press Any Key....");
                            Console.ReadKey();
                            return;
                        }
                    }
                    else if (us[i].email != em)
                    {
                        Console.WriteLine("Email Doesn't Exist, Try Again?");
                        redo3:
                        Console.Write("Y or N: ");
                        char choice1 = Console.ReadKey().KeyChar;
                        if (choice1 == 'N' || choice1 == 'n')
                        {
                            return;
                        }
                        else if (choice1 == 'Y' || choice1 == 'y')
                        {
                            Console.WriteLine("");
                            goto redo1;
                        }
                        else if (choice1 != 'N' || choice1 != 'n' || choice1 != 'Y' || choice1 != 'y')
                        {
                            Console.WriteLine("\nInvalid Input! Y or N only!");
                            goto redo3;
                        }
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                User user = new User();
                int choice;
                bool repeatAll = true;
                string y;
                do
                {
                    //The Menu
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t========== Welcome to CIIT ==========" + "\n\n");
                    Console.WriteLine("1. Sign Up");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Forgot Password");
                    Console.WriteLine("4. Exit" + "\n\n");
                    Console.Write("Enter Your Choice: ");
                    choice = Console.Read();
                    y = Console.ReadLine();


                    switch (choice)
                    {
                        case '1':
                            Console.Clear();
                            user.SignUp();
                            break;

                        case '2':
                            Console.Clear();
                            user.Login();
                            break;

                        case '3':
                            Console.Clear();
                            user.ForgotPassword();
                            break;

                        case '4':
                            Console.Clear();
                            Console.WriteLine("Thank you for using" + "\n We hope to see you again!");
                            repeatAll = false; //stop looping if false
                            break;
                    }
                } while (repeatAll) ;
            }
        }
}

