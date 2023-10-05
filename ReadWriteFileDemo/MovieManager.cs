namespace ReadWriteFileDemo;

public class MovieManager
{
    public MovieCollection Moviedb { get; set; } = new MovieCollection()

    public void CreateMovieFile()
    {
        //File.Exists kan användas för att kontrollera ifall en fil finns på en given sökväg
        if (!File.Exists(path))
        {
            //StreamWriter används för att öppna en fil och skriva till den.
            //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
            using StreamWriter sw = new StreamWriter(path);
            foreach (var movie in movieDb.Movies)
            {
                //WriteLine används för att skriva en ny rad.
                sw.WriteLine(movie);
            }
            sw.Close();
        }
    }

    public void CreateMovieFile(string path, Genres genre)
    {
        if (!File.Exists(path))
        {
            var genreMovies = movieDb.Movies
                .Where(m => m.Genres.Any(g => g == Genres.SciFi))
                .Select(m => m.Title);

            //StreamWriter används för att öppna en fil och skriva till den.
            //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
            using StreamWriter sw = new StreamWriter(path);
            foreach (var movie in MovieDb.Movies)
            {
                //WriteLine används för att skriva en ny rad.
                sw.WriteLine(movie);
            }
            sw.Close();
        }
    }
}