TRAVEL_TIME = { 
      ('B', 'A') : 8.043412251828856 ,
      ('B', 'C') : 6.961562065036552 ,
      ('B', 'E') : 11.182761725279896 ,
      ('B', 'D') : 4.829491781522557 ,
      ('A', 'C') : 11.933637650024707 ,
      ('A', 'E') : 17.726993564286605 ,
      ('A', 'D') : 9.160385528861413 ,
      ('C', 'E') : 13.366783356602122 ,
      ('C', 'D') : 5.995980076893033 ,
      ('E', 'D') : 10.864682204416317 ,
}
LIGHTHOUSES = "A B C D E".split()




from math import inf


def list_minus(L, x):
    # Returns a list of L that does not have x in it
    return list(set(L)-set([x,]))


def travel_time(x, y): # in my terminology time, distance, and walk (implied to be walk distance) are all the same in the algorithm code
    # Looks up x and y in TRAVEL_TIME in a way that order does not matter, returns a time
    global TRAVEL_TIME
    
    try:
        tm = TRAVEL_TIME[(x,y)] 
    except:
        tm = TRAVEL_TIME[(y,x)]
    
    return tm


def getHashKey(lst):
    return tuple(lst)

def insertDic(dic,lst,val):
    dic[getHashKey(lst)] = val
    dic[getHashKey(lst[::-1])] = val

def inDictionary(dic,lst):
    key = getHashKey(lst)
    keyB = getHashKey(lst[::-1])
    return key in dic.keys() or keyB in dic.keys()

def getValue(dic,lst):
    key = getHashKey(lst)
    return dic[key]

memo = {}
def fastest_tour_bf(start = '', remainingLightHouses = LIGHTHOUSES):
    
    if start in remainingLightHouses: remainingLightHouses.remove(start)

    if inDictionary(memo,[start] + remainingLightHouses): return [start] + remainingLightHouses, getValue(memo,[start] + remainingLightHouses)

    # initialize variables
    best_tour = []
    best_time = inf # infinity makes any initial tour the most optimal in recursive case


    # BASE CASE
    if len(remainingLightHouses) == 1:
        best_tour = [start, remainingLightHouses[0]]
        best_time = travel_time(start,remainingLightHouses[0])
        insertDic(memo,best_tour,best_time)
        return best_tour,best_time # one lighthouse remains, return this route as the best route
    

    # RECURSIVE CASE 1 (when a start node is not specified)
    if len(start) == 0: 
        for lh in remainingLightHouses:
            L_minus = list_minus(remainingLightHouses, lh)
            tour,time = fastest_tour_bf(lh, L_minus) # recurse with parameters, start = lighthouse in remaininglighthouses, remaininglighthouses = remaininglighthouses without start
            if time < best_time: # update to find the best tour
                best_tour = tour
                best_time = time
        return best_tour, best_time  


    # RECURSIVE CASE 2 (find optimal walk up until this node)
    for house in remainingLightHouses:
        walk = travel_time(start,house) # walk refers to the travel time or distance of the walk in this case
        L_minus = list_minus(remainingLightHouses, start) 
        tour, time = fastest_tour_bf(house, L_minus) # recurse the same as recursive case 1


        if time + walk < best_time: # update the same as recursive case 1
            best_tour = [start] + tour
            best_time = time + walk

    insertDic(memo,best_tour,best_time)
   
    return best_tour, best_time  


print(fastest_tour_bf("", LIGHTHOUSES))