# the easiest way without making your own home grown sorting function is to use sorted() with a lambda function for the key param
# sorted(array,key=..., reverse=True/False)
# array is the array
# key is a change in sorting priorities for your array. sorted can by itself sort this array with no parameters, but we can add specifics
# reverse will go in decending (0 index highest, length index lowest)

def reconstructQueue(self, people: List[List[int]]) -> List[List[int]]:
    ordered = sorted(people, key=lambda x: (x[0],-x[1]), reverse=True)
    # array = people
    # key = lambda x: (x[0],-x[1])  =>   pass height value normally, make index/k negative
    # reverse=True  HIGHEST height sorted first, then sorted again by LOWEST index/k, because the GREATEST index is the LOWEST negative
    queue = []
    for person in ordered:
        queue.insert(person[1], [person[0],person[1]])
    return queue

# the sorted function can essentially sort any array regardless of what values are inside. it can sort objects, 2d arrays, or any other value within
# a secondary data structure

# heapq also has two built in heapsort options in the form of heapq.nlargest and heapq.nsmallest. these will basically do the same thing
# heapq.nlargest(n, iterable, key=None)
# Return a list with the n largest elements from the dataset defined by iterable. key, 
# if provided, specifies a function of one argument that is used to extract a comparison key from each element in iterable 
# (for example, key=str.lower). Equivalent to: sorted(iterable, key=key, reverse=True)[:n].

# heapq.nsmallest(n, iterable, key=None)
# Return a list with the n smallest elements from the dataset defined by iterable. key, 
# if provided, specifies a function of one argument that is used to extract a comparison key from each element in iterable 
# (for example, key=str.lower). Equivalent to: sorted(iterable, key=key)[:n].

def reconstructQueue(self, people: List[List[int]]) -> List[List[int]]:
    ordered = heapq.nlargest(len(people),people, key=lambda x: (x[0],-x[1]))
    queue = []
    for person in ordered:
        queue.insert(person[1], [person[0],person[1]])
    return queue

# i confirmed it works!

