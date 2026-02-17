using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 public class Movie
{
    public string Title{get; set;}
    public string Genre{get; set;}
    public double Rating{get; set;}
}
public class MovieManager
{
    public static List<Movie> Movies = new List<Movie>();
    public void AddMovie(Movie m)
    {
        Movies.Add(m);
    }
    public List<Movie> FilterByGenre(string genre)
    {
        return Movies.Where(x => x.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    public List<Movie> SortByRating()
    {
        return Movies.OrderByDescending(x => x.Rating).ToList();
    }

}
