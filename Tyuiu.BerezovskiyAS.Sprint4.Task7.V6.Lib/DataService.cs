using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BerezovskiyAS.Sprint4.Task7.V6.Lib
{
    public class DataService : ISprint4Task7V6
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] arr = new int[n, m];

            int pos = 0;

            int ans = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = value[pos++];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] % 2 == 1) ans += arr[i, j] - '0';
                }
            }

            return ans;
        }
    }
}
