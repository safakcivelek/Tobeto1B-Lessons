// 8.Oturum

using Intro;

CourseIntro course1 = new CourseIntro();
course1.Id = 1;
course1.Name = "C#";
course1.Description = "OOP Intro";
course1.Price = 20;
course1.ImageUrl = "Image.png";

CourseIntro course2 = new CourseIntro();
course1.Id = 2;
course1.Name = "Java";
course1.Description = "OOP Intro";
course1.Price = 20;
course1.ImageUrl = "Image.png";

course1 = course2;
course1.Name = "JavaScript";

Console.WriteLine(course2.Name);
course2.Price = 100;
Console.WriteLine(course1.Price);

//1 kursta 1den çok eğitmen olsun
// Veritabanı olmayacak !
// category, eğitmen ve kurs ilişkisi nesnelleştir!