def test_binsearch():
    nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
    idx = 2  # num = 3
    partner_val = 6
    target = 9

    partner_idx = binary_search(idx, nums, partner_val, target, 0, len(nums))
    print(f"Partner index = {partner_idx}")


def binary_search(idx: int, nums: list[int], partner_val: int, target: int, start: int, end: int) -> int:
    """
    Finds the index for a matching TwoSum partner corresponding to the integer at index `idx` in `nums`
    by performing binary search from index `start` up to index `end` to find `partner_val`.
    """
    print(f"Searching between indices {start} and {end}")
    if end - start == 1 and nums[start] == partner_val and start != idx:
        return start

    # Determine in which part of the array we should search
    mid_idx = (end + start)//2
    if partner_val < nums[mid_idx]:
        return binary_search(idx, nums, partner_val, target, start, mid_idx)
    else:
        return binary_search(idx, nums, partner_val, target, mid_idx, end)


test_binsearch()
