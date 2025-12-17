using System;

namespace OOP_001
{
    class Account
    {
        private string OwnerName;
        private string Id;
        private int Balance;

        public Account(string ownerName, string id, int balance)
        {
            this.OwnerName = ownerName;
            this.Id = id;
            this.Balance = balance;
        }

        public void ShowInfo()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Account Owner   : {this.OwnerName}");
            Console.WriteLine($"Account Adress  : {this.Id}");
            Console.WriteLine($"Account Balance : {this.Balance:N0}円");
            Console.WriteLine("-----------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProcessAccount("高橋", "1000-0000-0000-00", 50000);
            ProcessAccount("鈴木", "2000-0000-0000-00", 100000);
        }

        static void ProcessAccount(string OwnerName, string Id, int Balance)
        {
            Account user = new Account(OwnerName, Id, Balance);
            user.ShowInfo();
        }
    }
}