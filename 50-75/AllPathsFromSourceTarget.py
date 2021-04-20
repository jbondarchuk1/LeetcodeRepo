def allPathsSourceTarget(self, graph: List[List[int]]) -> List[List[int]]:
    paths = []
    def search(graph,path=None):
        if not path:
            path = [0]
        if path[-1] == len(graph)-1:
            paths.append(path)

        for neighbors in graph[path[-1]]:
            search(graph,path+[neighbors])
    search(graph)
    return paths

print(allPathsSourceTarget([[4,3,1],[3,2,4],[3],[4],[]]))