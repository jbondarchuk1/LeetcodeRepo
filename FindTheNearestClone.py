# This is a solution to the hackerrank question Find the nearest clone
# currently i did not actually run or submit this, I just coded it up and never debugged it, still good practice


# graph_nodes = int number of nodes
# graph_from: an array of integers, the start nodes for each edge
# graph_to: an array of integers, the end nodes for each edge
# ids: an array of integers, the color id per node
# val: an integer, the id of the color to match
def constructGraph(graph_nodes,graph_from,graph_to,ids,val):
    # graph[idx] = [
    #   [],   ##connected nodes
    #   int,  ##color id
    # ]
    graph = {}
    idxOfVal = []
    for i in range(graph_nodes):
        graph[i] = [[], ids[i]]
        if ids[i] == val:
            idxOfVal.append(i)
    for i in range(graph_nodes):
        # append 'graph_to' value to 'graph_from' node and visa versa
        graph[graph_from[i]][0].append(graph_to[i])
        graph[graph_to[i]][0].append(graph_from[i])
    return graph,idxOfVal

# marking the path:
# store a 2 item array with [node, path_count] in the queue
# increment that path count and pass it to its neighbors when they get added to the queue
def bfs(graph, start, val):
    # append() = push and pop() = pop
    queue = []
    seen = {}
    queue.append([start, 0])
    while len(queue) > 0:
        node = queue.pop(0)
        if graph[node[0]][1] == val:
            node[1] += 1
            return node[1]
        try:
            seen[node[0]]
        except:
            node[1] += 1
            seen[node[0]] = True
            for neighbor in graph[node[0]][0]:
                queue.append([neighbor, node[1]])
    return 0

def findShortest(graph_nodes, graph_from, graph_to, ids, val):
    graph,idxOfVal = constructGraph(graph_nodes,graph_from,graph_to,ids,val)
    # bfs through each node in idxOfVal and return the smallest value
    shortestPath = 0
    for idx in idxOfVal:
        search = bfs(graph, idx, val)
        shortestPath = max(shortestPath, search)
    if shortestPath = 0:
        print("no paths found")
        return -1
    return shortestPath

