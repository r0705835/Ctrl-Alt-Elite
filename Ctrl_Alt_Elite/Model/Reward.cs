namespace Model
{
    class Reward
    {
        private string name;
        private int rewardID;
        private int price;



        public Reward(string name, int rewardid, int price)
        {
            this.name = name;
            this.rewardID = rewardid;
            this.price = price;
        }

        public string getName() { return this.name; }
        public int getRewardID() { return this.rewardID; }
        public int getPrice() { return this.price; }



    }
}
