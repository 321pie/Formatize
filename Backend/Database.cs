namespace formAtize.Backend
{
    public class Database
    {
        private string m_localConnection = "";
        private string m_remoteConnection = "";

        public Database(string key)
        {
            //Do stuff in here with key
        }

        public bool OpenConnection()
        {
            return true;
        }

        public bool CloseConnection()
        {
            return true;
        }

        public List<string> GetDocuments()
        {
            return new List<string>();
        }

        public Document GetDocument(string documentName)
        {
            return new Document("Not Yet Implemented");
        }

        public bool SaveToLocalDatabase()
        {
            return true;
        }

        public bool SaveToRemoteDatabase()
        {
            return true;
        }

        public List<Document> GetDocumentTypes()
        {
            return new List<Document>();
        }
    }
}
