//2.LINQ

//Create two lists of Bank branches and Bank Managers with relevant properties  and perform the following operations
//1. display the branches and respective managers
//2. Display list of managers who are aged above 30  along with the branch name  
//3. Display the manager who has earned maximum points (create a property called maxpoint in branches)

//It will be great if both LINQ operator and LINQ expressions (lambda) are tried out. 


using System;
using System.Collections.Generic;
using System.Linq;

namespace Day13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating list for bank branches
            List<BankBranches> bankBranches = new List<BankBranches>();
            BankBranches bankBranchObjects = new BankBranches()
            {
                Id = 1,
                BranchName = "k.v.kuppam",
                MaxPoint = 20,
            };
            bankBranches.Add(bankBranchObjects);
            bankBranches.Add(new BankBranches
            {
                Id = 2,
                BranchName = "veppanganeri",
                MaxPoint = 30
            });
            bankBranches.Add(new BankBranches
            {
                Id = 3,
                BranchName = "katapadi",
                MaxPoint = 40
            });

            //creating list for bank managers
            List<BankManagers> bankManagers = new List<BankManagers>();
            BankManagers bankManagerObject = new BankManagers()
            {
                Id = 1,
                Name = "avvai shanmugi",
                Age = 40
            };
            bankManagers.Add(bankManagerObject);
            bankManagers.Add(new BankManagers
            {
                Id = 2,
                Name = "virumandi",
                Age = 35
            });
            bankManagers.Add(new BankManagers
            {
                Id = 3,
                Name = "uththama villain",
                Age = 28
            });

            //displaying the bank branches and their respective managers
            var managerAndBranch = bankManagers.Join(bankBranches, m => m.Id, b => b.Id, (m, b) =>
           new
           {
               managerName = m.Name,
               branchName = b.BranchName
           });
            foreach (var item in managerAndBranch)
            {
                Console.WriteLine($"Manager name: {item.managerName}" + ", " +
                    $"Branch name: {item.branchName}");
            }
            Console.WriteLine();

            //display the branch whose age is above 30
            var branchAndAge = from managerList in bankManagers
                               join branchList in bankBranches on managerList.Id equals branchList.Id
                               where managerList.Age > 30
                               select new { managerList.Id, managerList.Age, branchList.BranchName };
            Console.WriteLine("Managers whose age is greater than 30 are: ");
            foreach (var item in branchAndAge)
            {
                Console.WriteLine($"age: {item.Age} , branch name: {item.BranchName}");

            }
            Console.WriteLine();

            //who earned maximum points
            var maxPoints = from managerList in bankBranches
                            join branchList in bankManagers on managerList.Id equals branchList.Id
                            where managerList.MaxPoint > 20
                            select new { managerList.MaxPoint, branchList.Name };
            foreach (var item in maxPoints)
            {
                Console.WriteLine($"maximum points: {item.MaxPoint} manager name: {item.Name}");
            }


        }
    }
}
