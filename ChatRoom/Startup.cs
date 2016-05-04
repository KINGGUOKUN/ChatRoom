using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;
using Microsoft.AspNet.SignalR;
using ChatRoom.Hubs;

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
            GlobalHost.HubPipeline.AddModule(new ExceptionPipelineModule());
            builder.MapSignalR();
        }
    }
}