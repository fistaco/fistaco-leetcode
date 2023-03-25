int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j < nums.Length; j++)
        {
            if (i != j && nums[i] + nums[j] == target)
            {
                return new int[] {i, j};
            }
        }
    }

    return new int[2];
}

// Example: nums = [2,7,11,15], target = 9, output - [0,1]
int[] nums = new int[] {2, 7, 11, 15};
int target = 9;

int[] two_sum_output = TwoSum(nums, target);
