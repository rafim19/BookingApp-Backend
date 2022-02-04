using BookingAppITDiv.Model;
using Binus.WS.Pattern.Entities;
using Binus.WS.Pattern.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BookingAppITDiv.Helper
{
    public class CustomerHelper
    {
        public static int AddNewCustomer(MsCustomer data)
        {
            try
            {
                EntityHelper.Add<MsCustomer>(new MsCustomer()
                {
                    DateIn = DateTime.Now,
                    UserIn = "Admin",
                    //DateOfBirth = data.DateOfBirth,
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    Email = data.Email,
                    Password = data.Password,
                    Gender = data.Gender,
                    Phone = data.Phone,
                    Stsrc = 'A', //default value
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 1;
        }
    }
}
