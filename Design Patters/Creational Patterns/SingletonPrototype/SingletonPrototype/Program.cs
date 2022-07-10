
using SingletonPrototype;
using System.Text;

//Book book = new() { Name = "Kenanin maceralari", Author = "Kennan", PublishYear = 2022 };

//Book book1 = book.Clone() as Book;


//book.PublishYear = 2023;
//Console.WriteLine($"{book.Name} {book.Author} {book.PublishYear}");

//Console.WriteLine($"{book1?.Name} {book1?.Author} {book1?.PublishYear}");

Book b = new();

Console.OutputEncoding = Encoding.UTF8;

President president = President.GetPresident();
President president1 = President.GetPresident();

president.Surname = "Əliyev";

Console.WriteLine(president);
Console.WriteLine(president1);

