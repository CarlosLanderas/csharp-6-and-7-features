using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.features._6._0
{
    public class NullConditionalOperator : IRunnable
    {
        public void Run()
        {
            var customer1 = new Customer()
            {
                Name = "Pedro",
                ClientType = ClientType.VIP
            };

            LogCustomer(customer1);            

            customer1.OnCustomerSaved += (e, c) =>
            {
                Console.WriteLine("Customer Saved");
            };

            customer1.Save();

            LogCustomer(null);

        }

        public void LogCustomer(Customer customer)
        {
            string customerName = customer?.Name;
            var clientType = customer?.ClientType ?? ClientType.Standard;
            var street = customer?.Address?.Street ?? "NoStreet";
            int? postalCode = customer?.Address?.PostalCode;
            
            Console.WriteLine($"Name: {customerName} - Client Type: {clientType.ToString()}" +
                $" - Street: {street} - PostalCode: {postalCode}");
        }


        public class Customer
        {
            public EventHandler<Customer> OnCustomerSaved { get; set; }
            public string Name { get; set; }
            public ClientType ClientType { get; set; }
            public Address Address { get; set; } 
            
            public void Save()
            {
                OnCustomerSaved?.Invoke(this, this);
            }

        }

        public enum ClientType
        {
            Standard,
            Employee,
            VIP
        }

        public class Address
        {
            public string Street { get; set; }
            public int? PostalCode { get; set; }
        }
    }
}
