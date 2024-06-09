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
            _service.Create();
        } else if (choice == "B"){
            _service.MagCreate();
        } else {
            throw new Exception(String.Format("wrong input : {0}",choice));
        }
    }

    public void GetAllBook()
    {
        throw new NotImplementedException();
    }

    public void SearchBook()
    {
        throw new NotImplementedException();
    }
}