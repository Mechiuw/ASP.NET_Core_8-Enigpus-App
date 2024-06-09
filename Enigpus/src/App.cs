using System;

class App
{
    static void Run()
    {
        InventoryServiceImpl serviceImpl = new();
        InventoryControllerImpl impl = new(serviceImpl);

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("===== Enigpus App Menu =====");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Get a Book By Id");
            Console.WriteLine("3. Get All Books");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("=== Add a Book ===");
                    Console.WriteLine("Novel(A) or Magazine(B)");
                    string a = Console.ReadLine();
                    impl.AddBook(a);
                    break;
                case "2":
                    Console.WriteLine("=== Get a Book By Id ===");
                    Console.WriteLine("Novel(A) or Magazine(B)");
                    string b = Console.ReadLine();
                    impl.SearchBook(b);
                    break;
                case "3":
                    Console.WriteLine("=== Get All Books ===");
                    Console.WriteLine("Novel(A) or Magazine(B)");
                    string c = Console.ReadLine();
                    impl.GetAllBook(c);
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
