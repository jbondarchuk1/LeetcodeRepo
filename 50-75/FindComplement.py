# https://leetcode.com/problems/number-complement/discuss/1019691/C%2B%2B-Python-3-line-with-Explanation-Faster-than-100

def findComplement(self, num: int) -> int:
	k = int(log2(num))
	mask = int(2**(k+1) - 1)
	return num^mask

# mine
def findComplement(self, num: int) -> int:
    shift = num
    count = 0
    while shift > 0:
        count+=1
        shift>>=1
    invert = ~num
    return invert^((~1)<<count-1)