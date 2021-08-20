# NOT DONE YET I SUBMITTED ONE SOLUTION IT COULD USE SOME WORK
# #34

# log(n) solution GOOD
def searchRange(self, nums, target):
    def binarySearchLeft(A, t):
        left, right = 0, len(A) - 1
        while left <= right:
            mid = (left + right) // 2
            if t > A[mid]: left = mid + 1
            else: right = mid - 1
        return left

    def binarySearchRight(A, t):
        left, right = 0, len(A) - 1
        while left <= right:
            mid = (left + right) // 2
            if t >= A[mid]: left = mid + 1
            else: right = mid - 1
        return right

    left, right = binarySearchLeft(nums, target), binarySearchRight(nums, target)
    return (left, right) if left <= right else [-1, -1]


# log(n)^2 solution
def searchRange(self, nums: List[int], target: int) -> List[int]:
    def bs(nums,l,r,t):
        if r>=l:
            mid = (r+l)//2
            if nums[mid] == t:
                return mid
            if nums[mid] > t:
                return bs(nums,l,mid-1,t)
            if nums[mid] < t:
                return bs(nums,mid+1,r,t)
        return -1
    
    l = 0
    r = len(nums)-1

    def bslr(nums,l,r,t):
        if r >= l:
            currbs = bs(nums,l,r,t)
            if currbs == -1: return[math.inf,-math.inf]


            left = bslr(nums,l,currbs-1,t)
            right = bslr(nums, currbs+1,r,t)
            return [min(currbs,left[0]),mat(currbs,right[1])]

        return [math.inf,-math.inf]

    left,right = bslr(nums,l,r,target)
    if left == math.inf and right == -math.inf:left,right = -1,-1
    elif left == math.inf: left = right
    elif right == -math.inf: right = left
        
    return [left,right]

print(searchRange([5,7,7,10], 8))
