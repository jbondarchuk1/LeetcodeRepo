import re
def reinitializePermutation(n):
    original = [i for i in range(n)]
    new = original.copy()

    counter = 0
    while True:
        copy = new.copy()
        print(new)
        for i in range(n):
            if i%2 == 0:
                copy[i] = new[i//2]
            if i%2 == 1:
                copy[i] = new[int(n/2 + (i-1)/2)]
        counter+=1
        new = copy
        # print(original)

        if new == original or counter == 10:
            break
    return counter
print(reinitializePermutation(14))

