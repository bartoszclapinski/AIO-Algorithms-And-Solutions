def balancedSums(arr):
    totalSum = sum(arr)
    left = 0
    for i in arr:
        if left == totalSum - left - i:
            return "YES"
        left += i
    return "NO"


