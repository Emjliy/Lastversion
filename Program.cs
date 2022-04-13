using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i != 0; i++)
            {
                Console.WriteLine($"1.Yeni qrup yarat\n2.Qrupların siyahısını göster\n" +
                $"3.Qrup üzerinde düzeliş etmek\n4.Qrupdakı telebelerin siyahısını goster\n" +
                $"5.Bütün telebelerin siyahısını goster\n6.Telebe yarat");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {

                    case 1:
                        Group group1 = new Group();
                        Group.groups.Add(group1);
                        break;
                    case 2:
                        Group.ShowInfo();
                        break;
                    case 3:
                        Group.ChangeNo();
                        break;
                    case 4:
                        Group.ShowStudentsinGroup();
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            }

        }
    }
}
