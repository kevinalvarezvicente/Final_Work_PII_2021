namespace Library
{
    public interface IRecyclable
    {
        bool IsRecyclable(bool recyclable)
        {
            if (recyclable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}