using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Hubs
{
    public interface IChat
    {
        void AppendMessage(string name, string message);
    }
}
