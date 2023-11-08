using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_serialization
{
    internal class Event
    {
        public int EventNumber {  get; set; }
        public string Location { get; set; }
        public string EventName { get; set; }
        //default constructor because there is no code inside of this
        public Event() { 
        
        }
        public Event(int eventNumber, string location, string eventName)
        {
            this.EventNumber = eventNumber;
            this.Location = location;
            this.EventName = eventName;
        }

        public void SerializeDeserializeStream() {
            string path = "name.bin";
            StreamWriter streamWriter = File.CreateText(path);
            streamWriter.WriteLine("Hackathon");
            streamWriter.Close();

            using (StreamReader reader = File.OpenText(path))
            {
                string word = reader.ReadToEnd().TrimEnd();
                char first = word[0];
                
                char middle = word[(int)(word.Length /2)];
                char last = word[word.Length - 1];
                Console.WriteLine("In Word: Hackathon");
                Console.WriteLine("The First Character is: " + first);
                Console.WriteLine("The Middle Character is: " + middle);
                Console.WriteLine("The Last Character is: " + last);



            }

        }
    }
}
