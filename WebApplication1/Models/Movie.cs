namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    //public class Movie : DbContext
    //{
    //    // Контекст настроен для использования строки подключения "Movie" из файла конфигурации  
    //    // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
    //    // "WebApplication1.Models.Movie" в экземпляре LocalDb. 
    //    // 
    //    // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Movie" 
    //    // в файле конфигурации приложения.
    //    //public Movie()
    //    //    : base("name=Movie")
    //    //{
    //    //}

    //    // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
    //    // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

    //    // public virtual DbSet<MyEntity> MyEntities { get; set; }
    //}

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}