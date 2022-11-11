import numpy as np

'''
Implement the two Python functions.
'''

# count occurences of value 'val' in the numpy array
def count_occurences(mat, val):
    pass


# checks if any rows, columns and diagonals sums
# to the value 'val'. 
def sums_to_value(mat, val):
    pass


# given 2d numpy array
mat = np.array([
    [3, 5, -6, 8],
    [3, 1, 6, -5],
    [8, -5, 3, 8],
    [7, 8, 1, -2]
])

print('occurences:', count_occurences(mat, 8))
print('sums to value:', sums_to_value(mat, 5))
