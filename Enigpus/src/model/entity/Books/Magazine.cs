using System.Reflection.Emit;

class Magazine(string Id, string Title, string Author, string Year) : Book
{
    public string Id { get; set; } = Id;
    public string Title { get; set; } = Title;
    public string Author { get; set; } = Author;
    public string Year { get; set; } = Year;

    public override string GetTitle()
    {
        return Title;
    }
}