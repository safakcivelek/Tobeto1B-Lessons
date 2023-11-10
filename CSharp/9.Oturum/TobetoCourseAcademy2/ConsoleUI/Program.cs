
using Bussiness.Concretes;
using Entities.Concretes;

Console.WriteLine("Kodlama.io Eğitim Kanalı");
Console.WriteLine("************************");
Console.WriteLine();

Course course = new Course()
{
    Id = 1,
    CategoryId = 1,
    InstructorId = 1,
    Name = "C#",
    Description = "Programlama dili",
    Price = 10,
    ImageUrl = "img.png"
};
Instructor instructor = new Instructor()
{
    Id = 1,
    CourseId = 1,
    FirstName = "Engin",
    LastName = "Demiroğ",
    Age = 30,
    Phone = "05555555555",
    Address = "İstanbul"
};
Category category = new Category()
{
    Id = 1,
    Name = "Programlama",
    Description = "Programlama dilleri"
};

CourseManager courseManager = new CourseManager();
courseManager.Get(course);
Console.WriteLine();

InstructorManager instructorManager = new InstructorManager();
instructorManager.Get(instructor);
Console.WriteLine();

CategoryManager categoryManager = new CategoryManager();
categoryManager.Get(category);
Console.WriteLine();


Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine($"Kategori Adı{"Kurs Adı",20}{"Eğitmen Adı",20}");
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine($"{category.Name}{course.Name,18}{instructor.FirstName+" "+instructor.LastName,23}");
Console.ReadLine();