namespace Five_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int ch;
                Console.WriteLine("*****||The Five Different Star Patterns Printing Program||*****");
                Console.WriteLine(" Press: 1 For Printing Star Diamond Pattern Program");
                Console.WriteLine(" Press: 2 For Printing Double Star ButterFly Pattern Program");
                Console.WriteLine(" Press: 3 For Printing Hollow Star Square Pattern Program");
                Console.WriteLine(" Press: 4 For Printing Symmetric Star Heart Pattern Program");
                Console.WriteLine(" Press: 5 For Printing Star Hourglass Pattern Program");
                Console.WriteLine(" Press: 6 For Clearing Previous Output of the Program");
                Console.WriteLine(" Press: 7 For Exit the Program");
                if (!int.TryParse(Console.ReadLine(), out ch))
                {
                    Console.WriteLine("You have Enter The Invalid Input");
                    Console.WriteLine("Enter the Valid Option");
                }
                else
                {
                    switch (ch)
                    {
                        case 1:
                            D_P();
                            break;
                        case 2:
                            D_B_P();
                            break;
                        case 3:
                            H_S_P();
                            break;
                        case 4:
                            S_H_P();
                            break;
                        case 5:
                            Ho_P();
                            break;
                        case 6:
                            Console.Clear();
                            break;
                        case 7:
                            return;
                        default:
                            Console.WriteLine("You have enter the Invalid Option");
                            break;
                    }
                }

            }
        }
        static void D_P()
        {
            int n;
            Console.WriteLine("Star Diamond Pattern Program");
            Console.WriteLine("Enter the number of rows up to where you want to view(Enter Positive Even Number of Rows Only)");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n % 2 == 1)
            {
                Console.WriteLine("You have Enter The Invalid Input");
                Console.WriteLine("Enter the Valid Option");
            }
            else
            {
                int i, a1 = n / 2 - 1, a2 = 0, a3 = 0, a4 = n - 2;
                for (i = 0; i <= n; i++)
                {
                    if (i >= 0 && i <= n / 2)
                    {
                        for (int k = 0; k <= a1; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= a2; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        a1--;
                        a2 += 2;
                    }
                    else
                    {
                        for (int k = 0; k <= a3; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= a4; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        a3++;
                        a4 -= 2;
                    }
                }
            }

        }
        static void D_B_P()
        {
            int n;
            Console.WriteLine("Double Star ButterFly Pattern Program");
            Console.WriteLine("Enter the number of rows up to where you want to view(Enter Positive Odd Number of Rows Only)");

            if (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n % 2 == 0)
            {
                Console.WriteLine("You have Enter The Invalid Input");
                Console.WriteLine("Enter the Valid Option");
            }
            else
            {
                int i, a1 = 0, a2 = n - 2, a3 = 0, a4 = n / 2, a5 = -1, a6 = n / 2;
                for (i = 0; i <= n; i++)
                {
                    if (i <= n / 2)
                    {
                        for (int j = 0; j <= a1; j++)
                        {
                            Console.Write("*");
                        }
                        for (int k = 0; k <= a2; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int l = 0; l <= a3; l++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        a1++;
                        a2 -= 2;
                        a3++;
                    }
                    else
                    {
                        for (int j = 0; j <= a4; j++)
                        {
                            Console.Write("*");
                        }
                        for (int k = 0; k <= a5; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int l = 0; l <= a6; l++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        a4--;
                        a5 += 2;
                        a6--;
                    }
                }
            }

        }
        static void H_S_P()
        {
            int n;
            Console.WriteLine("Hollow Star Square Printing Program");
            Console.WriteLine("Enter the number of rows up to where you want to view(Enter Positive Odd Number of Rows Only)");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n % 2 == 0)
            {
                Console.WriteLine("You have Enter The Invalid Input");
                Console.WriteLine("Enter the Valid Option");
            }
            else
            {
                int i;
                for (i = 0; i <= n; i++)
                {
                    if (i == 0 || i == n)
                    {
                        for (int j = 0; j <= n; j++)
                        {
                            Console.Write(" * ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int j = 0; j <= 0; j++)
                        {
                            Console.Write(" * ");
                        }
                        for (int k = 0; k <= n - 2; k++)
                        {
                            Console.Write("   ");
                        }
                        for (int l = 0; l <= 0; l++)
                        {
                            Console.Write(" * ");
                        }
                        Console.WriteLine();
                    }
                }
            }

        }
        static void Ho_P()
        {
            int n;
            Console.WriteLine("Star Hourglass Pattern Program");
            Console.WriteLine("Enter the number of rows up to where you want to view(Enter Positive Even Number of Rows Only)");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n % 2 == 1)
            {
                Console.WriteLine("You have Enter The Invalid Input");
                Console.WriteLine("Enter the Valid Option");
            }
            else
            {
                int i, a1 = -1, a2 = n, a3 = n / 2 - 2, a4 = 2;
                for (i = 0; i <= n; i++)
                {
                    if (i <= n / 2)
                    {
                        for (int k = 0; k <= a1; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= a2; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        a1++;
                        a2 -= 2;
                    }
                    else
                    {
                        for (int k = 0; k <= a3; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= a4; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        a3--;
                        a4 += 2;
                    }
                }
            }
        }
        static void S_H_P()
        {
            int n;
            Console.WriteLine("Symmetric Star Heart Pattern Program");
            Console.WriteLine("Enter the number of rows up to where you want to view(Enter Only Postive number of Rows)");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("You have Enter The Invalid Input");
                Console.WriteLine("Enter the Valid Option");
            }
            else
            {
                int nc = (2 * n) + 1, nh = n / 3, x = -1;
                int a1 = -1, a2 = ((nc - 2) / 2), a3 = 1, a4 = a2;
                a1 += nh;
                a2 -= 2 * nh;
                a3 += 2 * nh;
                a4 = a2;
                for (int i = 0; i <= nh; i++)
                {
                    for (int j = 0; j <= a1; j++)
                        Console.Write(" ");
                    for (int k = 0; k <= a2; k++)
                        Console.Write("*");
                    for (int l = 0; l <= a3; l++)
                        Console.Write(" ");
                    for (int m = 0; m <= a4; m++)
                        Console.Write("*");
                    Console.WriteLine();
                    a1--;
                    a2 += 2;
                    a3 -= 2;
                    a4 += 2;
                }
                for (int i = 0; i <= n; i++)
                {
                    for (int j = 0; j <= x; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= nc; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    nc -= 2;
                    x++;
                }

            }
        }
    }
}
