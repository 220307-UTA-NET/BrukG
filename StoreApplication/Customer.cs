using System;

namespace  StoreApplication
{
     class  Customer
    {
        private int customerId ;
        private string firstName;
        private  string lastName;
     public Customer()
        {}

         public Customer(int CustomerId, string FirstName, string LastName)
        {
             this.customerId =CustomerId;
             this.firstName = FirstName;
             this.lastName = LastName;
    
        }
        public int  getId()
        {
             return this.customerId;
        }
        public string  getLastName()
        {
            return this.firstName;
        }
         public string  getFirstName()
        {
            return this.lastName;
        }

        public void setId(int ID)
        {
            this.customerId = ID;
        }

        public void setfirstName(string FirstName)
        {
            this.firstName = FirstName;
        }
        public void setLastName(string LastName)
        {
            this.lastName = LastName;
        }
    }
}



