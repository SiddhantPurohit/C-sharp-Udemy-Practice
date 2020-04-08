using System;

namespace Stackoverflow
{
    public class Stackoverflow
    {
        private string Post;
        private int Upvotes = 0;
        private int Downvotes = 0;

        public string UploadPost()
        {
            Console.WriteLine("Enter your post and press enter to upload your post.");
            Post = Console.ReadLine();
            return Post;
        }

        public void ViewPost()
        {
            Console.WriteLine(Post);
        }

        public int CastUpvote()
        {
            Upvotes += 1;
            return Upvotes;
        }

        public int CastDownvote()
        {
            Downvotes += 1;
            return Downvotes;
        }

        public void DisplayVotes()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Upvotes : " + Upvotes);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Downvotes : " + Downvotes);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stackoverflow = new Stackoverflow();

            Console.WriteLine("Enter 1 to upload the post," +
                "2 to view the post," +
                "3 to cast upvote," +
                "4 to cast downvote," +
                "5 to view votes," +
                "6 to exit.");

            var ToExit = true;
            while (ToExit == true)
            {
                int caseSwitch = Convert.ToInt32(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        stackoverflow.UploadPost();
                        break;
                    case 2:
                        stackoverflow.ViewPost();
                        break;
                    case 3:
                        stackoverflow.CastUpvote();
                        break;
                    case 4:
                        stackoverflow.CastDownvote();
                        break;
                    case 5:
                        stackoverflow.DisplayVotes();
                        break;
                    case 6:
                        Console.WriteLine("exit");
                        ToExit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
        }
    }
}
