using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(ChatRoom.Startup))]

namespace ChatRoom
{
    /// <summary>
    /// SignalR启动器
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.MapSignalR();
        }
    }
}