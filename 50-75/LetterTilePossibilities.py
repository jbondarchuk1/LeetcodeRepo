def numTilePossibilities(tiles):
    # permutations
    # each iteration of the permutation from start to end counts as 1
    myperms = set()
    def permu(t):
        if len(t) == 0:
            return ['']
        perms = []
        for i in range(len(t)):
            first = t[i]
            rest = t[:i] + t[i+1:]

            p = permu(rest)
            for el in p:
                newperm = el + first
                perms.append(newperm)
                myperms.add(newperm)
        return perms

    permu(tiles)
    return len(myperms)

print(numTilePossibilities("AAABBC"))




# best and fastest solution using dp
def numTilePossibilities(self, tiles: str) -> int:
    N = len(tiles)
    
    def combinations(n, k):
        result = 1
        for i in range(k):
            result *= (n - i)
            result //= (i + 1)
        return result
    
    # The value word_counts[n] is the number of length-n words constructed so far.
    word_counts = [1] + [0] * N
    tile_counts = collections.Counter(tiles)
    
    for letter in tile_counts:
        new_counts  = [0] * (N+1)
        num_tiles   = tile_counts[letter]
        
        for insertions in range(num_tiles + 1):
            for (word_len, word_count) in enumerate(word_counts[:len(word_counts)-insertions]):
                patterns    = combinations(word_len + insertions, word_len)
                new_words   = patterns * word_count
                new_counts[word_len + insertions] += new_words
        
        word_counts = new_counts
    
    return sum(word_counts) - 1