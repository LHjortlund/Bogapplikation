
namespace Bogapplikation
{
    class Program
    {
        //En liste til at gemme bøger
        static List<Book> bookList = new List<Book>();

        //Main metode to run the program and show the menu and what the user can do
        static void Main(String[] args)
        {
            bool running = true; //Variable to keep the program running
            while (running)
            {
                //Show the menu for the user
                Console.WriteLine("\n --- Bog Menu ---");
                Console.WriteLine("1. Opret bog");
                Console.WriteLine("2. Se bogliste");
                Console.WriteLine("3. Afslut program");
                Console.WriteLine("Vælg en mulughed: ");

                string choice = Console.ReadLine(); //Læser the user's choice

                //Switch case to handle the user's choice
                switch (choice)
                {
                    case "1":
                        CreateBook(); //kalder metoden for at oprette en bog
                        break;
                    case "2":
                        ShowBookList(); //kalder metoden for at vise boglisten
                        break;
                    case "3":
                        running = false; //Sætter running til false for at afslutte programmet
                        Console.WriteLine("Programmet afsluttes");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv igen"); //Fejlbesked hvis brugeren indtaster et ugyldigt valg
                        break;
                }
            }
        }

        //Metode for at oprette en bog ved at indtaste title og forfatter fra brugeren
        static void CreateBook()
        {
            Console.Write("Indtast title: ");
            string title = Console.ReadLine();

            Console.Write("Indtast forfatter: ");
            string author = Console.ReadLine();

            Book newBook = new Book(title, author); //Opretter en ny bog med title og forfatter
            bookList.Add(newBook); //Tilføjer bogen til listen

            Console.WriteLine("Bogen er oprettet"); //Accepted, bekræftelse til brugeren om at bogen er oprettet

        }

        //Metode til at vise alle bøger i listen
        static void ShowBookList()
        {
            Console.WriteLine("\n --- Bogliste ---");
            if (bookList.Count == 0)
            {
                Console.WriteLine("Ingen bøger i listen"); //informerer brugeren om at listen er tom
            }
            else
            {
                foreach (Book book in bookList)
                {
                    book.DisplayInfo(); //Viser information om hver bog i listen
                }

            }
        }
    }
}
