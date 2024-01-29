﻿namespace HotelProject.EntityLayer.Concrete
{
    public class SendMessage
    {
        public int SendMessageId { get; set; }
        public string? ReceiverName { get; set; }

        public string? ReceiverMail { get; set; }

        public string? SenderName { get; set; }

        public string? SenderMail { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public DateTime Date { get; set; }
    }
}
