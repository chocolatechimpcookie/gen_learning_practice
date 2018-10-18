using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class Product : EntityBase
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


		//saves defined product

		public override bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (CurrentPrice == null) isValid = false;

			return isValid;
		}


		public override string ToString()
		{
			return ProductName;
		}

		// anytime we access toString, we'll get toString

	}
}
