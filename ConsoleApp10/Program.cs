using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        private static int _action { get; set; }
        private static int _countDay { get; set; }
        private static string _card { get; set; }
        private static int _id { get; set; }
        private Yacht _yacht { get; set; }
        public static List<User> Users { get; set; }

        private static List<Yacht> _yachts { get; set; }
        static void Main(string[] args)
        {

                Users = new List<User>();

                _yachts = new List<Yacht>()
            {
                new Yacht(1, "MAXUS 22 PRESTIGE", "2011", 4, false, 10000,false),
                new Yacht(2, "MAXUS 24 PRESTIGE", "2013", 7, false,10000,true),
                new Yacht(3, "MAXUS 26 PRESTIGE", "2001",8, false, 10000,false),
                new Yacht(4, "SUN ODYSSEY 29.2", "2012", 2,false, 10000,false),
                new Yacht(5, "SUN FAST 26", "2013", 8,  true, 10000,true),
                new Yacht(6, "SUN ODYSSEY 40", "2014", 5, true, 10000,true),
                new Yacht(7, "FIRST 25.7", "2017", 6 , true, 10000,true),
                
            };

                while (_action != 4)
                {
                    ListCommand();
                    Console.Write("Enter command: ");
                    _action = int.Parse(Console.ReadLine());
                    switch (_action)
                    {
                        case 1:
                            foreach (var item in _yachts)
                            {
                                Console.WriteLine(item.GetInfo());
                            }
                            Console.Write(" ID yacht: ");
                            _id = int.Parse(Console.ReadLine());
                            var activ = _yachts.FirstOrDefault(item => item.ID == _id).Status;
                            if (activ == false)
                            {
                                _card = _yachts.FirstOrDefault(item => item.ID == _id).Key;
                                Console.Write("Specify the number of days: ");
                                _countDay = int.Parse(Console.ReadLine());
                                var yachtSelected = _yachts.FirstOrDefault(item => item.ID == _id);
                                Users.Add(Rent(new User(),_card, _countDay));
                            yachtSelected.Status = true;
                                Console.WriteLine("Yacht is rented");
                                Console.WriteLine($"Amount to be paid: { yachtSelected.Money * _countDay} $ | to {_countDay} days");


                            using (FileStream stream = new FileStream($"{Environment.CurrentDirectory}/users.csv", FileMode.Create))
                            {
                                using (StreamWriter sw = new StreamWriter(stream))
                                {
                                    sw.WriteLine("ID;Имя;Фамилия;Отчество;Год рождения;Пол;Серия паспрта;Номер паспорта;Адрес регистрации;Дата выдачи;Код подразделения;Кем был выдан;");
                                    foreach (var item in Users)
                                    {
                                        sw.WriteLine($"{item.ID};{item.Name};{item.Surname};{item.Patronymic};{item.DateOfBirth};{item.Gender};{item.Seria};{item.Number};{item.Address};{item.DateOfIssue};{item.DepartmentCode};{item.issuedBy};");
                                    }
                                }
                            }
                        }
                        else
                            {
                                Console.WriteLine("Error");
                            }
                            break;
                        case 2:

                            break;
                        case 3:
                            foreach (var item in Users)
                            {
                                Console.WriteLine(item.GetInfo());
                            }
                            break;

                    }
                }
            }
            static void ListCommand()
            {
                Console.WriteLine("1. Арендовать яхту");
                Console.WriteLine("2. Отменить аренду");
                Console.WriteLine("3. Вывести данные арендатора");
                
            }

            public static User Rent(User user, string card, int _countDay)
            {
                if (user.ID == 0)
                {
                    user = new User();
                    Console.Write("Введите ID клиента: ");
                user.ID = int.Parse(Console.ReadLine());

                }
                Console.Write("Введите имя: ");
            user.Name = Console.ReadLine();
                Console.Write("Введите фамилию: ");
            user.Surname = Console.ReadLine();
                Console.Write("Введите отчество: ");
            user.Patronymic = Console.ReadLine();
                Console.Write("Введите год рождения: ");
            user.DateOfBirth = DateTime.Parse(Console.ReadLine());
                Console.Write("Введите пол: ");
            user.Gender = Console.ReadLine();
                Console.Write("Введите серия паспорта: ");
            user.Seria = Console.ReadLine();
                Console.Write("Введите номер паспорта: ");
            user.Number = Console.ReadLine();
                Console.Write("Введите адрес регистрации: ");
            user.Address = Console.ReadLine();
                Console.Write("Введите дата выдачи паспорта: ");
            user.DateOfIssue = DateTime.Parse(Console.ReadLine());
                Console.Write("Введите код подразделения: ");
            user.DepartmentCode = Console.ReadLine();
                Console.Write("Введите кем был выдан: ");
            user.issuedBy = Console.ReadLine();
                Console.Write("Количество дней: ");
            user.CheckInDate = DateTime.Now;
            user.Card = card;
                return user;
            }
        }
    }
