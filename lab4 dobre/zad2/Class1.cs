using System;
using System.Collections.Generic;
using System.Text;

namespace dupa.zad2
{
    public abstract class Person
    {
        public string FirstName;
        public string Surname;
        public string Pesel;

        public void SetFirstName (string firstName)
        {
            FirstName = firstName
        }

        public void SetLastName(string lastName)
        {
            Surname = lastName
        }
        public void SetPesel(string pesel)
        {
            Pesel = pesel
        }

        public string GetGender() => int.Parse(Pesel[9].ToString()) % 2 == 0 ? "Woman" : "Man";

        public int GetAge()
        {
            return new DateTime(year, month, day);
        }
        private DateTime GetBirthDay()
        {
            var year = int.Parse(Pesel.Substring(0, 2));
            var month = int.Parse(Pesel.Substring(2, 4));
            var day = int.Parse(Pesel.Substring(4, 6));
            if (month > 80)
            {
                year = year + 1800;
                month = month - 80;
            }
            else if (month > 60)
            {
                year = year + 2200;
                month = month - 60;
            }
            else if (month > 40)
            {
                year = year + 2100;
                month = month - 40;
            }
            else if (month > 20)
            {
                year = year + 2000;
                month = month - 20;
            }
            return new DateTime(year, month, day);
        }

        public abstract string GetEducationInfo();
        public abstract string GetFullName();
        public abstract string CanGoAloneToHome();
    }

    public class Student : Person
    {
        public string School { get; set; }
        public string CanGoHomeAlone { get; set; }
        public void SetSchool (string school)
        {
            if (string.IsNullOrEmpty(School))
                School = school;
            else
                throw new Exception("School is set");
        }
        public void ChangeSchool(string newschool)
        {
            School = newschool;
        }
        public void SetCanGoHomeAlone(bool CanGo)
        {
            CanGoHomeAlone = CanGo;
        }

        public string Info()
        {
            if (GetAge() >= 12)
                return "Ma wiecej niz 12 lat";
            else
            return "Nie ma zgody i ma mniej niz 12 lat";
        }
        public override string GetEducationInfo()
        {
            throw new NotImplementedException();
        }

        public override string GetFullName()
        {
            throw new NotImplementedException();
        }

        public override string CanGoAloneToHome()
        {
            throw new NotImplementedException();
        }
    }

    public class Teacher : Student
    {
        public string Title { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public override string GetFullName()
        {
            return $"(title) (base.GetFullName())";
        }

        public void WhichStudentCanGo()
        {

        }

        public void DisplayClass(DateTime date)
        {
            Console.WriteLine($"{GetEducationInfo()} Day {date.DayOfWeek}");
            Console.WriteLine($"Nauczyciel {GetFullName()}");
            Console.WriteLine(GetEducationInfo());
            var i = 0;
            foreach (var student in Students)
            {
                Console.WriteLine($"{i} {GetFullName()} - {GetGender()} - ")
                i++
            }
        }
    }
}
