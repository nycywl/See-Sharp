﻿class TeacherInfo
{
    public string ClassName { get; set; }
    public string Teacher { get; set; }
}

class StudentInfo
{
    public string ClassName { get; set; }
    public string Student { get; set; }
}

class ResultInfo
{
    public string ClassName { get; set; }
    public string Teacher { get; set; }
    public string Student { get; set; }
}

static List<TeacherInfo> CreateTeachers()
{
    return new List<TeacherInfo>()
    {
        new TeacherInfo {ClassName = "1A", Teacher = "魯夫" },
        new TeacherInfo {ClassName = "1A", Teacher = "索隆" }
    };
}

static List<StudentInfo> CreateStudents()
{
    return new List<StudentInfo>()
    {
        new StudentInfo {ClassName = "1A", Student = "魯夫" },
        new StudentInfo {ClassName = "1A", Student = "索隆" },
        new StudentInfo {ClassName = "1B", Student = "櫻木" },
        new StudentInfo {ClassName = "1A", Student = "香吉士"},
        new StudentInfo {ClassName = "1B", Student = "流川楓"}
    };
}

static void Main(string[] args)
{
    var teachers = CreateTeachers();
    var students = CreateStudents();
    var result =
        from t in teachers
        join s in students
        on t.ClassName equals s.ClassName
        select
        new ResultInfo
        { ClassName = t.ClassName, Teacher = t.Teacher, Student = s.Student };
    foreach (var item in result)
    {
        Console.WriteLine($"{item.ClassName} : {item.Teacher} : {item.Student}");
    }
    Console.ReadLine();
}
