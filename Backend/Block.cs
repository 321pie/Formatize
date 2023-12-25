namespace formAtize.Backend
{
    public class Block
    {
        private bool m_isDirty = true;
        private string type;
        private int m_number;
        private Text m_template = new Text();
        private List<Text> m_text = new List<Text>();

        public Block()
        {
        }

        //Returns if anything is contined within or if it can be deleted upon save.
        public bool isEmpty()
        {
            return m_text.Count == 0;
        }

        public int AddText(int number)
        {
            m_text.Insert(number, new Text()); //TODO: +1?
            m_isDirty = true;

            return m_text.Count;
        }

        public int RemoveText(int number)
        {
            m_text.RemoveAt(number); //TODO: +1?
            m_isDirty = true;

            return m_text.Count;
        }
    }
}
