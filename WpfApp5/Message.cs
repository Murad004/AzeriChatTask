using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Message
    {
        public string Text { get; set; }

        public string time { get; set; }

        public override string ToString()
        {
            return $"{Text} {time}";
        }
    }
}
