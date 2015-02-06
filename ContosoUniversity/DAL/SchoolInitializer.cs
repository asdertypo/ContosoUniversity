using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;
using System.Data.Entity;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer:System.Data.Entity. DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            //base.Seed(context);
            var students = new List<Student>
            {
                new Student{FirstMidName="张",LastName="三",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMidName="李",LastName="四",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="杨",LastName="扬",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="黄",LastName="飞鸿",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="张",LastName="三丰",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="公孙",LastName="止",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMidName="宁",LastName="缺",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="叶",LastName="问",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>{
                new Course{CourseID=1050,Title="化学",Credits=3,},
                new Course{CourseID=4022,Title="微观经济学",Credits=3,},
                new Course{CourseID=4041,Title="宏观经济学",Credits=3,},
                new Course{CourseID=1045,Title="微积分",Credits=4,},
                new Course{CourseID=3141,Title="三角学",Credits=4,},
                new Course{CourseID=2021,Title="写作",Credits=3,},
                new Course{CourseID=2042,Title="文学赏析",Credits=4,}
            };
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}