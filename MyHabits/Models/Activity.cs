using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHabits.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Reward { get; set; }
        public string Tag { get; set; }
        public int UserId { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Name} = {Reward}";
        }
    }
}
