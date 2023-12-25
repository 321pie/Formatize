namespace formAtize.Backend
{
    public class Text
    {
        private string m_text = "";
        private bool m_isDirty = true;
        private int m_index;
        private string m_font;
        private int m_fontSize;
        private string m_fontColor;
        private bool m_isBold;
        private bool m_isItalicized;
        private bool m_isUnderlined;

        public Text()
        {}

        public bool isEmpty()
        {
            return m_text.Length == 0;
        }
    }
}
