using Binus.WS.Pattern.Entities;
using BookingAppITDiv.Model;
using BookingAppITDiv.Models.Request;
using BookingAppITDiv.Output;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookingAppITDiv.Helper
{
    public class CustomerHelper
    {
        public static int AddNewCustomer(MsCustomer Data)
        {
            try
            {
                EntityHelper.Add(new MsCustomer()
                {
                    FirstName = Data.FirstName,
                    LastName = Data.LastName,
                    Gender = Data.Gender,
                    Email = Data.Email,
                    Password = Data.Password,
                    Phone = Data.Phone,
                    Stsrc = 'A',
                    UserIn = "Admin",
                    DateIn = DateTime.Now,
                    DateOfBirth = Data.DateOfBirth
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
            var RetVal = new List<CustomerData>();
            var MsCustomer = EntityHelper.Get<MsCustomer>().ToList();

            try
            {
                MsCustomer = MsCustomer.Where(Customer => Customer.Stsrc == 'A').ToList();
                RetVal = MsCustomer.Select(Customer => new CustomerData()
                {
                    CustomerID = Customer.CustomerID,
                    FirstName = Customer.FirstName,
                    LastName= Customer.LastName,
                    Gender = Customer.Gender,
                    Email = Customer.Email,
                    Phone = Customer.Phone,
                    DateOfBirth = Customer.DateOfBirth.ToString()
                }).ToList();
                if (RetVal.Capacity == 0) throw new Exception("404-Account Not Found");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return RetVal;
        }

        public static CustomerData GetSpecificCustomer(int CustomerID)
        {
            var RetVal = new CustomerData();
            var MsCustomer = EntityHelper.Get<MsCustomer>().ToList();

            try
            {
                MsCustomer = MsCustomer.Where(
                    Customer => Customer.CustomerID == CustomerID && Customer.Stsrc == 'A'
                ).ToList();

                RetVal = MsCustomer.Select(Customer => new CustomerData()
                {
                    CustomerID = Customer.CustomerID,
                    FirstName = Customer.FirstName,
                    LastName = Customer.LastName,
                    Gender = Customer.Gender,
                    Email = Customer.Email,
                    Phone = Customer.Phone,
                    DateOfBirth = Customer.DateOfBirth.ToString()
                }).FirstOrDefault();

                if (RetVal == null) throw new Exception("404-Account Not Found");
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return RetVal;
        }

        public static int UpdateSpecificCustomer(CustomerRequestDTO Data)
        {
            var MsCustomer = EntityHelper.Get<MsCustomer>().ToList();
            var Customer = new MsCustomer();

            try
            {
                Customer = MsCustomer.Where(
                    Customer => Customer.CustomerID == Data.CustomerID && Customer.Stsrc == 'A'
                ).FirstOrDefault();

                if (Customer == null) throw new Exception("404-Account Not Found");

                EntityHelper.Update(new MsCustomer()
                {
                    CustomerID = Data.CustomerID,
                    FirstName = Data.FirstName,
                    LastName = Data.LastName,
                    Gender = Customer.Gender,
                    Email = Data.Email,
                    Password = Data.Password,
                    Phone = Data.Phone,
                    Stsrc = Customer.Stsrc,
                    UserIn = Customer.UserIn,
                    DateIn = Customer.DateIn,
                    // UserUp automatically generated
                    UserUp = Data.CustomerID.ToString() + " - " + Data.FirstName + " " + Data.LastName,
                    DateUp = DateTime.Now,
                    DateOfBirth = Data.DateOfBirth
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return 1;
        }

        public static int DeleteSpecificCustomer(int id)
        {
            var MsCustomer = EntityHelper.Get<MsCustomer>().ToList();
            var ToBeDeleted = new MsCustomer();

            try
            {
                ToBeDeleted = MsCustomer.Where(
                    Customer => Customer.CustomerID == id && Customer.Stsrc == 'A'
                ).FirstOrDefault();

                if (ToBeDeleted == null) throw new Exception("404-Account Not Found");

                EntityHelper.Update(new MsCustomer()
                {
                    CustomerID = id,
                    FirstName = ToBeDeleted.FirstName,
                    LastName = ToBeDeleted.LastName,
                    Gender = ToBeDeleted.Gender,
                    Email = ToBeDeleted.Email,
                    Password = ToBeDeleted.Password,
                    Phone = ToBeDeleted.Phone,
                    Stsrc = 'D',
                    UserIn = ToBeDeleted.UserIn,
                    DateIn = ToBeDeleted.DateIn,
                    UserUp = ToBeDeleted.CustomerID.ToString() + " - " + ToBeDeleted.FirstName + " " + ToBeDeleted.LastName,
                    DateUp = DateTime.Now,
                    DateOfBirth = ToBeDeleted.DateOfBirth
                });
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return 1;
        }
    }
}
