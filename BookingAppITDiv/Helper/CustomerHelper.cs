using BookingAppITDiv.Model;
using Binus.WS.Pattern.Entities;
using Binus.WS.Pattern.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BookingAppITDiv.Output;

namespace BookingAppITDiv.Helper
{
    public class CustomerHelper
    {
        public static int AddNewCustomer(MsCustomer data)
        {
            try
            {
                EntityHelper.Add(new MsCustomer()
                {
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    Gender = data.Gender,
                    Email = data.Email,
                    Password = data.Password,
                    Phone = data.Phone,
                    Stsrc = 'A',
                    UserIn = "Admin",
                    DateIn = DateTime.Now,
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 1;
        }

        public static List<CustomerData> GetAllCustomer()
        {
            var retVal = new List<CustomerData>();
            var MsCustomer = EntityHelper.Get<MsCustomer>().ToList();

            try
            {
                retVal = MsCustomer.Select(customer => new CustomerData()
                {
                    CustomerID = customer.CustomerID,
                    FirstName = customer.FirstName,
                    LastName= customer.LastName,
                    Gender = customer.Gender,
                    Email = customer.Email,
                    Phone = customer.Phone,
                    DateOfBirth = customer.DateOfBirth
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return retVal;
        }
    }
}
