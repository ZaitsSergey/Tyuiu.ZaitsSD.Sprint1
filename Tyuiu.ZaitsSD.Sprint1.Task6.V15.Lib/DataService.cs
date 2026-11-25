using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZaitsSD.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            int letters = 0;
            for(var i = 0; i < value.Length; i++)
            {
                if (char.IsLetter(value[i]))
                {
                    letters++;
                }
            }
            return letters > value.Length - letters;
        }
    }
}
