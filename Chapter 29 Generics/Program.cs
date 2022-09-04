/* Generics refer to the use of type parameters, which provide a way to design
code templates that can operate with different data types. Specifically,
it is possible to create generic methods, classes, interfaces, delegates,
and events */

using static System.Console;

namespace Generics
{
    class GenericClass<T>
    {
        public T Duration { get; set; }
        public string SongName { get; set; }
        public GenericClass(T duration, string songname)
        {
            Duration = duration;
            SongName = songname;
        }
    }

    class Song<R> // base class
    {
        public R SongName { get; }
        public Song(R songname)
        {
            SongName = songname;
        }
    }

    // first way to inherit generic types
    class UniversalSong<R> : Song<R>
    {
        public UniversalSong(R songname) : base(songname) { }
    }

    // second way to inherit generic types
    class IntSong : Song<int>
    {
        public IntSong(int songname) : base(songname) { }
    }

    // third way to inherit generic types
    class StringSong<P> : Song<int>
    {
        public P Text { get; set; }

        public StringSong(int songname, P text) : base(songname)
        {
            Text = text;
        }
    }

    // generic interface

    interface IArtis<T>
    {
        T Name { get; }
    }

    class Artist<T> : IArtis<T>
    {
        public T Name { get; }
        public Artist(T name) => Name = name;
    }

    // generic event

    class GenericEvent<T>
    {
        public int Treck
        {
            get;
            private set;
        }
        public GenericEvent(int treck)
        {
            Treck = treck;
        }
        public delegate void TreckTitle<P>();
        public event TreckTitle<Program>? Message; // event definition
        private void TestMethod()
        {
            if (Message != null)
                Message();
        }
    }
    // constraints
    class Notification
    {
        public string Body { get; } // text of notification
        public Notification(string body)
        {
            Body = body;
        }
    }

    class EmailNotification : Notification
    {
        public EmailNotification(string body) : base(body) { }
    }

    class NotificationMessenger<T> where T : Notification
    {
        public void SendNotification(T notification)
        {
            WriteLine($"Notification sent: {notification.Body}");
        }
    }

    // multiple constraints
    class Track<T, P>
        where T : Title
        where P : Artist
    {
        public void TrackInfo(P duration, P artist, T title)
        {
            Console.WriteLine($"Duration: {duration.Name}");
            Console.WriteLine($"Artist: {artist.Name}");
            Console.WriteLine($"Title: {title.Text}");
        }
    }
    class Artist
    {
        public string Name { get; }
        public Artist(string name) => Name = name;
    }

    class Title
    {
        public string Text { get; }
        public Title(string text) => Text = text;
    }

    class Program
    {
        // generic delegate
        public delegate void GenericDelegate<T>(T arg);

        public static void Generic(string str)
        {
            WriteLine(str);
        }

        static void Main()
        {
            // Clear(); // method to clear screen and the console buffer
            WriteLine("--- Generic Methods ---");
            WriteLine("--- Calling Generic Methods ---");

            int day = 3;
            int month = 9;

            DateSwap<int>(ref day, ref month); // creat and calling generic method
            WriteLine($"Day: {day}; Month: {month};");

            string dayWord = "Three";
            string monthWord = "September";

            DateSwap<string>(ref dayWord, ref monthWord); // creat and calling generic method
            WriteLine($"Day: {dayWord}; Month: {monthWord};");

            static void DateSwap<T>(ref T day, ref T month)
            {
                T storage = day;
                day = month;
                month = storage;
            }

            WriteLine("--- Generic Type Parameters ---");
            WriteLine("--- Default Value ---");

            string name = "Mikhail Shufutinsky";
            int age = 74;
            string? date = "September 3";

            GeneralList<string, int, string>(ref name, ref age, ref date);

            static void GeneralList<T, K, P>(ref T name, ref K age, ref P? date)
            {
                WriteLine($"My name is {name}, i am {age} years old.");
                date = default(P);
            }

            WriteLine("--- Generic Classes ---");

            GenericClass<int> song = new GenericClass<int>(381, "September 3");

            int songDuration = song.Duration;
            string songName = song.SongName;
            WriteLine($"Title: {songName}; Duration: {songDuration} seconds");

            WriteLine("--- Generic Class Inheritance ---");

            // there are three main options for inheriting generic classes

            WriteLine("--- first way to inherit generic types ---");

            Song<string> song1 = new Song<string>("September 3");
            Song<int> song2 = new UniversalSong<int>(0903);
            UniversalSong<int> song3 = new UniversalSong<int>(0309);

            WriteLine(song1.SongName);
            WriteLine(song2.SongName);
            WriteLine(song3.SongName);

            WriteLine("--- second way to inherit generic types ---");

            IntSong song4 = new IntSong(0903);
            Song<int> song5 = new IntSong(0309);

            WriteLine(song4.SongName);
            WriteLine(song5.SongName);

            WriteLine("--- third way to inherit generic types ---");

            StringSong<string> song6 = new StringSong<string>(0309, "September 9");
            Song<int> song7 = new StringSong<int>(0903, 0309);

            WriteLine(song6.SongName);
            WriteLine(song7.SongName);

            WriteLine("--- Generic Interfaces ---");

            IArtis<string> artist = new Artist<string>("M.S.");
            WriteLine($"Artist name: {artist.Name}");

            IArtis<int> artist1 = new Artist<int>(0309);
            WriteLine($"Artist name: {artist1.Name}");

            WriteLine("--- Generic Delegates & Events ---");

            GenericDelegate<string> del = Generic;
            WriteLine(del);

            GenericEvent<int> genericEvent = new GenericEvent<int>(0309);
            WriteLine(genericEvent.Treck);

            WriteLine("--- Constraints ---");

            void SendNotification<T>(T notification) where T : Notification
            {
                WriteLine($"You have one unread message: {notification.Body}");
            }

            SendNotification(new Notification("Hello! Can we meet tomorrow?"));
            SendNotification(new EmailNotification("Yes of course!"));

            NotificationMessenger<Notification> messenger = new NotificationMessenger<Notification>();
            messenger.SendNotification(new Notification("It was a good summer, but it's over."));

            NotificationMessenger<EmailNotification> messenger1 = new NotificationMessenger<EmailNotification>();
            messenger1.SendNotification(new EmailNotification("Only 9 months left until next summer."));

            WriteLine("--- Multiple Constraints ---");

            Track<Title, Artist> mess = new Track<Title, Artist>();
            Artist d = new Artist("five minutes");
            Artist a = new Artist("The Cranberries");
            Title t = new Title("Zombie");
            mess.TrackInfo(d, a, t);
        }
    }
}
