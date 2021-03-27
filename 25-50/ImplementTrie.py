import string
class Node:
    def __init__ (self,letter=None,children = {}):
        self.letter = letter
        self.children = children
        for letter in string.ascii_lowercase:
            self.children[self.letter] = None
        if self.letter:
            self.children[self.letter] = True 

class Trie:
    def __init__(self):
        """
        Initialize your data structure here.
        """
        self.top = Node()

    def insert(self, word: str) -> None:
        """
        Inserts a word into the trie.
        """
        child = self.top.children
        end = len(word)
        curr = 0
        while curr < end:
            child[word[curr]] = Node(letter=word[curr])
            child = child[word[curr]]
            curr+=1
        child[word[-1]] = True
        

    def search(self, word: str) -> bool:
        """
        Returns if the word is in the trie.
        """
        child = self.top.children
        end = len(word)
        curr = 0
        found = False
        while not found:
            child = child[word[curr]]
            if child == None:
                return False
            elif child == True and curr < end:
                found = True
            curr+=1
        return True

    def startsWith(self, prefix: str) -> bool:
        """
        Returns if there is any word in the trie that starts with the given prefix.
        """
        child = self.top.children
        end = len(prefix)
        curr = 0
        found = False
        while curr < end:
            child = child[word[curr]]
            if child == None:
                return False
            curr+=1
        return True


# Your Trie object will be instantiated and called as such:
obj = Trie()
obj.insert("word")
param_2 = obj.search("word")
param_3 = obj.startsWith("wor")
print(param_2)
print(param_3)