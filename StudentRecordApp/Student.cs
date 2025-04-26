using System;


namespace StudentRecordApp
{
    public class Student{
        public int Id {get ; set;}
        public string Name {get ; set;}
        public string Surename {get ; set;}
        public int Age {get ; set;}
        public string Address {get ; set;}
        public string Course {get ; set;}
        public string Phone {get ; set;}
        public string Email {get ; set;}


        // constructor

        public Student(int Id, string Name, string Surename, int Age, string Address, string Course, string phone, string Email){
            this.Id = Id;
            this.Name = Name;
            this.Surename = Surename;
            this.Age = Age;
            this.Address = Address;
            this.Course = Course;
            this.Phone = phone;
            this.Email = Email;
        }

    }
}