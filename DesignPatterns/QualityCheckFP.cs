using DesignPatterns;
using DesignPatterns;

namespace DesignPatterns
{
    public class QualityCheckFP
    {
        public void Check(User user, WaterQualitySystem system)
        {
            user.Login();
            Console.WriteLine();

            JournalSPMP journal = JournalSPMP.GetInstance();
            for (int i = 0; i < 3; i++)
            {
                system.GenerateReport(journal);
            }

            //user.Logout();
        }
    }
}