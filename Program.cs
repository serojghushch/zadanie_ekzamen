using kushchyan_biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kushchyan_consolprilozh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Сергей", "Улица Примерная, 1");

            //Кушян Сергей 34 ИС
            person.AddHobby(new Hobby("Чтение", "Чтение книг различных жанров"));
            person.AddHobby(new Hobby("Путешествия", "Посещение новых стран и городов"));
            person.AddHobby(new Hobby("Спорт", "Занятия фитнесом и бегом"));

            Person person1 = new Person("Кирилл", "Улица Примерная, 1");

            //Кушян Сергей 34 ИС
            person1.AddHobby(new Hobby("Чтение", "Чтение книг различных жанров"));
            person1.AddHobby(new Hobby("Путешествия", "Посещение новых стран и городов"));
            person1.AddHobby(new Hobby("Спорт", "Занятия фитнесом и бегом"));
            Person person2 = new Person("Максим", "Улица Примерная, 1");

            //Кушян Сергей 34 ИС
            person2.AddHobby(new Hobby("Чтение", "Чтение книг различных жанров"));
            person2.AddHobby(new Hobby("Путешествия", "Посещение новых стран и городов"));
            person2.AddHobby(new Hobby("Спорт", "Занятия фитнесом и бегом"));


            person.Show();
            person1.Show();
            person2.Show();


            person.ShowAll();
            person1.ShowAll();
            person2.ShowAll();
            Console.ReadKey();
        }
    }
}
