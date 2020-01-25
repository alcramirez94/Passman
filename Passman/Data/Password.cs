using System;
using System.Collections.Generic;
using System.Text;

namespace Passman.Data
{
    internal class Password
    {
        private int PasswordID;
        private char[] AccountName;
        private char[] ServiceName;
        private char[] PasswordChar;
        private int UserId;

        public Password(char[] AccountName, char[] ServiceName, char[] PasswordChar, int UserId) {
            this.PasswordID = 1;
            this.AccountName = AccountName;
            this.ServiceName = ServiceName;
            this.PasswordChar = PasswordChar;
            this.UserId = UserId;
        }

        public int GetPasswordID() {
            return PasswordID;
        }

        public char[] GetAccountName() {
            return AccountName;
        }

        public char[] GetServiceName() {
            return ServiceName;
        }

        public char[] GetPasswordChar() {
            return PasswordChar;
        }

        public int GetUserId() {
            return UserId;
        }
    }
}
