namespace formAtize.Backend
{
    public class Block : BlockElement
    {
        private bool m_dirty = true;
        private string m_font = "ariel";
        private int m_font_size = 12;
        private string m_name = "";
        private List<Text> m_children = new List<Text>();

        public Block(string name)
        {
            m_name = name;
        }

        //Returns if anything is contined within or if it can be deleted upon save.
        public bool isEmpty()
        {
            return m_children.Count == 0;
        }
    }
}
