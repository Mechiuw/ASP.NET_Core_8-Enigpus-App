class InventoryControllerImpl : INventoryControllerInterface
{
    private readonly INventoryService _service;

    public InventoryControllerImpl(INventoryService service)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
    }
    public void AddBook(string choice)
    {
        if(choice == "A"){
            try{
                Console.WriteLine("insert new Id : ");
                string Id = Console.ReadLine();
                Console.WriteLine("insert the Title : ");
                string Title = Console.ReadLine();
                Console.WriteLine("insert the Author : ");
                string Author = Console.ReadLine();
                Console.WriteLine("insert the Year : ");
                string Year = Console.ReadLine();
                Console.WriteLine("insert the Writer : ");
                string Writer = Console.ReadLine();

                NovelRequest novelRequest = new(
                    Id,
                    Title,
                    Author,
                    Year,
                    Writer
                );
                NovelResponse novelResponse = _service.Create(novelRequest);
                novelResponse.ToString();
            } catch (Exception e){
                Console.WriteLine(e.Message);
            }
        } else if (choice == "B"){
            try{
                Console.WriteLine("insert new Id : ");
                string Id = Console.ReadLine();
                Console.WriteLine("insert the Title : ");
                string Title = Console.ReadLine();
                Console.WriteLine("insert the Author : ");
                string Author = Console.ReadLine();
                Console.WriteLine("insert the Year : ");
                string Year = Console.ReadLine();

                MagazineRequest magazineRequest = new(
                    Id,
                    Title,
                    Author,
                    Year
                );
                _service.MagCreate(magazineRequest);
            } catch (Exception e){
                Console.WriteLine(e.Message);                                      
            }
        } else {
            throw new Exception(String.Format("wrong input : {0}",choice));
        }
    }

    public void GetAllBook(string choice)
    {
        if (choice == "A")
    {
        var books = _service.GetAll() ?? throw new Exception("GetAll() returned null");
            books.ForEach(book =>
        {
            Console.WriteLine(book.Id);
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.WriteLine(book.Year);
            Console.WriteLine(book.Writer);
        });
    }

        else if (choice == "B")
    {
        var magazines = _service.MagGetAll() ?? throw new Exception("MagGetAll() returned null");
            magazines.ForEach(magazine =>
        {
            Console.WriteLine(magazine.Id);
            Console.WriteLine(magazine.Title);
            Console.WriteLine(magazine.Author);
            Console.WriteLine(magazine.Year);
        });
    }
        else {
            throw new Exception(String.Format("cant do with choice is empty"));
        }
    }

    public void SearchBook(string choice)
    {
        if(choice != null && choice == "A"){
            try{
                Console.WriteLine("insert the novel id");
                string Id = Console.ReadLine();
                _service.GetById(Id);
            } catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
        if(choice != null && choice == "B"){
            try{
                Console.WriteLine("insert the magazine id");
                string Id = Console.ReadLine();
                _service.MagGetById(Id);
            } catch (Exception e){
                Console.WriteLine(e.Message);
            }
        } 
        else {
            throw new Exception(String.Format("cant do with choice is empty or wrong input"));
        }
    }
}