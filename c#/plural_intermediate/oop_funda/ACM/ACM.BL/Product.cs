using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	class Product
	{

		
		
		
		public Decimal? CurrentPrice {get; set;}

		//nullable type, so code can distinguish between Not Set and Zero
		
		public int ProductId { get; private set;}

		// this is being set by the constructor, but it cannot be modified otherwise outside of this class

		public string ProductDescription { get; set;}

		public string ProductName { get; set;}




		public Product()
		{

		}

		public Product(int productId)
		{
			this.ProductId = productId;
		}






		//why is this not erroring in PL's video? Its not using the parameter at all!

		public Product Retrieve (int productId)
		{
			return new Product();
		}

		//retrieves defined product
		// this uses the constructor, just one of them though
		/// how does this work tho



		public bool Save()
		{
			return true;
		}

		//saves defined product

		public bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (CurrentPrice == null) isValid = false;

			return isValid;

			
		}


	}
}
