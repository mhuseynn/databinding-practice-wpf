using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databinding_start
{
    public class Message
    {
        
        public Message(string text, DateTime date)
        {
            this.text = text;
            this.date = date;
        
        }

        public string text { get; set; }

        public DateTime date { get; set; }


        public override string ToString()
        {
            return $"{text}\t\t{date.TimeOfDay.Hours.ToString()}:{date.TimeOfDay.Minutes.ToString()}";
              
        }


    }
}
