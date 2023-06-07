class Algorithms {
    public static void Main(string[] args) {
      int[] arr = { 1, 7, 8, 12, 3, 5 };
      int[] sortedArr = { 1, 4, 5, 12, 15, 19 };
      Console.WriteLine(SearchAlgorithms.LinearSearch(arr, 8));
      Console.WriteLine(SearchAlgorithms.BinarySearch(sortedArr, 1));
    }
}

class SearchAlgorithms {
  public static int LinearSearch(int[] arr, int target) {
    for (int i = 0; i < arr.Length; i++) {
      if (arr[i] == target) {
        return i;
      }
    }
    return 0;
  }

  public static int BinarySearch(int[] arr, int target) {
    int l = 0;
    int m = arr[arr.Length / 2];
    int r = arr[^1];

    Console.WriteLine($"{l} {m} {r}");

    while (l < r) {
      m = (l + r) / 2;
      if (arr[m] <= target) {
        l = m + 1;
      }
      else {
        r = m;
      }
    }
    if (l > 0 && arr[l - 1] == target) {
      return arr[l - 1];
    }
    return 0;
  }
}