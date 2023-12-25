namespace formAtize.Backend
{
    public class Page
    {
        private List<Block> m_blocks = new List<Block>();
        private int m_number;
        private bool m_isDirty = true;
        private Block m_header;
        private Block m_footer;

        public Page(int number)
        {
            m_number = number;
        }

        //Adds a Block to the page
        public int AddBlock(int number)
        {
            m_blocks.Insert(number, new Block()); //TODO: +1?
            m_isDirty = true;

            return m_blocks.Count;
        }

        //Removes a Block from the page
        public int RemoveBlock(int number)
        {
            m_blocks.RemoveAt(number); //TODO: +1?
            m_isDirty = true;

            return m_blocks.Count;
        }

        //Removes all empty blocks from the page.
        public void Clear()
        {
            if (m_blocks.RemoveAll(block => block.isEmpty() == true) > 0)
                m_isDirty = true;
        }

        //Returns if anything is contined within or if it can be deleted upon save.
        public bool isEmpty()
        {
            return m_blocks.Count == 0;
        }
    }
}
