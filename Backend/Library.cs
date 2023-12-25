using Microsoft.AspNetCore.SignalR;

namespace formAtize.Backend
{
    public class Library
    {
        private static Library m_instance = new Library();
        private List<DocumentElement> m_documents = new List<DocumentElement>();

        private Library()
        {
            //Load library into list from database
        }

        public static Library GetLibrary()
        {
            return m_instance;
        }

        public static List<DocumentElement> GetElements()
        {
            return m_instance.m_documents;
        }

        public static int AddDocument(DocumentElement document)
        {
            m_instance.m_documents.Add(document);

            return m_instance.m_documents.Count;
        }

        public static int RemoveDocument(DocumentElement document) 
        { 
            m_instance.m_documents.Remove(document);

            return m_instance.m_documents.Count;
        }
    }
}
