using System.Reflection.Emit;

class Novel(string Id, string Title,string Author,string Year,string Writer) : Book
{
    public string Id {get; set;} = Id;
    public string Title {get; set;} = Title;
    public string Author {get; set;} = Author;
    public string Year {get; set;} = Year;
    public string Writer {get; set;} = Writer;

    public override string GetTitle()
    {
        return Title;
    }
}