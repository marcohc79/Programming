def list_X_Y_Z (x,y,z):
    all_X = [ i for i in range(x+1) if 0<=i<=x ]
    all_Y = [ j for j in range(y+1) if 0<=j<=y ]
    all_Z = [ k for k in range(z+1) if 0<=k<=z ]
    return all_X, all_Y, all_Z

def all_permutations(all_X, all_Y, all_Z):
    permutations = [ [i,j,k] for i in range(len(all_X)) for j in range(len(all_Y)) for k in range(len(all_Z)) ]
    return permutations 

def permutations_valid(permutations, n):
    compression = [ value for value in permutations if sum(value) != n]
    return compression

if __name__=='__main__':
    x = int(input())
    y = int(input())
    z = int(input())
    n = int(input())
    all_X, all_Y, all_Z = list_X_Y_Z(x,y,z)
    permutations = all_permutations(all_X,all_Y, all_Z)
    valid = permutations_valid(permutations,n)
    print(valid)

