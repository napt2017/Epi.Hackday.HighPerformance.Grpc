using System;

namespace DB.Access.Entities
{
    public class HackdayTopic
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Author { get; set; }
        public string Office { get; set; }
    }
}
