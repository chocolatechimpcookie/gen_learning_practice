using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class ProductRepository
  {

    //why is this not erroring in PL's video? Its not using the parameter at all!

		public Product Retrieve (int productId)
		{

        product product = new Product(productId);

      if (productId == 2)
      {
          product.ProductName = "Sunflowers";
          product.ProductDescription = "Assorted Size";
        // this might be off
          product.CurrentPrice = 15.96M;
      }

      return new Product();
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
