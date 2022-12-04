/*
   Guestbook for my cottage in Åre, Sweden.
   Code by Christine Johanson chjo2104
*/
using System;

namespace comments
{

    class Program
    {
        static void Main(string[] args)
        {
            //instansierar managerklassen
            CommentBook commentbook = new CommentBook();
            int i = 0;

            //oändlig slinga.
            while (true)
            {

                Console.Clear(); Console.CursorVisible = true;
                Console.WriteLine("Välkommen till Gästboken!\n");

                Console.WriteLine("1. Lägg till inlägg och skribent");
                Console.WriteLine("2. Ta bort inlägg");

                Console.WriteLine("X. Avsluta\n");

                i = 0;
                //för varje element comment i commentbook i getcomment.
                foreach (Comment comment in commentbook.getComments())
                {
                    Console.WriteLine("[" + i++ + "] " + comment.Comment_no + " \n" + comment.Author);
                }

                int inp = (int)Console.ReadKey(true).Key;
                switch (inp)
                {
                    case '1':
                        Console.Clear(); Console.CursorVisible = true;
                        Console.Write("Skriv inlägg: ");
                        //variabel som heter regno
                        string regno = Console.ReadLine();
                        if (String.IsNullOrEmpty(regno))
                        {
                            Console.WriteLine("Fyll i inlägg! Tryck 1 igen.");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Fyll i skribent: ");
                        //variabel
                        string author = Console.ReadLine();
                        if (String.IsNullOrEmpty(author))
                        {
                            Console.WriteLine("Du måste fylla i ett namn också. Börja om från början");
                            Console.ReadKey();
                            break;
                        }
                        Comment obj = new Comment();
                        obj.Comment_no = regno;
                        obj.Author = author;

                        commentbook.addComment(obj);

                        break;

                    case '2':
                        Console.CursorVisible = true;
                        Console.Write("Ange index att radera: ");
                        string index = Console.ReadLine();

                        commentbook.delCom(Convert.ToInt32(index));
                        break;

                    case 88:
                        Console.Clear(); Console.CursorVisible = true;
                        Environment.Exit(0);
                        break;
                }

            }

        }
    }
}

