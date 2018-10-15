using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	class Order
	{
		//properties
		public DateTimeOffset? OrderDate { get; set;}

		// this type helps you compare dates between different time zones

		public int OrderId { get; private set;}

		//constructor

		public Order()
		{

		}

		public Order(int orderId)
		{
			this.OrderId = orderId;
		}

		// other methods



		public bool Validate()
		{
			var isValid = true;

			if (OrderDate == null)
				isValid = false;

			return isValid;

		}




	}
}
