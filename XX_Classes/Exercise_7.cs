using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp.XX_Classes
{
    class Exercise_7
    {
        static List<Customer> CustomerList = new List<Customer>();
        static List<Product> ProductList = new List<Product>();
        static List<Invoice> InvoiceList = new List<Invoice>();
        public static void Start()
        {
            while(true)
            {
                //Schreiben Sie ein Menü (auch gerne in einer neuen Methode), in dem der Nutzer Auswählen kann, ob er einen Kunden, ein Produkt oder eine Rechnung erstellen kann. Geben Sie ihm auch die Möglichkeit, zu einer Rechnung Produkte hinzuzufügen und zu löschen.
                //Code Start

                //Code Ende
            }

        }

        //Ergänzen Sie diese Methode, sodass ein Anwender hier einen neuen Kunden erstellen kann. Dieser soll dann in die CustomerList gespeichert werden.
        static void CreateNewCustomerAndAddToList()
        {
            //Code Start

            //Code Ende
        }
        //Ergänzen Sie diese Methode, sodass ein Anwender hier einen neues Produkt erstellen kann. Dieser soll dann in die ProductList gespeichert werden.
        static void CreateNewProductAndAddToList()
        {
            //Code Start

            //Code Ende
        }
        //Ergänzen Sie diese Methode, sodass ein Anwender hier eine neue Rechnung erstellen kann. Dieser soll dann in die InvoiceList gespeichert werden.
        static void CreateNewInvoiceAndAddToList()
        {
            //Code Start

            //Code Ende
        }
        //Ergänzen Sie diese Methode, sodass ein Anwender hier ein Produkt zu einer Rechnung hinzufügen kann.
        static void AddElementToInvoice(Invoice inv)
        {
            
        }
        //Ergänzen Sie diese Methode, sodass ein Anwender hier ein Produkt von einer Rechnung löschen kann. 
        static void DeleteElementToInvoice(Invoice inv)
        {
            
        }
    }
    class Product
    {
        public string? Name = null;
        public decimal Price = 0;
    }
    class Invoice
    {
        public Customer? Cust = null;
        public List<Item> Items = new List<Item>();

        //Schreiben Sie hier eine Methode, die die Anzahl aller einzelnen Elemente zurückgibt

        //Schreiben Sie hier eine Methode, die die Anzahl der verschiedenen Produkte zurückgibt

        //Schreiben Sie hier eine Methode, die den Gesamtpreis der Rechnung zurück gibt
    }
    class Item
    {
        public Product? Product = null;
        public int Amount = 0;
    }
    class Customer
    {
        public int ID = -1;
        public string? Name = null;
        public string? Address = null;
    }
    
}