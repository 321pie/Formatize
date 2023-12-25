namespace formAtize.Backend
{
    public class Document
    {
        private string m_name;
        private bool m_isDirty = true;
        private string m_description = "";
        private List<Page> m_pages = new List<Page>();
        private List<Block> m_blocks = new List<Block>();

        public Document(string name) 
        {
            m_name = name;
        }

        public int GetPageCount()
        {
            return m_pages.Count;
        }

        public int AddPage()
        {
            //Make new page with next available number
            Page page = new Page(m_pages.Count + 1);

            m_pages.Add(page);
            m_isDirty = true;

            return m_pages.Count;
        }

        public void AddDescription(string description)
        {
            m_description = description;
            m_isDirty = true;
        }

        public bool isEmpty()
        {
            return m_pages.Count == 0;
        }

        public bool RemovePage(int number)
        {
            return true;
        }

        public string GetText()
        {
            return "";
        }

        public int Clean()
        {
            int count = m_pages.RemoveAll(page => page.isEmpty() == true);

            if(count > 0)
            {
                m_isDirty = true;
            }

            return count;
        }

        public int WordCount(bool limitedMode, List<string> types = null)
        {
            return 0;
        }
    }
}
