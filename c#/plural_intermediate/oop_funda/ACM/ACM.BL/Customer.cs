using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
  		public int CustomerId
  		{
  			get;
  			private set;
  		}


        public List<Address> AddressList {get; set;}

	    public int CustomerType { get; set;}

        public static int InstanceCount { get; set; }
        private string _lastName;
      //coding convention
        public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				_lastName = value;
			}
		}


        public string FirstName {get; set;}
        public string EmailAddress {get; set;}

        public int MyProperty {get; private set;}

        public string FullName
      {
  		get
  		{
    			string fullName = LastName;

    			if (!string.IsNullOrWhiteSpace(FirstName))
    			{
    				if (!string.IsNullOrWhiteSpace(fullName))
    				{
    					fullName += ", ";
    				}
    				fullName += FirstName;
    			}

    			return fullName;
    		}
      }

  	//constr

  		public Customer()
			:this(0)
  		{
        //to prevent repeated code, constructor chaining
			
  		}

  		public Customer(int customerId)
  		{
  			this.CustomerId = customerId;
			AddressList = new List<Address>();
        //to prevent null value exception
        // default value of a list is null
  		}

  	// so the user can create the object with and without customerId


        //methods




		public override bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(LastName))
				isValid = false;

			if (string.IsNullOrWhiteSpace(EmailAddress))
				isValid = false;

			return isValid;
		}

		public string Log()
		{
			var logString = this.CustomerId + ": " + 
							this.FullName + " " + 
							"Email: " + this.EmailAddress + " " + 
							"Status: " + this.EntityState.ToString();
			return logString;
		}
    }
}
