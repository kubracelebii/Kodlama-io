using KodlamaCrud.Business.Concrete;
using KodlamaCrud.DataAccess.Concrete;
using KodlamaCrud.Entities.Concrete;
using KodlamaCrud.Business.Concrete;
using KodlamaCrud.DataAccess.Concrete;
using KodlamaCrud.Entities.Concrete;
using System.Collections.Generic;
using System;


internal class Program
{
    private static void Main(string[] args)
    {
       
        CourseManager courseManager = new CourseManager(new CourseDal());
        List<Course> courses = courseManager.GetAll();
        foreach (var course in courses)
        {
            Console.WriteLine(course.CourseName);
        }

        Console.WriteLine("---------Tüm Kategorilerimiz---------");
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        List<Category> categories = categoryManager.GetAll();
        foreach (var category in categories)
        {
            Console.WriteLine(category.CategoryName);
        }

        Console.WriteLine("---------Kurs Ekleme---------");
        Course course1 = new Course()
        {
            Id = 4,
            CategoryId = 3,
            InstructorId = 1,
            CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
            CourseDescription = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampı",
            CoursePrice = 100
        };
        courseManager.Add(course1);
        List<Course> courses1 = courseManager.GetAll();
        foreach (var course in courses1)
        {
            Console.WriteLine(course.CourseName);
        }

        Console.WriteLine("---------Kategori Ekleme---------");
        Category category1 = new Category()
        {
            Id = 4,
            CategoryName = "Yazılım"
        };
        categoryManager.Add(category1);
        List<Category> categories1 = categoryManager.GetAll();
        foreach (var category in categories1)
        {
            Console.WriteLine(category.CategoryName);
        }

        Console.WriteLine("---------Kurs Güncelleme---------");
        Course course2 = new Course()
        {
            Id = 4,
            CategoryId = 3,
            InstructorId = 1,
            CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
            CourseDescription = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampı",
            CoursePrice = 200
        };

        courseManager.Update(course2);
        List<Course> courses2 = courseManager.GetAll();
        foreach (var course in courses2)
        {
            Console.WriteLine(course.CourseName);
        }

        Console.WriteLine("---------Kurs Silme---------");
        courseManager.Delete(4);
        List<Course> courses3 = courseManager.GetAll();
        foreach (var course in courses3)
        {
            Console.WriteLine(course.CourseName);
        }
    }
}