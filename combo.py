g = "jane mary john susan todd jake".split(" ")
f = set("jane mary susan".split(" "))
m = set("john todd jake".split(" "))

def permu(arr):
    if len(arr) == 0:
        return [[]]

    perms = []
    # for each value in the array
    for i in range(len(arr)):
        first = arr[i]
        rest = arr[:i] + arr[i+1:]
        for element in permu(rest):
            # add a permutation with each value in front omg this kinda deep
            perms.append([first]+element)

    return perms
out = permu(g)
remove = set()
for j in range(len(out)):
    p = out[j]
    for i in range(len(p)-1):
        first = p[i]
        second = p[i+1]

        if ((first in m and second in m) or (first in f and second in f)):
            remove.add(j)
        

newout = []
for i in range(len(out)):
    if i not in remove:
        newout.append(out[i])


print(len(newout))