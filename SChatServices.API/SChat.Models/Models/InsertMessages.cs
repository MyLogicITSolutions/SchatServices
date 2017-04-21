using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SChat.Models
{
   public class InsertMessages
    {
        public string InsertMessage { get; set; }
        public int sender_id { get; set; }
        public int receiver_id { get; set; }
    }
}
