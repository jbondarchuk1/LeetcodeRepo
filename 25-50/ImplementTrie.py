# this guy made the stop character an extra key of each and set it to true if that letter is also the end of a word

class Trie:
    def __init__(self):
        """
        Initialize your data structure here.
        """
        self.root = {}
        self.stop_character = '__s'
        
    def insert(self, word: str) -> None:
        """
        Inserts a word into the trie.
        """
        node = self.root
        for letter in word:
            node = node.setdefault(letter, {})
        node[self.stop_character] = True
        
    def search(self, word: str) -> bool:
        """
        Returns if the word is in the trie.
        """
        node = self.root
        for letter in word:
            if letter not in node:
                return False
            node = node[letter]
        return node.get(self.stop_character, False)

    def startsWith(self, prefix: str) -> bool:
        """
        Returns if there is any word in the trie that starts with the given prefix.
        """
        node = self.root
        for letter in prefix:
            if letter not in node:
                return False
            node = node[letter]
        return True


# Your Trie object will be instantiated and called as such:
obj = Trie()
obj.insert("apple")
param_2 = obj.search("apple")
param_3 = obj.startsWith("appl")
print(param_2)
print(param_3)
# print(obj.top.children)