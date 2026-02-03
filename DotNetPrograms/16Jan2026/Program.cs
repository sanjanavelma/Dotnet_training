using System;
using System.Collections;
class Program
{
    static void Main()
    {
        var library = new FilmLibrary();
        library.AddFilm(new Film("Inception", "Christopher Nolan", 2010));
        library.AddFilm(new Film("Interstellar", "Christopher Nolan", 2014));
        Console.WriteLine(library.GetTotalFilmCount());
        var results = library.SearchFilms("Nolan");
        foreach (var film in results)
        {
            Console.WriteLine($"{film.Title} | {film.Director} | {film.Year}");
        }
        library.RemoveFilm("Inception");
        Console.WriteLine(library.GetTotalFilmCount());
        var results2 = library.SearchFilms("Nolan");
        foreach (var film in results2)
        {
            Console.WriteLine($"{film.Title} | {film.Director} | {film.Year}");
        }
    }
}