namespace ReadWriteFileDemo;

public class MovieCollection
{
    private List<Movie> _movies;

    public List<Movie> Movies => _movies;

    public MovieCollection()
    {
        PopulateMovies();
    }

    private void PopulateMovies()
    {
        _movies = new()
        {
            new ()
            {
                Title = "Scream",
                Description = "A year after the murder of her mother, a teenage girl is terrorized by a new killer, " +
                              "who targets the girl and her friends by using horror films as part of a deadly game.",
                Length = 1.85,
                Genres = new List<Genres>()
                {
                    Genres.Horror
                }
            },
            new ()
            {
                Title = "Event Horizon",
                Description = "A rescue crew investigates a spaceship that disappeared into a black hole and has now returned..." +
                              "with someone or something new on-board.",
                Length = 1.6,
                Genres = new List<Genres>()
                {
                    Genres.SciFi,
                    Genres.Horror,
                    Genres.Thriller
                }
            },
            new ()
            {
                Title = "Awakenings",
                Description = "The victims of an encephalitis epidemic many years ago have been catatonic " +
                              "ever since, but now a new drug offers the prospect of reviving them.",
                Length = 2.017,
                Genres = new List<Genres>()
                {
                    Genres.Drama
                }
            },
            new ()
            {
                Title = "Constantine",
                Description = "Supernatural exorcist and demonologist John Constantine helps a policewoman " +
                              "prove her sister's death was not a suicide, but something more.",
                Length = 2.017,
                Genres = new List<Genres>()
                {
                    Genres.Action,
                    Genres.Fantasy,
                    Genres.Horror
                }
            },
            new ()
            {
                Title = "Don't Look Up",
                Description = "Two low-level astronomers must go on a giant media tour to warn humankind of an approaching comet that will destroy planet Earth.",
                Length = 2.3,
                Genres = new List<Genres>()
                {
                    Genres.Drama,
                    Genres.SciFi,
                    Genres.Comedy
                }
            },
            new ()
            {
                Title = "Apocalypse",
                Description = "A U.S. Army officer serving in Vietnam is tasked with assassinating a renegade Special Forces Colonel who sees himself as a god.",
                Length = 2.45,
                Genres = new List<Genres>()
                {
                    Genres.Drama
                }
            },
            new ()
            {
                Title = "The 12 monkeys",
                Description = "In a future world devastated by disease, a convict is sent back in time to gather information about the man-made virus that wiped out most of the human population on the planet.",
                Length = 2.15,
                Genres = new List<Genres>()
                {
                    Genres.SciFi,
                    Genres.Comedy
                }
            },
            new ()
            {
                Title = "Pi",
                Description = "A paranoid mathematician searches for a key number that will unlock the universal patterns found in nature.",
                Length = 1.4,
                Genres = new List<Genres>()
                {
                    Genres.Drama,
                    Genres.Horror
                }
            },
            new ()
            {
                Title = "Being John Malkovich",
                Description = "A puppeteer discovers a portal that leads literally into the head of movie star John Malkovich.",
                Length = 1.83,
                Genres = new List<Genres>()
                {
                    Genres.Drama,
                    Genres.SciFi,
                    Genres.Fantasy
                }
            },
            new ()
            {
                Title = "Children of Men",
                Description = "In 2027, in a chaotic world in which women have somehow become infertile, a former activist agrees to help transport a miraculously pregnant woman to a sanctuary at sea.",
                Length = 1.86,
                Genres = new List<Genres>()
                {
                    Genres.Action,
                    Genres.SciFi
                }
            },
            new ()
            {

            }

        };
    }
}