using System.ComponentModel.DataAnnotations;
using System.Reflection;
using ReadWriteFileDemo;

var movieManager = new MovieManager();

//Path.Combine används för att bygga sökvägar på ett korrekt sätt.
//I Environment kan man hitta alla standard-mappar i en windowsdator. Tex. AppData, Desktop, MyDocuments mm.
var directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Demo.txt");
Directory.CreateDirectory(directory);


var genres = Enum.GetValues<Genres>();

foreach (var genre in genres)
{
    var path = Path.Combine(directory, $"{genre}.txt");
    movieManager.CreateMovieFile(path, genre);
}




//if (File.Exists(path))
//{
//    List<Movie> movieList = new List<Movie>();
//    string? line = "";
//    string title = "";
//    string length = "";
//    string description = "";
//    string genres = "";

//    //StreamReader används för att öppna en fil och läsa från den.
//    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
//    using StreamReader sr = new StreamReader(path);
//    //ReadLine() läser nästa rad i filen
//    while ((line = sr.ReadLine()) != null)
//    {
//        if (line.StartsWith("Title:"))
//        {
//            title = line.Substring(7);
//        }
//        else if (line.StartsWith("Length: "))
//        {
//            length = line.Substring(8);
//        }
//        else if (line.StartsWith("Description: "))
//        {
//            description = line.Substring(13);
//        }
//        else if (line.StartsWith("Genres: "))
//        {
//            genres = line.Substring(8);
//        }
//        else
//        {
//            Movie tempMovie = new Movie();
//            tempMovie.Title = title;
//            string lengthText = length.Split(' ')[0];
//            tempMovie.Length = double.Parse(lengthText);
//            tempMovie.Description = description;

//            string[] genresText = genres.Split(',');
//            List<Genres> genresList = new List<Genres>();
//            foreach (var genre in genresText)
//            {
//                if (genre == "")
//                {
//                    break;
//                }

//                genresList.Add(Enum.Parse<Genres>(genre));

//                //tempMovie.Genres = (Enum.Parse<Genres>(genre);
//                //Enum.Parse(typeof(Genres), genre);
//            }

//            tempMovie.Genres = genresList;
//            movieList.Add(tempMovie);
//        }
//    }

    //var pathSciFi = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SciFiMovies.txt");

    //var sciFiMovieTitle = movieList.Where(m => m.Genres.Any(g => g == Genres.SciFi))
    //    .Select(m => m.Title);
    //using StreamWriter sw = new StreamWriter(pathSciFi);
    //foreach (var movie in movieList)
    //{
    //    foreach (var SciFiMovieTitle in sciFiMovieTitle)
    //    {
    //        sw.WriteLine(movie);
    //    }
    //    sw.Close();
    //}
   

    //var actionMovieTitle = movieList.Where(m => m.Genres.Any(g => g == Genres.Action));
    //var comedyMovieTitle = movieList.Where(m => m.Genres.Any(g => g == Genres.Comedy));
    //var dramaMovieTitle = movieList.Where(m => m.Genres.Any(g => g == Genres.Drama));
    //var thrillerMovieTitle = movieList.Where(m => m.Genres.Any(g => g == Genres.Thriller));
    //var fantasyMovieTitle = movieList.Where(m => m.Genres.Any(g => g == Genres.Fantasy));
    //var horrorMovieTitle = movieList.Where(m => m.Genres.Any(g => g == Genres.Horror));


    //foreach (var movie in movieList)
    //{
    //    foreach (var SciFiMovieTitle in sciFiMovieTitle)
    //    {
    //        Console.WriteLine(movie.Title);
    //    }
    //    sw.Close();
    //    //if (movie.Genres.Any(g => g == Genres.SciFi))
    //    //{
    //    //    Console.WriteLine(movie.Title);
    //    //}

    //    //foreach (var movieGenre in movie.Genres)
    //    //{
    //    //    if (movieGenre == Genres.SciFi)
    //    //    {
    //    //        Console.WriteLine(movie.Title);
    //    //    }
    //    //}

    //}

    
}




//Console.WriteLine(movie);
//Thread.Sleep(400);
