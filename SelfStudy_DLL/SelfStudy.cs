namespace SelfStudy_DLL
{
    public class SelfStudy
    {
        public double selfStudyHours(double Credits, int Weeks, double Hours)
        {
            return (((Credits * 10) /(Convert.ToDouble(Weeks))) - Hours);
        }
    }
}