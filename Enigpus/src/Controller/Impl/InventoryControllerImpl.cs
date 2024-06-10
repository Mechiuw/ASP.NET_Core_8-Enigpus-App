using System;
using System.Collections.Generic;
class InventoryControllerImpl : INventoryControllerInterface
{
    private readonly INventoryService _service;

    public InventoryControllerImpl(INventoryService service)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
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
                NovelResponse novelResponse = _service.Create(novelRequest);
                novelResponse.ToString();
            } catch (Exception e){
                Console.WriteLine(e.Message);
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
                Console.WriteLine(e.Message);                                      
            }
        } else {
            throw new Exception(String.Format("wrong input : {0}",choice));
        }
    }

    public void GetAllBook(string choice)
    {
        if (choice == "A")
    {
        var books = _service.GetAll() ?? throw new Exception("GetAll() returned null");
            books.ForEach(book =>
        {
            Console.Write($"Book Id ={book.Id}");
            Console.Write($"Book Title ={book.Title}");
            Console.Write($"Book Author ={book.Author}");
            Console.Write($"Book Year={book.Year}");
            Console.Write($"Book Writer={book.Writer}");
            Console.WriteLine("\n");
        });
    }

        else if (choice == "B")
    {
        var magazines = _service.MagGetAll() ?? throw new Exception("MagGetAll() returned null");
            magazines.ForEach(magazine =>
        {
            Console.Write($"Magazine Id ={magazine.Id}");
            Console.Write($"Magazine Title ={magazine.Title}");
            Console.Write($"Magazine Author ={magazine.Author}");
            Console.Write($"Magazine Year ={magazine.Year}");
            Console.WriteLine("\n");
        });
    }
        else {
            throw new Exception(String.Format("cant do with choice is empty"));
        }
    }

    public void SearchBook(string choice)
    {
        if(choice == "A"){
            try{
                Console.WriteLine("insert the novel id");
                string Id = Console.ReadLine();
                NovelResponse novelResponse = _service.GetById(Id);
                Console.Write($"Novel Id ={novelResponse.Id}");
                Console.Write($"Novel Title ={novelResponse.Title}");
                Console.Write($"Novel Author ={novelResponse.Author}");
                Console.Write($"Novel Year={novelResponse.Year}");
                Console.Write($"Novel Writer={novelResponse.Writer}");
                Console.WriteLine("\n");
            } catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
        else if(choice == "B"){
            try{
                Console.WriteLine("insert the magazine id");
                string Id = Console.ReadLine();
                MagazineResponse magazineResponse = _service.MagGetById(Id);
                Console.Write($"Magazine Id ={magazineResponse.Id}");
                Console.Write($"Magazine Title ={magazineResponse.Title}");
                Console.Write($"Magazine Author ={magazineResponse.Author}");
                Console.Write($"Magazine Year ={magazineResponse.Year}");
                Console.WriteLine("\n");
            } catch (Exception e){
                Console.WriteLine(e.Message);
            }
        } 
        else {
            throw new Exception(String.Format("cant do with choice is empty or wrong input"));
        }
    }
}