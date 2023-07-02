using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    public class Customer
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
    }
        private double _balance;

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        private int _id;

        public int ID
        {
            get { return _id; }
       
}

        private static int _numOfCustomer = 0;

        public Customer(string name) : this(name, 0)
        {
        }
        public Customer(string name, double balance)
        {
            _name = name;
            _balance = balance;
            _numOfCustomer++;
            _id = _numOfCustomer;
        }
        public override string ToString()
        {
            return $"customer name: {_name}\ncustomer balance: {_id}\ncustomer balance: {_balance}";
        }

    }
	

}   