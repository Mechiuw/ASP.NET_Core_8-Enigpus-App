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
        Novel novel = new(
            novelRequest.Id,
            novelRequest.Title,
            novelRequest.Author,
            novelRequest.Year,
            novelRequest.Writer);
        _novelRepo.Add(novel);

        return new NovelResponse(
            novel.Id,
            novel.Title,
            novel.Author,
            novel.Year,
            novel.Writer);
    }
    public NovelResponse GetById(String Id)
    {
        Novel foundNovel = _novelRepo.FirstOrDefault(x => x.Id == Id);
        if(foundNovel != null){
            return new NovelResponse(
                foundNovel.Id,
                foundNovel.Title,
                foundNovel.Author,
                foundNovel.Year,
                foundNovel.Writer
            );
        } else {
            throw new Exception(String.Format("couldn't find any novel with id : {0}",Id));
        }
    }

    public List<Novel> GetAll()
    {
        return [.. _novelRepo];
    }

    public NovelResponse Update(string Id,NovelRequest novelRequest)
    {
        Novel foundNovel = _novelRepo.FirstOrDefault(x => x.Id == Id);
        if(foundNovel != null){
            Novel saveNovel = new(
                foundNovel.Id,
                foundNovel.Title,
                foundNovel.Author,
                foundNovel.Year,
                foundNovel.Writer
            );
            _novelRepo.Add(saveNovel);
            return new NovelResponse(
                saveNovel.Id,
                saveNovel.Title,
                saveNovel.Author,
                saveNovel.Year,
                saveNovel.Writer
            );     
        } else {
            throw new Exception(String.Format("couldn't found any novel with id : {0}",Id));
        }
    }

    public void Delete(String Id)
    {

    }
}