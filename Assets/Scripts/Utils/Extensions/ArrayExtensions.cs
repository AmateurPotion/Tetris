namespace Tetris.Utils.Extensions
{
    public static class ArrayExtensions
    {
        public static T[,] Fill<T>(this T[,] array, T value)
        {
            for (var x = 0; x < array.GetLength(0); x++)
            {
                for (var y = 0; y < array.GetLength(1); y++)
                {
                    array[x, y] = value;
                }
            }
            
            return array;
        }
    }
}