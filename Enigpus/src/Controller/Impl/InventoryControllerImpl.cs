class InventoryControllerImpl : INventoryControllerInterface
{
    private readonly INventoryService _service;

    public InventoryControllerImpl(INventoryService _service)
    {
        _service = _service ?? throw new ArgumentNullException(nameof(_service));
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
                _service.Create(novelRequest);
            } catch (Exception e){
                Console.WriteLine(e.Data);
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
                Console.WriteLine(e.Data);                                      
            }
        } else {
            throw new Exception(String.Format("wrong input : {0}",choice));
        }
    }

    public void GetAllBook(string choice)
    {
        if(choice != null && choice == "A"){
            _service.GetAll();
        } 

        if(choice != null && choice == "B"){
            _service.MagGetAll();
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
                Console.WriteLine(e.Data);
            }
        }
        if(choice != null && choice == "B"){
            try{
                Console.WriteLine("insert the magazine id");
                string Id = Console.ReadLine();
                _service.MagGetById(Id);
            } catch (Exception e){
                Console.WriteLine(e.Data);
            }
        } 
        else {
            throw new Exception(String.Format("cant do with choice is empty or wrong input"));
        }
    }
}