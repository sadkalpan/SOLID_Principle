using System;

namespace YoutubeSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    class CustomerManager
    {
        //ASPECTED ORIENTED PROGRAMİNG
        /*
        public void TransactionOperation()
        {
            //LOG
            //VALIDATION
            //CACHİNG
            //AUTH
            //PERFORMANCE
            MyContext context = new MyContext();
            context.Update();
            context.Insert();
        }*/
        private void Insert()
        { 
        }
        private void Update()
        {

        }
    }

    class PersonManager
    {
        public void Add()
        {
            MyContext context = new MyContext();
            context.Insert();
        }
    }
    internal class MyContext
    {
        internal void Insert()
        {
            throw new NotImplementedException();
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }
}
