using ConsoleApp4.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Group
    {
        public static List<Group> groups = new List<Group>();
        public string GroupNo { get; set; }
        public bool IsOnline { get; set; }
        public int Limit { get; set; }
        public string Category { get; set; }
        public Student[] students = new Student[0];

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
            Console.WriteLine("Enter Old GroupNo for changing");
            string findNo = Console.ReadLine();
            //Console.WriteLine("Enter New GroupNo ");
            //string newNo = Console.ReadLine();
            foreach (var item in groups)
            {
                if (item.GroupNo == findNo)
                {
                    Console.WriteLine("This GrooupNo is already exist.Please enter new one");
                    item.GroupNo = findNo;
                    break;
                }
            }
                    Console.WriteLine("There is group no like this");
                
            
        }





























    }
}
//        public string No { get; set; }
//        public string Category { get; set; }
//        public bool IsOnline { get; set; }
//        public int Limit { get; set; }
//        public Categories Categories { get; }
//        List<Student> std;

//        static int programming = 200;
//        static int design = 200;
//        static int SystemAdmiration = 200;
//        public Student[] students = new Student[0];

//        public Group(Categories Category,bool isonline)
//        {
//            switch (Category)
//            {
//                case Categories.Programming:
//                    No = $"BP{programming}";
//                    programming++;
//                    break;
//                case Categories.Design:
//                    No = $"BP{design}";
//                    design++;
//                    break;
//                case Categories.SystemAdmiration:
//                    No = $"BP{SystemAdmiration}";
//                    SystemAdmiration++;
//                    break;
//                default:
//                    Console.WriteLine("Bele bir kategoriya yoxdur");
//                    break;
//            }
//            Categories = Category;

//            Console.WriteLine("NO:");
//            No = Console.ReadLine();
//            ;
//            Console.WriteLine("IsOnline");
//            IsOnline = Convert.ToBoolean(Console.ReadLine());
//            if (IsOnline == true)
//            {
//                Console.WriteLine("Group is online");
//                Limit = 15;

//            }
//            else
//            {
//                Console.WriteLine("Group is ofline");
//                Limit = 10;
//            }


//        }
//        public void Add(Student st)
//        {
//            if (std.Count<Limit)
//            {
//                std.Add(st);
//            }
//            else
//            {
//                Console.WriteLine("doludur");
//            }


//        }
//        public void ShowAllInfo(Student st)
//        {
//            //Console.WriteLine($"{}{}{}");
//        }

//    }
//}
