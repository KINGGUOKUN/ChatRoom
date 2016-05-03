using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatRoom.Hubs
{
    public class ChatHub : Hub<IChat>
    {
        /// <summary>
        /// 发送消息至终端
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
        public void Send(string name, string message)
        {
            Clients.All.AppendMessage(name, message);
        }
    }
}