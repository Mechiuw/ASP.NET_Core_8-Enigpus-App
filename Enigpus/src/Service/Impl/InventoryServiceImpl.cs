using System.Runtime.ConstrainedExecution;

class InventoryServiceImpl : INventoryService
{

    private readonly List<Novel> _novelRepo;

    public InventoryServiceImpl()
    {
        this._novelRepo = [];
    }

    public List<Novel> NovelRepo
    {
        get { return _novelRepo; }
    }
    public NovelResponse Create(NovelRequest novelRequest)
    {
        Novel novel = new Novel(
            novelRequest.Id,
            novelRequest.Title);
        return null;
    }
    public Novel GetById(String Id)
    {
        return null;
    }

    public List<Novel> GetAll()
    {
        return [];
    }

    public Novel Update(String Id)
    {
        return null;
    }

    public void Delete(String Id)
    {

    }
}