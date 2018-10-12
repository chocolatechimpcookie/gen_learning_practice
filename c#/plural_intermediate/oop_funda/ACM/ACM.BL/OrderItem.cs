using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class OrderItem
	{
		// properties

		public int OrderItemId { get; private set; }

		public int OrderQuantity { get; set; }

		public int ProductId { get; set; }

		public decimal? PurchasePrice { get; set; }



		//constr

		public OrderItem()
		{

		}

		public OrderItem(int orderItemId)
		{
			this.OrderItemId = orderItemId;
		}


		public OrderItem Retrieve(int orderItemId)
		{
			return new OrderItem();
		}


		public bool Save()
		{
			return true;
		}

		public bool Validate()
		{
			var isValid = true;

			if (OrderQuantity <= 0)
				isValid = false;

			if (ProductId <=0)
				isValid = false;

			if (PurchasePrice == null)
				isValid = false;

			return isValid;
		}


	}
}

