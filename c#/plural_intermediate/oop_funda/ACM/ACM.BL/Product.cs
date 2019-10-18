using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
	public class Product : EntityBase, ILoggable 
	{

		public Decimal? CurrentPrice {get; set;}
		//nullable type, so code can distinguish between Not Set and Zero

		public int ProductId { get; private set;}
		// this is being set by the constructor, but it cannot be modified otherwise outside of this class

		public string ProductDescription { get; set;}

		private string _ProductName;

		public string ProductName
		{
			get
			{
				//return StringHandler.InsertSpaces(_ProductName);
				return _ProductName.InsertSpaces();
			}
			set
			{
				_ProductName = value;
			}
		}

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

		public string Log()
		{
			var logString = this.ProductId + ": " +
							this.ProductName + " " +
							"Detail: " + this.ProductDescription + " " +
							"Status: " + this.EntityState.ToString();
			return logString;
		}

	}
}
