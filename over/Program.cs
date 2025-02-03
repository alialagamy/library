using System.Numerics;

namespace over
{
class Person
{
public string Name { get; set; }
public int Age { get; set; }
public string Address { get; set; }
public string Nationality { get; set; }
public Person(string name = "ali",int age =22 ,string address = "244555e",string nationality = "Egyptian")
 {
    Name = name;
    Age = age;
    Address = address;
    Nationality = nationality;
  }
 }
class Student : Person
{
public int StudyLevel { get; set; }
public string Specialization { get; set; }
public double GPA { get; set; }
public Student(string name = "John",int age = 18,string address = "123 Street",string nationality = "Egyptian",int studyLevel = 1,string specialization = "CS",double gpa = 2.5): base(name, age, address, nationality)
{
StudyLevel = studyLevel;
Specialization = specialization;
GPA = gpa;
}
}

internal class Program
    {
        
        static void Main(string[] args)
        {
            
        }
    }
}
