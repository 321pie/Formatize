namespace formAtize.Backend
{
    using EasyDriveFilesManager;
    using Google.Apis.Drive.v3;

    public class Database
    {
        private string m_localConnection = "";
        private DriveService m_remoteConnection;

        public Database(string key)
        {
            //Do stuff in here with key
        }

        public bool OpenConnection()
        {
            //TODO: Local connection initialization stuff

            //Initialize remote onnection to Drive
            var tokenResponse = new TokenResponse
            {
                AccessToken = "...",
                RefreshToken = "...",
            }
            
            var applicationName = "..." // Use the name of the project in Google Cloud
            var username = "..." // Use your email
            
            var apiCodeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = "...",
                    ClientSecret = "..."
                },
                Scopes = new[] { Scope.Drive },
                DataStore = new FileDataStore(applicationName)
            })
            
            var credential = new UserCredential(apiCodeFlow, username, tokenResponse)
            
            var service = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName
            })
            m_remoteConnection = service;

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
