using System;
namespace movies
{
    class Program
    {
        enum Genre
        {
            HipHop,
            Pop,
            Jazz,
            Rock,
            Classical
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + 
                    "\nArtist: " + Artist +
                    "\nAlbum: " + Album +
                    "\nLength: " + Length + 
                    "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of the song?");
            string tempTitle = Console.ReadLine();

            Console.WriteLine("Who is the artist of the song?");
            string tempArtist = Console.ReadLine();

            Console.WriteLine("What is the album name?");
            string tempAlbum = Console.ReadLine();

            Console.WriteLine("What is the length of the song?");
            string tempLength = Console.ReadLine();

            Console.WriteLine("What is the genre?");
            Console.WriteLine("H.) Hip-Hop\nP.) Pop\nJ.) Jazz\nR.) Rock\nC.) Classical");
            Genre tempGenre = Genre.Rock;
            char sel = char.Parse(Console.ReadLine());
            switch (sel)
            {
                case 'H':
                    tempGenre = Genre.HipHop;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'C':
                    tempGenre = Genre.Classical;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine($"{music.Display()}");
        }
    }
}
