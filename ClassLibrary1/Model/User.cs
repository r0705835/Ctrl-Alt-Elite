using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
       class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
    }

    [Serializable]
    class InvalidUserNameException : Exception
    {
        public InvalidUserNameException()
        {

        }

        public InvalidUserNameException(string name)
            : base(String.Format("Invalid User Name: {0}", name))
        {

        }

    }
}
