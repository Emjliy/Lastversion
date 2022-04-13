using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Group
    {

        public static List<Group> groups = new List<Group>();
        public string GroupNo { get; set; }
        public bool IsOnline { get; set; }
        public int Limit { get; set; }
        public string Category { get; set; }
        public static Student[] students = new Student[0];

        //public Categories Categories { get; }
        //public static int programming = 200;
        //public static int design = 200;
        //public static int systemadministration = 200;
        //switch (category)
        //{
        //    case Categories.Programming:
        //        GroupName = $"BP{programming}";
        //        programming++;
        //        break;
        //    case Categories.Design:
        //        GroupName = $"BP{design}";
        //        design++;
        //        break;
        //    case Categories.SystemAdmiration:
        //        GroupName = $"BP{systemadministration}";
        //        systemadministration++;
        //        break;
        //    default:
        //        Console.WriteLine("Bele bir kategoriya yoxdur");
        //        break;
        //}Categories = category;
        public Group()
        {
            Console.WriteLine("Enter GroupNo ");
            GroupNo = Console.ReadLine();
            foreach (var item in groups)
            {

                if (GroupNo == item.GroupNo)
                {
                    Console.WriteLine("Please enter other GroupNo this one is exist");
                    string newNo = Console.ReadLine();
                    foreach (var checkitem in groups)
                    {
                        if (checkitem.GroupNo == newNo)
                        {
                            Console.WriteLine("Please enter other GroupNo this one is exist");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }


            Console.WriteLine("Enter Category ");
            Category = Console.ReadLine();
            Console.WriteLine("Online or Not");
            IsOnline = Convert.ToBoolean(Console.ReadLine());
            if (IsOnline)
            {
                Console.WriteLine("Group is online");
                Console.WriteLine("Limit is assignd as 15");
                Limit = 15;
            }
            else
            {
                Console.WriteLine("Group is ofline");
                Console.WriteLine("Limit is assignd as 10");
                Limit = 10;
            }
        }
        public static void ShowInfo()
        {
            foreach (var item in groups)
            {
                Console.WriteLine($"{item.GroupNo} {item.Category}");
            }
        }
        public static void ChangeNo()
        {
            Console.WriteLine("Enter any old GroupNo for changing");
            string findNo = Console.ReadLine();
            bool isExist = true;
            foreach (var item in groups)
            {
                if (item.GroupNo == findNo)
                {
                    Console.WriteLine("FOUND-now you can change exist GrooupNo with new one");
                    string newNo = Console.ReadLine();
                    Console.WriteLine($"new GroupNo was changed-{item.GroupNo = newNo}");
                    isExist = false;
                }
            }
            if (isExist)
            {
                Console.WriteLine("YOU CAN'T CHANGE!There is no GroupNo like this");
            }
        }
        public static void ShowStudentsinGroup()
        {
            Console.WriteLine("Enter GroupNo-which Group Students do you want to see");
            string GroupNo = Console.ReadLine();
            bool isExist = true;
            foreach (var item in groups)
            {
                if (item.GroupNo == GroupNo)
                {
                    isExist = false;
                    //break;
                }
            }
                foreach (var items in students)
                {
                    if (items.GroupNo == GroupNo)
                    {
                        Console.WriteLine("Show Students in this Group");
                        Console.WriteLine($"{items.FullName} {items.GroupNo}");//studentsi goster
                        isExist = false;
                    }
                }
                if (isExist)
                {
                    Console.WriteLine("There is no GropNo like this");
                }
            }
        }
    }
