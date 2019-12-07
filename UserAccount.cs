using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class UserAccount
    {

        private static int lastAccountNumber = 0;

        public string AccountName { get; set; }
        public string EmailAddress { get; set; }
        public List<Computer> Order { get; private set; }
        public int AccountNumber { get; private set; }
        public DateTime CreateDate { get; private set; }

        public UserAccount()
        {
            CreateDate = DateTime.Now;
            AccountNumber = ++lastAccountNumber;
        }
    }
}
