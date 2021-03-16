# my first medium! not too bad really, it seemed like an easy tbh
def partitionLabels(self, s: str) -> List[int]:
    letters = {}
    # letters will be an array arr[0] is start of that letter, arr[1] is end of that letter
    for i in range(len(s)):
        letters[s[i]] = i
    
    lengths = []
    counter = 0
    endidx = letters[s[0]] 
    for i in range(len(s)):
        counter += 1
        if i == endidx:
            lengths.append(counter)
            counter = 0
            
            # set the endidx to the next block, or if there is only one value left we just continue to the end
            if i+1 < len(s):   
                endidx = letters[s[i+1]]
            else:
                endidx = len(s) - 1
        else:
            if letters[s[i]] > endidx:
                endidx = letters[s[i]]
            
    return lengths