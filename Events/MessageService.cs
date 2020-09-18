using System;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("Messageservice is sending a message...." + e.video.Title);
        }
    }
}