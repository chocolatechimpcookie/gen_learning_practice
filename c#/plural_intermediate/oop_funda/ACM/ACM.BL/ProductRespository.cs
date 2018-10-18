using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class ProductRepository
  {

		public Product Retrieve (int productId)
		{
            Product product = new Product(productId);

			Object myObject = new Object();
			Console.WriteLine("Product: " + product.ToString());

            if (productId == 2)
            {
              product.ProductName = "Sunflowers";
              product.ProductDescription = "Assorted Size";
            // this might be off
              product.CurrentPrice = 15.96M;
            }
            return product;
		}

		//retrieves defined product
		// this uses the constructor, just one of them though
		/// how does this work tho

		public bool Save()
		{
			return true;
		}



  }
}
