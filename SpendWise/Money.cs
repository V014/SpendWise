namespace SpendWise
{
    public class Money
    {
        public string checkMoney()
        {
            // check sales
            Connection con = new Connection();
            string queryMoney = "SELECT money FROM wallet";
            string money = con.ReadString(queryMoney);
            return money;
        }
    }
}
