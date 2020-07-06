using System;

namespace Observer
{
    public struct Message
    {
        public readonly string Sender;
        public readonly string Receiver;
        public readonly string Content;

        public Message(string sender, string receiver, string content)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Content = content;
        }

        public override string ToString()
        {
            return $"From: {this.Sender}{Environment.NewLine}To: {this.Receiver}{Environment.NewLine}Message: {this.Content}";
        }
    }
}
