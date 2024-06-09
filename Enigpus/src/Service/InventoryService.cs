using System.Runtime.InteropServices;

interface INventoryService
{
    // ================= NOVEL INTERFACE LAYER ==================
    NovelResponse Create(NovelRequest novelRequest);
    NovelResponse GetById(String Id);
    List<Novel> GetAll();
    NovelResponse Update(String Id,NovelRequest novelRequest);
    void Delete(String Id);

    // ================= MAGAZINE INTERFACE LAYER ==================

    MagazineResponse MagCreate(MagazineRequest magazineRequest);
    MagazineResponse MagGetById(String Id);
    List<Magazine> MagGetAll();
    MagazineResponse MagUpdate(String Id, MagazineRequest magazineRequest);
    void MagDelete(String Id);

}