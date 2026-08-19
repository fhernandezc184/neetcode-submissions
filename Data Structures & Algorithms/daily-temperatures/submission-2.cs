public class Solution {
  public int[] DailyTemperatures(int[] temperatures)
{
    var n = temperatures.Length;
    int[] result = new int[n];
    Stack<int> stack = [];

    for (var i = 0; i < n; i++)
    {
        while (
            stack.Count > 0 &&
            temperatures[i] > temperatures[stack.Peek()]
        )
        {
            var previousIndex = stack.Pop();
            result[previousIndex] = i - previousIndex;
        }

        stack.Push(i);
    }

    return result;
}
}
