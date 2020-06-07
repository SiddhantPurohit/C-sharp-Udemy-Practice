//A mechanism for communication between objects.
//used in building loosely coupled Applications.
//Helps extending apllications.

using System;
using System.Threading;

namespace Events_and_delegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video{ get; set; }
    }
    public class Video
    {
        public string Title { get; set; }
    }

    public class videoEncoder
    {
        //1 Define a delegate
        //2 define a event based on that delegate
        //3 raise the event

        public delegate void VideoEncoderEventHAndler(object source, VideoEventArgs args); //1
        //In built delegates on .Net Frame work available namely EventHandler

        public event VideoEncoderEventHAndler VideoEncoded; //2

        public void Encode (Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video) //3
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() {Video = video });
            }
        }
    }

    public class MailService
    {
        public void OnVideoEncoded (object source, VideoEventArgs args)
        {
            Console.WriteLine("Mail Service : Sending the Email..." + args.Video.Title);
        }
    }

    public class TestMessage
    { 
        public void OnVideoEncoded (Object source , VideoEventArgs args)
        {
            Console.WriteLine("Message service : Sending the text..." + args.Video.Title);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Video1" };
            var videoencoder = new videoEncoder(); //Publisher
            var mailservice = new MailService(); //Subscriber
            var messageservice = new TestMessage(); //subsciber

            videoencoder.VideoEncoded += mailservice.OnVideoEncoded; //subscription
            videoencoder.VideoEncoded += messageservice.OnVideoEncoded; //subscription

            videoencoder.Encode(video);
        }
    }
}
