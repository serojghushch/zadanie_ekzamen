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


            person.Show();


            person.ShowAll();
            Console.ReadKey();
        }
    }
}
