using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PetrovDR.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] str = value.Split(" ");
            string res = "";
            int k = 0;
            foreach (string s in str)
            {
                k++;
                if (str.Length != k)
                {
                    res += s.Remove(0, 1) + " ";
                }
                else
                {
                    res += s.Remove(0, 1);
                }
            }
            return res;
        }
    }
}
