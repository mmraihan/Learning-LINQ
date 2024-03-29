﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Inner_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>() 
            {
                new Student(){Id=1, Name="A-1", AddressId=1},
                new Student(){Id=2, Name="A-11", AddressId=0},
                new Student(){Id=3, Name="A-12", AddressId=2},
                new Student(){Id=4, Name="A-13", AddressId=2},
                new Student(){Id=5, Name="A-14", AddressId=3}
            };

            var addresses = new List<Address>()
            {
                new Address(){Id=1, AddressLine="Line-1" },
                new Address(){Id=2, AddressLine="Line-2" },
                new Address(){Id=3, AddressLine="Line-3" },
                new Address(){Id=4, AddressLine="Line-4" },
                new Address(){Id=5, AddressLine="Line-5" }
            };

            var marks = new List<Mark>()
            {
                new Mark(){Id=1, StudentId=1,TotalMarks=99},
                new Mark(){Id=2, StudentId=2,TotalMarks=94},
                new Mark(){Id=3, StudentId=3,TotalMarks=95},
            };

            var qs = (from student in students
                      join address in addresses
                      on student.AddressId equals address.Id

                      join mark in marks
                      on student.Id equals mark.StudentId
                      select new
                      {
                          StudentName = student.Name,
                          Address = address.AddressLine,
                          Totalmarks = mark.TotalMarks
                      }).ToList();


            Console.ReadLine();

        }
    }
}
