using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public interface IFilm
{
    string Title{get; set;}
    string Director{get; set;}
    int Year{get; set;}     
}
public class Film : IFilm
{
    public string Title{get; set;}
    public string Director{get; set;}
    public int Year{get; set;}    
    public Film(string title, string director, int year)
    {
        Title = title;
        Director = director;
        Year = year;
    }    
}
public interface IFilmLibrary
{
    void AddFilm(IFilm film);
    void RemoveFilm(string title);
    List<IFilm> GetFilms();
    List<IFilm> SearchFilms(string query);
    int GetTotalFilmCount();
}
public class FilmLibrary
{
    private List<IFilm> _film = new List<IFilm>();
    public void AddFilm(IFilm film)
    {
        _film.Add(film);
    }
    public void RemoveFilm(string title)
    {
        var film = _film.FirstOrDefault(f =>
        f.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (film != null)
        {
            _film.Remove(film);
        }
    }
    public List<IFilm> GetFilms()
    {
        return _film;
    }
    public List<IFilm> SearchFilms(string query)
    {
        return _film
            .Where(f => f.Title.Contains(query, StringComparison.OrdinalIgnoreCase) || f.Director.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    public int GetTotalFilmCount()
    {
        return _film.Count;
    }
}
