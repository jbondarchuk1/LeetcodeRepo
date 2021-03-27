def reverseWords(s):
    split = s.strip().split(" ")
    print(split)
    split = split[::-1]
    ans = ''
    for word in split:
        if word != "":
            ans+= word + " "
    return ans.strip()

print(reverseWords("a good   example"))