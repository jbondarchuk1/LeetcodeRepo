# brute force too slow bitch
def maxArea1(arr):
    maxi = 0    
    for i in range(len(arr)):
        for j in range(len(arr)-i):
            water = min(arr[i],arr[-(j+1)]) * ((len(arr)-j)-(i+1))
            if water > maxi:
                maxi = water
    return maxi
# print(maxArea1([2,3,4,5,18,17,6]))
# print(maxArea1([1,1000,1000,6,2,5,4,8,3,7]))
# print(maxArea1([1,8,6,2,5,4,8,3,7]))
# print(maxArea1([1,2,4,3]))
print(maxArea1([4,4,2,11,0,11,5,11,13,8]))


# the actual answer where are the fucking semantics my guy
# O(n) time and O(1) space
def maxArea(self, height: List[int]) -> int:
    left = water = 0
    right = len(height)-1

    while left < right:
        if height[left]>height[right]:
            # if right side is lower, calculate water with min of right
            a = height[right]*(right-left)
            # if the new volume is greater than the current max volume, swap them
            if a > water:
                water = a
            # only decrement the side the smaller side, so we can compare higher values
            right -= 1
        else:
            # if left side is lower, calculate water with min of left
            a = height[left]*(right-left)
            # swap if the new volume is greater
            if a > water:
                water = a
            # only increment the smaller side
            l += 1
    return water