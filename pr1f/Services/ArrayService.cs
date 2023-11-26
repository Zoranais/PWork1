using System.Linq;

namespace pr1f.Services
{
    public class ArrayService
    {
        public int[] Calculate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    return array.ToList().Where(x => x != array[i]).ToArray();
                }
            }
            return array;
        }
    }
}
