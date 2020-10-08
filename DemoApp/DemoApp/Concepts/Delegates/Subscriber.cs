using System;

namespace DemoApp.Concepts.Delegates
{
    public class Subscriber
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public void Subscribe(YouTubePublisher publisher)
        {
            publisher.VideoUploaded += VideoUploaded;
        }

        public void VideoUploaded(object sender, VideoUploadedEventArgs e)
        {
            var _publisher = (YouTubePublisher)sender;
            Console.WriteLine(UserName + "\n\t" + _publisher.UserName + " - " + e.VideoName);
        }
    }
}
