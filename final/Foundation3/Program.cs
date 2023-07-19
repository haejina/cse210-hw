public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the details for the General Event:");
        Event generalEvent = CreateEventFromUserInput();

        Console.WriteLine("\nEnter the details for the Tech Talk Lecture:");
        Lecture lecture = (Lecture)CreateEventFromUserInput();
        Console.Write("Enter the Speaker Name: ");
        lecture.Speaker = Console.ReadLine();
        Console.Write("Enter the Capacity: ");
        lecture.Capacity = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter the details for the Networking Event Reception:");
        Reception reception = (Reception)CreateEventFromUserInput();
        Console.Write("Enter the RSVP Email: ");
        reception.RsvpEmail = Console.ReadLine();

        Console.WriteLine("\nEnter the details for the Picnic Outdoor Gathering:");
        OutdoorGathering outdoorGathering = (OutdoorGathering)CreateEventFromUserInput();
        Console.Write("Enter the Weather Forecast: ");
        outdoorGathering.WeatherForecast = Console.ReadLine();

        Console.WriteLine("\nMarketing Messages:\n");
        Console.WriteLine("General Event:");
        Console.WriteLine(generalEvent.GetFullDetails());

        Console.WriteLine("\nTech Talk Lecture:");
        Console.WriteLine(lecture.GetFullDetails());

        Console.WriteLine("\nNetworking Event Reception:");
        Console.WriteLine(reception.GetFullDetails());

        Console.WriteLine("\nPicnic Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
    }

    public static Event CreateEventFromUserInput()
    {
        Console.Write("Enter the Event Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter the Event Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the Event Date (yyyy-MM-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter the Event Time (HH:mm): ");
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());
        Console.Write("Enter the Street Address: ");
        string street = Console.ReadLine();
        Console.Write("Enter the City: ");
        string city = Console.ReadLine();
        Console.Write("Enter the Country: ");
        string country = Console.ReadLine();

        Address address = new Address(street, city, country);

        Console.WriteLine("Select Event Type:\n1. General Event\n2. Lecture\n3. Reception\n4. Outdoor Gathering");
        Console.Write("Enter the event type (1/2/3/4): ");
        int eventType = int.Parse(Console.ReadLine());

        switch (eventType)
        {
            case 1:
                return new Event(title, description, date, time, address);
            case 2:
                return new Lecture(title, description, date, time, address);
            case 3:
                return new Reception(title, description, date, time, address);
            case 4:
                return new OutdoorGathering(title, description, date, time, address);
            default:
                throw new ArgumentException("Invalid event type.");
        }
    }
}
