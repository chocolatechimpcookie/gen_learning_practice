using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class Order: EntityBase, ILoggable
	{
		//properties

		public int CustomerId {get; set;}
		public int ShippingAddressId {get; set;}


		public DateTimeOffset? OrderDate { get; set;}

		// this type helps you compare dates between different time zones

		public int OrderId { get; private set;}

		public List<OrderItem> orderItems {get; set;}



		//constructor

		public Order()
		{

		}

		public Order(int orderId)
		{
			this.OrderId = orderId;
		}

		// other methods



		public override bool Validate()
		{
			var isValid = true;

			if (OrderDate == null)
				isValid = false;

			return isValid;

		}

		public string Log()
		{
			throw new NotImplementedException();
		}
	}
}
