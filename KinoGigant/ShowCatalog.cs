public class ShowCatalog
{

    private readonly List<Show> _shows = new();

    public IReadOnlyList<Show> Shows => _shows;


    public void SeedSampleShows()
    {
        Add(new Show(
            title: "Matrix",
            dateTime: new DateTime(2025, 4, 10),
            hour: new DateTime(2025, 4, 10, 18, 0, 0),
            numberOfSeats: 30)
        );

        Add(new Show(
            title: "Inception",
            dateTime: new DateTime(2025, 4, 11),
            hour: new DateTime(2025, 4, 11, 20, 0, 0),
            numberOfSeats: 30)
        );
    }

    public void Add(Show show) => _shows.Add(show);
}