def superDigit(n, k):
    if len(n) == 1 and k == 1:
        return n

    total = str(sum([int(d) for d in n]) * k)
    return superDigit(total, 1)