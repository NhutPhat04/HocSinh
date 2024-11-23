using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo danh sách sinh viên
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Nguyen Tien A", Age = 19 });
            students.Add(new Student { Id = 2, Name = "Dang Le H", Age = 15 });
            students.Add(new Student { Id = 3, Name = "Chu Quoc T", Age = 14 });
            students.Add(new Student { Id = 4, Name = "Nguyen Thi Kim N ", Age = 18 });
            students.Add(new Student { Id = 5, Name = "Nguyen Thanh D", Age = 20 });

            // a. In ra danh sach hoc sinh
            Console.WriteLine("DANH SACH HOC SINH");
            students.ForEach(x => Console.WriteLine($"Id: {x.Id}, Name: {x.Name}, Age: {x.Age}"));
            Console.ReadLine();

            // b. Tim va in ra danh sach cac hoc sinh co tuoi tu 15 den 18
            var age = students.Where(x => x.Age >= 15 && x.Age <= 18).ToList();
            Console.WriteLine("Thong tin sinh vien tu 15 den 18 tuoi");
            foreach (var student in age)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.ReadLine();

            // c. Tim va in ra danh sach hoc sinh bat dau bang chu A
            var namewithA = students.Where(x => x.Name.StartsWith("A")).ToList();
            if (namewithA.Any())
            {
                Console.WriteLine("Thong tin sinh vien co ten bat dau bang chu A");
                foreach (var student in namewithA)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }
            }
            else
            {
                Console.WriteLine("Khong co thong tin sinh vien bat dau bang chu A trong danh sach!");
            }
            Console.ReadLine();

            // d. Tinh tong tuoi cua tat ca ca sinh vien trong danh sach
            int Tongtuoi = students.Sum(x => x.Age);
            Console.WriteLine("Tong tuoi cua tat ca sinh vien trong danh sach la: " + Tongtuoi);
            Console.ReadLine();

            // e. Tim va in ra hoc sinh co tuoi lon nhat 
            var maxAge = students.OrderByDescending(x => x.Age).First();
            Console.WriteLine("Thong tin sinh vien co tuoi cao nhat: ");
            Console.WriteLine($"Id: {maxAge.Id}, Name: {maxAge.Name}, Age: {maxAge.Age}");
            Console.ReadLine();

            // f. Sap xep danh sach theo thu tu tuoi tang dan
            var sort = students.OrderBy(x => x.Age).ToList();
            Console.WriteLine("Danh sach sinh vien theo thu tu tuoi tang dan:");
            sort.ForEach(x => Console.WriteLine($"Id: {x.Id}, Name: {x.Name}, Age: {x.Age}"));
            Console.ReadLine();
        }
    }
}