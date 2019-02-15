using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejyle.DevAccelerate.Samples.AspNetMvc.Models
{
    public class MessageViewModel
    {
        public MessageViewModel()
        {
            MessageType = MessageType.Error;
            Body = "Oops, something went wrong.";
        }

        public MessageViewModel(MessageType messageType, string body)
        {
            MessageType = messageType;
            Body = body;
        }

        public MessageType MessageType
        {
            get;
            set;
        }

        public string Body
        {
            get;
            set;
        }
    }

    public enum MessageType
    {
        Info = 0,
        Success = 1,
        Warning = 2,
        Error = 3
    }
}