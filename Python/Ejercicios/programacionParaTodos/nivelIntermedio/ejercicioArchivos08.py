"""
script en Python que solicite al usuario una cantidad de películas a registrar y los almacene en un archivo  .csv (Comma Separated value) para posteriormente recuperarlos. De cada película se almacenará el titulo, la duración y el año.
"""

import os
import csv

def registerMovie (nameFile):
    amount = int(input('How many movie do you want to register?: '))
    with open(nameFile, 'a', newline='') as fileCSV:
        write = csv.writer(fileCSV, delimiter=',')
        for i in range(amount):
            os.system('clear')
            title = input('Title: ')
            duration = input('Duration: ')
            year = input('Year: ')
            write.writerow([title, duration, year])

def loadMovie(nameFile):
    os.system('clear')
    print('             Recorded movies')
    with open(nameFile, 'r', newline='') as fileCSV:
        reader = csv.reader(fileCSV)
        for row in reader:
            print(f'Title: {row[0]}')
            print(f'Duration: {row[1]}')
            print(f'Year: {row[2]}')
            print('~'*50)

def main():
    file = 'movies.csv'
    registerMovie(file)
    loadMovie(file)

if __name__ == '__main__':
    main()
