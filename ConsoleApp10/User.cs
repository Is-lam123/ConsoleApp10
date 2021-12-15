using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
     public class User
    {
        
            internal int ID { get; set; }
            internal string Name { get; set; }
            internal string Surname { get; set; }
            internal string Patronymic { get; set; }
            internal DateTime DateOfBirth { get; set; }
            internal string Gender { get; set; }
            internal string Seria { get; set; }
            internal string Number { get; set; }
            internal string Address { get; set; }
            internal DateTime DateOfIssue { get; set; }
            internal string DepartmentCode { get; set; }
            internal string issuedBy { get; set; }
           

            internal DateTime CheckInDate { get; set; }
            internal string Card { get; set; }


            internal string GetInfo()
            {
                if (!string.IsNullOrEmpty(Name) || !string.IsNullOrEmpty(Surname) || !string.IsNullOrEmpty(Card))
                {
                    return $"Name: {Name} Surname: {Surname} Rental Card: {Card}";
                }
                else
                {
                    return "Error!Not found...";
                }
            }
        }
    }

