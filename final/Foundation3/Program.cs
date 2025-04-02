using System;

class Program
{
    static void Main(string[] args)
    {
        static void CreateReception()
        {
            Receptions reception = new Receptions("Generic Wedding Reception", "Dec 12, 2025", "1:00 PM", "bobbymcbride@reception.com");
            reception.AddGuest("Bob Barker");
            reception.AddGuest("Mickey Mouse");
            reception.SetDescription("Someone is getting married, we don't know who, but it will surely be lovely. Please RSVP");
            reception.AddAddress("21 chubby baby ln", "Thompson", "IL", "UnitedStates");
            reception.StandardDetails();
            reception.FullDetails();
            reception.ShortDescription();

        }
        CreateReception();
        static void CreateOutdoor()
        {
            Outdoor outdoor = new Outdoor("Frisbee Golf", "June 3, 2025", "2:30 PM");
            outdoor.SetWeather("Cloudy with a Chance of Meatballs");
            outdoor.SetDescription("Frisbee is great! Fun Will be had by all!");
            outdoor.AddAddress("472 Disc Golf Rd", "Frisbey", "MO", "UnitedStates");
            outdoor.StandardDetails();
            outdoor.FullDetails();
            outdoor.ShortDescription();
        }
        CreateOutdoor();
        static void CreateLecture()
        {
            Lectures lecture = new Lectures("Board to Tears", "May 12, 2025", "7:03 AM", "Lumber Jack Jack", 214);
            lecture.AddAddress("321 hit-by-a-board Rd.", "Cry-me-a-river", "IN", "UnitedStates");
            lecture.SetDescription("Is life too fun, Come and get bored with Board to Tears. It might just be boring, we may get hit with a board, you'll never know until you come.");
            lecture.StandardDetails();
            lecture.FullDetails();
            lecture.ShortDescription();

        }
        CreateLecture();
    }
}