//Read AND Write
//using system;

//namespace properties
//{
//    public class customer
//    {
//        int id;
//        string name;
//        datetime menddate;
//        public customer()
//        {
//            console.writeline("customer constructor call");
//            id = -1;
//            name = "not given";
//            menddate = datetime.now;
//        }
//        public int id { get { return id; } set { id = value; } }
//        public string name { get { return name; } set { name = value; } }
//        public datetime menddate { get { return menddate; } set { menddate = value; } }
//    }
//}
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

//Read only Example 2
using System;

namespace Properties
{
    public class Customer
    {
        int id;
        string name;
        DateTime mEndDate;
        public Customer(int id,string name,DateTime mEndDate)
        {
            Console.WriteLine("Customer Constructor Call");
            this.id = id;
            this.name = name;
            this.mEndDate = mEndDate;
        }
        public int Id { get { return id; }  }
        public string Name { get { return name; }  }
        public DateTime MEndDate { get { return mEndDate; }  }
    }
}