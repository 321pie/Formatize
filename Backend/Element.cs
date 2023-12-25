using System.Transactions;

namespace formAtize.Backend
{
    public interface Element
    {
        //Returns if anything is contined within or if it can be deleted upon save.
        public bool isEmpty();
    }
}
