using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i != 0; i++)
            {
                Console.WriteLine($"1. Yeni qrup yarat\n2.2. Qrupların siyahısını göstər," +
                $"3. Qrup üzərində düzəliş etmək\n4. Qrupdakı tələbələrin siyahısını göstər" +
                $"5. Bütün tələbələrin siyahısını göstər\n6.Telebe yarat");
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
