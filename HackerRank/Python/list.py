# Consider a list (list = []). You can perform the following commands:

# 1. insert i e: Insert integer e at position i.
# 2. print: Print the list.
# 3. remove e: Delete the first occurrence of integer
# 4. append e: Insert integer e at the end of the list.
# 5. sort: Sort the list.
# 6. pop: Pop the last element from the list.
# 7. reverse: Reverse the list.

# Initialize your list and read in the value of   followed by n lines of commands where each command will be of the 7 types listed above. Iterate through each command in order and perform the corresponding operation on your list. 

# The first line contains an integer, n, denoting the number of commands.
# Each line i of the n subsequent lines contains one of the commands described above.

if __name__ == '__main__':
    N = int(input())
    l = []
    for i in range(N):
        s = input().split()
        cmd = s[0]
        args = s[1:]
        if cmd !="print":
            cmd += "("+ ",".join(args) +")"
            eval("l."+cmd)
        else:
            print (l)
