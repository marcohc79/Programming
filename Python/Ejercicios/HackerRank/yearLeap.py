def is_leap(year):
    leap = False
    print(year)
    if not year%4 and year%100 and not year%400:
        print(year)
        leap = True
    return leap

year = 4
print (is_leap(year)) 
