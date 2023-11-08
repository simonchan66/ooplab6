using System.Text.Json;

namespace lab6_serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event e = new Event(1, "Calgary", "Tech Competition");
            //Console.WriteLine(e.EventNumber);
            //Console.WriteLine(e.Location);
            string encoded = JsonSerializer.Serialize(e);
            Console.WriteLine(encoded);

            string path = "events.json";

            File.WriteAllText(path, encoded);
            Console.WriteLine("successfully saved to JSON file");


            // deserialize
            string contents = File.ReadAllText(path);
            //JsonSerializer.Deserialize(encoded, typeof(Event));
            Event decoded = JsonSerializer.Deserialize<Event>(contents);
            Console.WriteLine(decoded.EventNumber);
            Console.WriteLine(decoded.Location);
            Console.WriteLine(decoded.EventName);

            //Readfromfile

            e.SerializeDeserializeStream();
        }
    }
}