using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therapeutic_department
{
    internal class Pacient
    {
        public string FullName;
        public DateOnly DateOfBirth;
        public DateOnly DateOfreceipt;
        public DateOnly DateOfdischarge;
        static int numberofpatients;
        public int soverch;
        public string Name;
        public Pacient()
        {

            Console.WriteLine("Введите ФИО");
            

            while (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Введите еще раз");
                Console.ReadLine();
                if (string.IsNullOrEmpty(Name))
                {
                    Console.WriteLine("Введите еще раз");
                    Console.ReadLine();
                }
                else Name = FullName;
            }
            //string FullName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("все ок");
                DateOfBirth = new DateOnly(2000, 3, 24);
                DateOfreceipt = new DateOnly(2020, 5, 1);
                DateOfdischarge = new DateOnly(2020, 5, 9);
                numberofpatients = 1;
                var today = DateOnly.FromDateTime(DateTime.Now);
            
            


        }
        public void Print()
        {
            Console.WriteLine($"ФИО: {FullName}, Дата рождения: {DateOfBirth}, Дата поступления: {DateOfreceipt}, Дата выписки: {DateOfdischarge}, {numberofpatients}");
        }
        //public void Soverch()
        //{
        //    var today = DateOnly.FromDateTime(DateTime.Now);
        //    var birth = DateOnly.DateOfBirth;
        //    var soverch = today - DateOfBirth;
        //    var today1 = DateTime.FromDateOnly(DateOfBirth);
        //}
        public Pacient(string fullName, DateOnly dateOfBirth)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentException("ФИО не может быть пустым");
            }
        }
    }
}