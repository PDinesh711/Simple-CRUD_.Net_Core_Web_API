﻿namespace WebApplication1.models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
