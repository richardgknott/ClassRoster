using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2nListsUI
{
      class Program
      {
            static void Main(string[] args)
            {
                  List<string> familyName = new List<string>();

                  familyName.Add("Richard");
                  familyName.Add("Marisela");
                  familyName.Add("Richie");
                  familyName.Add("Jocelynn");

                  Console.WriteLine($"The second element is {familyName[1]}.");

                  familyName.Remove("Marisela");

                  Console.WriteLine($"The second element is {familyName[1]}.");

                  familyName[1] = familyName[1].ToUpper();

                  foreach(string name in familyName)
                  {
                        Console.WriteLine($"My name is {name}.");
                  }


                  Console.ReadLine();
            }
      }
}
