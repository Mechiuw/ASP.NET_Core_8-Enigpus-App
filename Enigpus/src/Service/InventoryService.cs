using System.Runtime.InteropServices;

interface INventoryService
{
    NovelResponse Create(NovelRequest novelRequest);
    NovelResponse GetById(String Id);
    List<Novel> GetAll();
    NovelResponse Update(String Id,NovelRequest novelRequest);
    void Delete(String Id);
}