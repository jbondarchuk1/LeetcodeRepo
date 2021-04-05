# basically the right answer but its got bugs
def search(nums, target):
    if len(nums) < 0:
        return -1
    start = findStart(nums, 0, len(nums)-1)
    if start == None:
        negStart = 0
    else: negStart = -(len(nums)-start)
    # print(start)

    idx = binarySearch(nums, target, 0, len(nums)-1,negStart)
    if idx == None: return -1
    if idx < 0:
        return len(nums)+idx
    return idx

def binarySearch(nums, target, start, end, rotation):
    middle = (start+end)//2 
    # print(nums[middle],nums[middle+rotation])
    if end < start or middle>len(nums)-1:
        return None
    if nums[middle+rotation] == target:
        return middle + rotation
    elif nums[middle + rotation] > target:
        return binarySearch(nums, target, start, middle-1, rotation)
    else: return binarySearch(nums, target, middle+1, end, rotation)

# start is defined as the index where i-1 > i+1
def findStart(nums, start, end):
    middle = (start+end)//2
    if len(nums) <= 1:
        return 0
    print(middle)
    if end < start or middle>len(nums)-2:
        return None
    if nums[middle] > nums[middle+1]:
        return middle+1
    elif nums[start] < nums[middle]:
        return findStart(nums, middle+1, end)
    else: return findStart(nums, start, middle-1)

# print(search([5,1,3], 5) == 0)
# print(search([4,5,6,7,0,1,2],0) == 4)
# print(search([1],2) == -1)
# print(search([1,3,5],0)==-1)
print(search([8,9,2,3,4],9)==1)
# print(search([1,3],4)==-1)
# print(search([3,1],1)==1)
# print(search([3,1],3)==0)
# print(search([3,5,1],1)==2)

# super good solution but too big brain
def search(self, nums: List[int], target: int) -> int:
    if not nums: return -1
    l, r = 0, len(nums) - 1
    while l <= r:
        mid = (l + r) // 2
        if nums[mid] == target: return mid
        if nums[mid] >= nums[l]:
            if nums[l] <= target <= nums[mid]: r = mid - 1
            else: l = mid + 1
        else:
            if nums[mid] <= target <= nums[r]: l = mid + 1
            else: r = mid - 1
    return -1



# alternate solution that looks closer to mine
def search(self, nums: List[int], target: int) -> int:
    self.nums = nums
    num_len = len(self.nums)
    if len(nums) is 0:
        return -1
    if len(nums) is 1:
        if nums[0] is target:
            return 0
        else:
            return -1
    if self.nums[0] < self.nums[-1]:
        return self.binarySearch(self.nums, 0, num_len - 1,target)
    pivot = self.findPivot(0, num_len - 1)
    if self.nums[pivot] == target:
        print('pivot is target')
        return pivot
    else:
        if target >= self.nums[pivot] and target <= self.nums[num_len - 1]:
            return self.binarySearch(self.nums, pivot, num_len - 1, target)
        else:
            return self.binarySearch(self.nums, 0, pivot, target)

def findPivot(self, start, end):
    mid = (start + end) // 2
    if start > end:
        return None
    if self.nums[mid] > self.nums[mid+1]:
        return mid+1
    elif self.nums[mid] < self.nums[mid-1]:
        return mid
    else:
        if self.nums[start] < self.nums[mid]:
            return self.findPivot(mid+1, end)
        else:
            return self.findPivot(start, mid-1)
        
def binarySearch(self,arr, low, high, x):
    if high >= low: 

        mid = (high + low) // 2

        if arr[mid] == x: 
            return mid 

        elif arr[mid] > x: 
            return self.binarySearch(arr, low, mid - 1, x) 
        else: 
            return self.binarySearch(arr, mid + 1, high, x) 

    else: 
        return -1