using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SChat.Models;

namespace SChat.Models
{
  public  class ChatListResponse
    {
        public IList<chatList> ChatLists { get; set; }
    }
}
