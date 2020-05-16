using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
       class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

        public int ecoscore { get; set; }



        public User(int userid, string username) {
            this.UserID = userid;
            this.UserName = username;
            this.ecoscore = 0;
        }



        public int getEcoScore() { return this.ecoscore; }

        public string getUserNamee() { return this.UserName; }

        public int getUserID() { return this.UserID; }



        public void buy(Product product)
        {
            if (product == null) { throw new System.ArgumentException("Product is null"); }
            this.ecoscore += product.getRating();

        }



        public void redeem(Reward reward) {
            if (reward == null) { throw new System.ArgumentException("reward is null"); }
            this.ecoscore -= reward.getPrice();
        }






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
