namespace Chapter07_ArraysAndStrings;

public class TwoSum
{
    public static int[] Solution(int[] nums, int target) {
        int[] res = new int[2];
        bool found = false;
        for (int i = 0; i < nums.Length - 1 && !found; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    res[0] = i;
                    res[1] = j;
                    found = true;
                    break;
                }
            }
        }
        return res;
    }
}