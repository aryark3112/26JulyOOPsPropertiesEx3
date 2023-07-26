using System;

namespace Properties
{
    public class Customer
    {
        int id;
        string name;
        DateTime mEndDate;
        public Customer()
        {
            Console.WriteLine("Customer Constructor Call");
            id = -1;
            name = "not given";
            mEndDate = DateTime.Now;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime MEndDate { get { return mEndDate; } set { mEndDate = value; } }
    }
}
//Properties
//[A.S][Mod.][DataType] PropertyName {get;set;}
//get : reading
//set : writing
//1. ReadOnly get
//2. WriteOnly set
//3. Read and Write get,set
//abstract
//static
//autoimplemented