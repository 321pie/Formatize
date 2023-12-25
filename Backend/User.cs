namespace formAtize.Backend
{
    public class User
    {
        private List<Document> m_documents = new List<Document>();
        private string m_username = "";
        private string m_key = "";
        private List<Block> m_blocks = new List<Block>();
        private Database m_databasse = new Database("Key");

        public User(string key)
        {
            //Do stuff in here with key
        }

        public bool Login()
        {
            return true;
        }

        public bool Logout()
        {
            return true;
        }
    }
}
