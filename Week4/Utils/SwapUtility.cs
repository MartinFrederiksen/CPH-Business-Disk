namespace Week4.Utils
{
    public static class SwapUtility
    {
        public static void swap<T>(int item1, int item2, T[] arr) {
            T temp = arr[item2];
            arr[item2] = arr[item1];
            arr[item1] = temp;

        }
    }
}