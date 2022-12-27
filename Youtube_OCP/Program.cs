using System;

namespace Youtube_OCP_DI
{
    internal class Program
    {
        //IoC Container Ninject, Autofac, Structure Map, Castle Windsor
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(/*Database.Oracle*/);
        }
    }

    class CustomerManager
    {
        // Loosely Coupled
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(/*Database database*/)
        {
            //CustomerDal customerDal = new CustomerDal();
            //customerDal.Add();
            //customerDal.Add(database);

            _customerDal.Add();
        } 
    }
    interface ICustomerDal
    {
        void Add();
    }
    class EfCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added by ef");
        }
    }

    class NhCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added by nh");
        }
    }
    /*
    class CustomerDal : ICustomerDal
    {
        public void Add(Database database)
        {
            if (database == Database.Oracle)
            {
                Console.WriteLine("Added to oracle db");
            }
            else if (database == Database.SqlServer)
            {
                Console.WriteLine("Added to sqlServer db");
            }
            //Ef Code
            Console.WriteLine("Added to database");
        }
        //public void Add()
        //{
        //    Console.WriteLine("Added to database");
        //}
    } */

    //public enum Database
    //{
    //    SqlServer, Oracle
    //}
}
