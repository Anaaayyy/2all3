using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2all3
{
    class Author
    {
        // Поля для хранения информации об авторе
        public string Name { get; set; }
        public int BirthYear { get; set; }

        // Конструктор для инициализации полей
        public Author(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }

        // Метод для вывода информации об авторе
        public void PrintInfo()
        {
            Console.WriteLine($"Автор: {Name}, Год рождения: {BirthYear}");
        }
    }

    class Book
    {
        // Поля для хранения информации о книге
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public Author BookAuthor { get; set; }  // Связь с объектом Author (композиция)

        // Конструктор для инициализации полей
        public Book(string title, int releaseYear, Author author)
        {
            Title = title;
            ReleaseYear = releaseYear;
            BookAuthor = author;
        }

        // Метод для вывода информации о книге
        public void PrintInfo()
        {
            Console.WriteLine($"Книга: {Title}, Дата публикации: {ReleaseYear}");
            BookAuthor.PrintInfo();  // Вывод информации об авторе книги
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("---------------Композиция-------------");
            // Создание объектов Author
            Author author = new Author("Харуки Мураками", 1949);
     
            // Создание объектов Book, связанных с авторами
            Book book = new Book("Норвежский лес", 1987, author);

            // Вывод информации о книгах и их авторах
            book.PrintInfo();
            Console.ReadLine();
            
        }
    }
}
