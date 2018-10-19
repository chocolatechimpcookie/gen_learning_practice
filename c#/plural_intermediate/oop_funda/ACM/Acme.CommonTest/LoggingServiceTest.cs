using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.CommonTest
{

	[TestClass]
	public class LoggingServiceTest
	{
		[TestMethod]
		public void WriteToFileTest()
		{
			var changedItems = new List<ILoggable>();

			var customer = new Customer(1)
			{
				EmailAddress = "fbaggins@hobbiton.me",
				FirstName = "Frodo",
				LastName = "Baggins",
				AddressList = null
			};

			changedItems.Add(customer as ILoggable);

			var product = new Product(2)
			{
				ProductName = "Rake",
				ProductDescription = "Garden Rake with Steel Head",
				CurrentPrice = 6M
			};

			changedItems.Add(product as ILoggable);

			LoggingService.WriteToFile(changedItems);
		}
	}
}
