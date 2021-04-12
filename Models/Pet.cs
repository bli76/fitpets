using System;

namespace FitPETZ.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string PlayerID { get; set; }
        public string Name { get; set; }
        public string Animal { get; set; }
        public DateTime Birthday { get; set; }
        public User User { get; set; }
    }
}