using System;

namespace feedback.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public String Teste { get; set; }

        public int ManagerId { get; set; }
        public CustomUser Manager { get; set; }
    }
}
