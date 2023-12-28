namespace EducationalApp.LogicalOperators
{
    public class LogicalOperatorsInfo
    {
        public void ShowInfo(string menuObjeName)
        {
            if (menuObjeName == "AND &")
            {
                Console.WriteLine("AND & Info selected");
            }
            else if (menuObjeName == "OR |")
            {
                Console.WriteLine("OR | Info selected");
            }
            else
            {
                Console.WriteLine("Info about this logical operator doesn't exist");
            }
        }
  

        public void ShowExamples(string menuObjeName)
        {
            if (menuObjeName == "AND &")
            {
                Console.WriteLine("AND & Example selected");
            }
            else if (menuObjeName == "OR |")
            {
                Console.WriteLine("OR | Example selected");
            }
            else
            {
                Console.WriteLine("Info about examples of this logical operator doesn't exist");
            }
        }
    }
}
