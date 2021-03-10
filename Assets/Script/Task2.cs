namespace MaxG {

    public static class Task2 {
        // 2. Реализовать метод расширения для поиска количество символов в строке
        public static int FindAmount(this string str) {
            return str.Length;
        }

        public static int FindSymbolAmount(this string str, char c) {
            int counter = -1, pointer = -1;
            
            do {
                ++counter;
                pointer = str.IndexOf(c, pointer + 1);
            } while (pointer >= 0);

            return counter;
        }
    }
}