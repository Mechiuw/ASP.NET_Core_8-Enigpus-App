using System.Runtime.ConstrainedExecution;

class InventoryServiceImpl : INventoryService
{

    private readonly List<Novel> _novelRepo;
    private readonly List<Magazine> _magazineRepo;

    public InventoryServiceImpl()
    {
        this._magazineRepo = [];
        this._novelRepo = [];
    }

    // ================= NOVEL SERVICE LAYER ==================
    public List<Novel> NovelRepo
    {
        get { return _novelRepo; }
    }

    public List<Magazine> MagazineRepo
    {
        get { return _magazineRepo; }
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
            throw new Exception(String.Format("couldn't find any novel with id : {0}",Id));
        }
    }

    public void Delete(String Id)
    {
        Novel foundNovel = _novelRepo.FirstOrDefault(x => x.Id == Id);
        if(foundNovel != null){
            _novelRepo.Remove(foundNovel);
        } else {
            throw new Exception(String.Format("couldn't find any novel with id : {0}",Id));
        }
    }

    // ================= MAGAZINE SERVICE LAYER ==================

    public MagazineResponse MagCreate(MagazineRequest magazineRequest){
        Magazine magazine = new(
            magazineRequest.Id,
            magazineRequest.Title,
            magazineRequest.Author,
            magazineRequest.Year
        );

        _magazineRepo.Add(magazine);
        return new MagazineResponse(
            magazine.Id,
            magazine.Title,
            magazine.Author,
            magazine.Year
        );
    }

    public MagazineResponse MagGetById(string Id){
        Magazine foundMagazine = _magazineRepo.FirstOrDefault(x => x.Id == Id);
        if(foundMagazine != null){
            return new MagazineResponse(
                foundMagazine.Id,
                foundMagazine.Title,
                foundMagazine.Author,
                foundMagazine.Year
            );
        } else {
            throw new Exception(String.Format("couldn't find any magazine with id : {0}",Id));
        }
    }

    public List<Magazine> MagGetAll(){
        return [];
    }

    public MagazineResponse MagUpdate(string Id,MagazineRequest magazineRequest){
        return null;
    }

    public void MagDelete(string Id){

    }

}
