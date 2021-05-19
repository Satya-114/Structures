using System;
struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
};

namespace Structures
{
    class Program
    {
        public class testStructure
        {
            public static void Main(string[] args)
            {
                Books Book1;   /* Declare Book1 of type Book 

                
      /* book 1 specification */
                Book1.title = "C Programming";
                Book1.author = "Nuha Ali";
                Book1.subject = "C Programming Tutorial";
                Book1.book_id = 6495407;
                /* print Book1 info */
                Console.WriteLine("Book 1 title : {0}", Book1.title);
                Console.WriteLine("Book 1 author : {0}", Book1.author);
                Console.WriteLine("Book 1 subject : {0}", Book1.subject);
                Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);
                Console.ReadKey();
            }
        }
    }
}


