namespace SpendWise
{
    public class Money
    {
        Connection con = new Connection();
        public string checkMoney()
        {
            // check sales
            string money = con.ReadString("SELECT money FROM wallet");
            return money;
        }
        public string checkSavings()
        {
            string savings = con.ReadString("SELECT savings FROM wallet WHERE id = 1");
            return savings;
        }
    }
}
