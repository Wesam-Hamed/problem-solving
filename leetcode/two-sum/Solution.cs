public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i =0; i<nums.Length; i++){
            for(int w = i+1; w<nums.Length ; w++){
                if (nums[i]+nums[w]==target){
                    return new int[]{i,w};
                }
            }
        }

        return null;
    }
}
