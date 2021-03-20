import math
# brute force
def productExceptSelf1(nums):
    prods = []
    for i in range(len(nums)):
        if i<len(nums):
            prods.append(math.prod(nums[:i])*math.prod(nums[i+1:]))
        else:
            prods.append(math.prod(nums[:i]))
    return prods

# print(productExceptSelf1([-1,1,0,-3,3]))

def productExceptSelf(self,nums):
    prods = []
    zeroCount = 0
    # product with only integers != 0
    fullProd = 0
    normProd = 0
    for num in nums:
        if num==0:
            zeroCount+=1
    if len(nums) > zeroCount:
        fullProd = 1
        normProd = 1
        for num in nums:
            if num!=0:
                fullProd*=num
            normProd*=num
    for num in nums:
        if num == 0 and zeroCount-1 == 0:
            prods.append(fullProd)
        elif zeroCount == 0:
            prods.append(normProd//num)
        else:
            prods.append(0)
    return prods

# without division
def productExceptSelf2(nums):
    result = [1 for i in range(len(nums))]
    rollProd = 1
    for i in range(len(nums)):
        result[i] *= rollProd
        rollProd  *= nums[i]
    rollProd = 1
    for i in range(1,len(nums)+1):
        result[-i] *= rollProd
        rollProd  *= nums[-i]
    return result

print(productExceptSelf2([-1,1,0,-3,3]))