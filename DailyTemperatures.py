# O(n^2) worst case
def dailyTemperatures(arr):
    daysArr = []
    for i in range(len(arr)):
        days = 0
        compare = i
        if compare < len(arr)-1:
            while arr[compare] <= arr[i]:
                days += 1
                if compare>=len(arr)-1:
                    days = 0
                    break
                compare += 1
        daysArr.append(days)
    return daysArr
print(dailyTemperatures([73, 74, 75, 71, 69, 72, 76, 73]))




# learn to dissect assumptions we can make about passing through the data structure
# if i+1 is not greater than i, its either the same or lower so we can throw it on the stack and ignore the while loop
# by pushing onto a stack we can verify the smallest number's next largest temperature and do the math on how many days it is by subtracting the 
# index of the current temperature (larger) and the stack pop index (smallest)

# O(n) with a stack
def dailyTemperatures1(arr):
    stack = []
    days = [0 for i in range(len(arr))]
    for i in range(len(arr)):
        # every value corresponding to the index on the stack is in order of least (top) to greatest (bottom)
        # only enter the while loop when we've found a value greater than the top of the stack
        while stack and arr[stack[-1]] < arr[i]:
            days[stack[-1]] = i - stack[-1]
            stack.pop()
        stack.append(i)
    return days
print(dailyTemperatures1([73, 74, 75, 71, 69, 72, 76, 73]))
