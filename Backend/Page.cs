namespace formAtize.Backend
{
    public class Page : PageElement
    {
        private List<BlockElement> m_blocks = new List<BlockElement>();
        private int m_number;
        private bool m_dirty = true;
        //private bool header;

        public Page(int number)
        {
            m_number = number;
        }

        //Adds an element to the page (block)
        public int AddElement(BlockElement block)
        {
            m_blocks.Add(block);
            m_dirty = true;

            return m_blocks.Count;
        }

        //Removes all empty blocks from the page.
        public void Clear()
        {
            if (m_blocks.RemoveAll(block => block.isEmpty() == true) > 0)
                m_dirty = true;
        }

        //Returns if anything is contined within or if it can be deleted upon save.
        public bool isEmpty()
        {
            return m_blocks.Count == 0;
        }
    }
}
