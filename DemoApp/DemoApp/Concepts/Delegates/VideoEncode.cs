using System;

namespace DemoApp.Concepts.Delegates
{
    public class VideoEncode
    {

        //public delegate void VideoEncodedHandler(object sender, EventArgs eventArgs);

        //public event VideoEncodedHandler VideoEncoder;

        public EventHandler<VideoEventArg> VideoEncoder;

        public void Encode(Video video)
        {
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoder != null)
            {
                //VideoEncoder(this, EventArgs.Empty);

                VideoEncoder(this, new VideoEventArg() { Video = video });
            }
        }
    }

    public class Video
    {
        public string Title { get; set; }

    }

    public class MailService
    {
        public void VedionEncoded(object sender, VideoEventArg eventArgs)
        {

            Console.WriteLine("{0} Mail has been sent...", eventArgs.Video.Title);
        }
    }

    public class MessageService
    {
        public void VedionEncoded(object sender, VideoEventArg eventArgs)
        {

            Console.WriteLine("{0} Message has been sent...", eventArgs.Video.Title);
        }
    }

    public class VideoEventArg : EventArgs
    {
        public Video Video { get; set; }
    }
}
