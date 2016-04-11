using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Models
{
    public class ChatContent
    {
        /// <summary>
        /// 发言人
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 发言内容
        /// </summary>
        public string Content { get; set; }
    }
}
