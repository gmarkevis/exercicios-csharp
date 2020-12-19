using System;

namespace Mod6_Arrays_fixacao {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[10];

            for(int i = 0; i < n; i++) {
                Console.WriteLine("Aluguel #" + (i+1));
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                students[room] = new Student (name, email);
            }

            Console.WriteLine("");
            Console.WriteLine("Quartos ocupados:");
            for(int i=0; i < 10; i++) {
                if(students[i] != null) {
                    Console.WriteLine(i + ": " + students[i].ToString());
                }
                
                
            }
        }
    }
}
