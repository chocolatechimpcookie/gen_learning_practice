using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class CustomerRepository
	{
		private AddressRepository addressRepository {get; set;}

		public CustomerRepository()
		{
			addressRepository = new AddressRepository;
		}


		public Customer Retrieve(int customerId)
		{
				// return new Customer();
				Customer customer = new Customer(customerId);
				customer.AddressList = addressRepository.
					RetrieveByCustomerId(customerId).ToList();

				if (CustomerId == 1)
				{
					customer.EmailAddress = "fbaggins@hobbiton.me";
					customer.FirstName = "Frodo";
					customer.LastName = "Baggins";
				}
				return customer;
		}

		public List<Customer> Retrieve()
		{
				return new List<Customer>();
		}

		public bool Save()
		{
				return true;
		}




//
	}
}
