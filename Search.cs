    class Search
    {
        public static int linar_search(int[] A, int num)
        {
            int index = -1;
            for (int i = 0; i < A.Length; i++)
                if (A[i] == num)
                    return i;
            return index;
        }
        public static bool LinearSearch<T>(T[] A, T a)
        {
            for (int i = 0; i < A.Length; i++)
                if (A[i].Equals(a))
                    return true;
            return false;
        }

        public static bool binary_search(int[] A, int key)
        {
            return false;
        }

    }
