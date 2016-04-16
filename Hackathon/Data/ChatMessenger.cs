using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Data
{
    public class ChatMessenger:BaseEntity
    {

        public int UserId { get; set; }

        public int ChatId { get; set; }

        public string Message { get; set; }
    
        public DateTime Timestamp { get; set; }
    }
}