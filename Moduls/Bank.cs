using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSistemproject.Moduls
{
    //Clients[]
    //showCardBalance(BankCard)

    //Clients[]
    //showCardBalance(BankCard)
    internal class Bank
    {
        static int id=1;

        public Bank(string name)
        {
            Name=name;
            Clients=new List<Client>();
        }

        public int Id { get; set; } = ++id;
        public string Name { get; set; }
        
        public List<Client> Clients { get; set; }

        void addClient(string name, string surname, int age,decimal balance, int cardYears)
        {
            Clients.Add(new Client(name, surname, age, salary, Name, balance, cardYears));
        }
        
        void ShowClient()
        {
            foreach (Client client in Clients)
                   Console.WriteLine(client.ToString());
            
        }

    }
}
