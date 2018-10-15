using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
  public class OrderRepository
  {


    public Order Retrieve(int orderId)
		{
			Order order = new Order();

      if (orderId == 10)
      {
        order.OrderDate = new DateTimeOffset(2014);
        //this might be off
      }
		}

		public bool Save()
		{
			return true;
		}


  }
}
