using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmployeeModel
{
   public class Employee
    {
        private string firstName;
        private string lastName;
        private string mobileNo;
        private string emailID;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id
        {
            get; set;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public string MobileNo
        {
            get
            {
                return this.mobileNo;
            }
            set
            {
                this.mobileNo = value;
            }
        }
        public string EmailID
        {
            get
            {
                return this.emailID;
            }
            set
            {
                this.emailID = value;
            }
        }

    }
}
