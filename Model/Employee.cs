﻿namespace csharp_dependencyinjection.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public List<Leave> Leaves { get; set; }

    }
}
