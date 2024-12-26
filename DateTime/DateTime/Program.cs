static void DateTimeExamples()
{
    var dateTime = new DateTime(2025, 1, 1);
    var now = DateTime.Now;

    Console.WriteLine("{0}: {1}: {2}", now.Hour, now.Minute, now.Second);
    // Only Date
    var onlyDate = DateTime.Today;
    Console.WriteLine(onlyDate);

    Console.WriteLine(now.ToLongDateString()); // Date with Long
    Console.WriteLine(now.ToShortDateString()); // Short Date
    Console.WriteLine(now.ToLongTimeString()); // Long Time
    Console.WriteLine(now.ToShortTimeString()); // Short Time
    Console.WriteLine(now.ToString()); // Complete Date and Time

    Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); // Format specifiers
}

static void TimeSpanExamples()
{
    // Creating TimeSpan
    var timeSpan = new TimeSpan(2,2,50,0);

    // Properties
    Console.WriteLine("Minutes: " + timeSpan.Minutes);
    Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // Converts all hours, seconds to minutes..

    // Add
    Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
    Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

    // toString

    Console.WriteLine(timeSpan);
    Console.WriteLine(timeSpan.ToString());

    var timeSpan2 = DateTime.Now.AddHours(5) - DateTime.Now;
    //Console.WriteLine(timeSpan2);
}

//DateTimeExamples();
TimeSpanExamples();