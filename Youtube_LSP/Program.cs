using System;

namespace Youtube_LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer engin = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Engin",
            //    LastName = "Demirog",
            //    TcNo = "12345"
            //};

            //Customer company = new Customer
            //{
            //    Id = 2,
            //    FirstName = "Abc Cosmetics",
            //    LastName = null,
            //    TcNo= "12345678"//vergi no
            //};
        }
    }
    
    class Customer
    {
        public int Id { get; set; }
    }

    class RealCustomer : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }

    }
    class CorporateCustomer : Customer
    {
        public string TaxNo { get; set; }
        public string Title { get; set; }
    }

    //class Customer
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string TcNo { get; set; }
    //}
}
