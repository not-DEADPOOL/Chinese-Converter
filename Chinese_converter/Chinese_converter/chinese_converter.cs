using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinese_converter
{
    class chinese_converter
    {
        static void Main(string[] args)
        {
            char letter;
            Console.WriteLine("==================================================");
            Console.WriteLine("                Insert a character:               ");
            Console.WriteLine("==================================================\n");
            do
            {
                letter = Convert.ToChar(Console.ReadLine());
                if (!char.TryParse(Console.ReadLine(), out letter))
                {
                    Console.WriteLine(@"           
                                            ████████████            
                                        ████      ░░░░▒▒████        
                                        ██      ░░░░░░░░░░▒▒▒▒██      
                                    ██    ░░░░░░░░░░░░░░░░▒▒▒▒██    
                                    ██  ░░░░░░░░░░░░░░    ░░░░░░▒▒██  
                                    ██░░░░██████░░░░  ░░██████░░▒▒██  
                                ██  ░░████████░░░░░░░░████████░░▒▒██
                                ██  ██████████░░░░░░░░██████████▒▒██
                                ██  ██████████░░░░░░░░██████████▒▒██
                                ██  ░░██████░░░░░░░░░░░░██████░░▒▒██
                                ██░░░░░░░░░░░░████████░░░░░░░░░░▒▒██
                                    ██░░░░░░░░░░░░████░░░░░░░░░░▒▒██  
                                    ██░░░░░░░░░░░░████░░░░░░░░░░▒▒██  
                                    ██  ░░░░░░░░░░░░░░░░░░░░▒▒██    
                                        ██  ░░░░░░░░░░░░░░░░▒▒██      
                                        ██░░░░██░░░░██░░░░██        
                                        ██░░░░██░░░░██░░░░██        
                                        ██░░▒▒██░░▒▒██░░▒▒██        
                                            ████  ████  ████          
                ");
                }
            } while (!char.TryParse(Console.ReadLine().ToLower(), out letter));
            switch (letter)
            {
                case 'a':
                    Console.WriteLine($"{letter} = '至'");
                    break;
                case 'b':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'c':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'd':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'e':
                    Console.WriteLine($"{letter} = '和'");
                    break;
                case 'f':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'g':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'h':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'i':
                    Console.WriteLine($"{letter} = '這'");
                    break;
                case 'j':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'k':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'l':
                    Console.WriteLine($"{letter} = '大號'");
                    break;
                case 'm':
                    Console.WriteLine($"{letter} = '米'");
                    break;
                case 'n':
                    Console.WriteLine($"{letter} = '不'");
                    break;
                case 'o':
                    Console.WriteLine($"{letter} = '或者'"); ;
                    break;
                case 'p':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'q':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'r':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 's':
                    Console.WriteLine($"{letter} = '秒'");
                    break;
                case 't':
                    Console.WriteLine($"{letter} = '噸'");
                    break;
                case 'u':
                    Console.WriteLine($"{letter} = '你'");
                    break;
                case 'v':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                    
                case 'w':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'x':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'y':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                case 'z':
                    Console.WriteLine($"{letter} = '{letter}'");
                    break;
                default:
                    break;
            }
            Console.ReadKey();   
        }
    }
}
