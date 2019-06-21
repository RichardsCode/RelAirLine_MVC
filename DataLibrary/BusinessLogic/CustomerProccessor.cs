using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class CustomerProccessor
    {
        public static int CreateCustomer(string FirstName, string MiddleName, string LastName, string Suffix,
                                         DateTime BirthDate, string Gender, int PhoneNumber, string AddressLine1,
                                         string AdressLine2, string ZipCode, string City, string State, string EmailAddress, string Password)
        {
            CustomerModel data = new CustomerModel
            {
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                Suffix = Suffix,
                BirthDate = BirthDate,
                Gender = Gender,
                PhoneNumber = PhoneNumber,
                AddressLine1 = AddressLine1,
                AdressLine2 = AdressLine2,
                ZipCode = ZipCode,
                City = City,
                State = State,
                EmailAddress = EmailAddress,
                Password = Password

            };

            string sql = @"insert into dbo.Customer (FirstName, MiddleName, LastName, Suffix, BirthDate, Gender,
                                                     PhoneNumber, AddressLine1, AdressLine2, ZipCode, City, State, EmailAddress, Password)
                                                     values(@FirstName, @MiddleName, @LastName, @Suffix, @BirthDate, @Gender, @PhoneNumber,
                                                            @AddressLine1, @AdressLine2, @ZipCode, @City, @State,  @EmailAddress, @Password);";

            return SqlDataAccess.SavedData(sql, data);

        }
    }
}
