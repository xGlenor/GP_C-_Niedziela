public class Show
{
    public string Title { get; set; }
    public DateTime ShowDate { get; set; }
    public DateTime ShowHour { get; set; }
    public List<Seat> Seats { get; set; }

    // Parameterless constructor needed for JSON deserialization
    public Show() { }

    public Show(string title, DateTime dateTime, DateTime hour, int numberOfSeats)
    {
        Title = title;
        ShowDate = dateTime;
        ShowHour = hour;
        Seats = new List<Seat>();
        for (int i = 1; i <= numberOfSeats; i++)
        {
            Seats.Add(new Seat(i));
        }
    }

}