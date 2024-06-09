using System.Runtime.InteropServices;

interface INventoryService
{
    NovelResponse Create(NovelRequest novelRequest);
    Novel GetById(String Id);
    List<Novel> GetAll();
    Novel Update(String Id);
    void Delete(String Id);
}