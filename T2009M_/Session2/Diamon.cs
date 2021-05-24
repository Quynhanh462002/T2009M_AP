using T2009M_AP.session1;

namespace T2009M_AP.Session2
{
    public class Diamon : Product
    {
        public int cara;

        public bool CheckAuth(int i)
        {
            if (cara > 10)
                return true;
            return false;
        }
    }
}