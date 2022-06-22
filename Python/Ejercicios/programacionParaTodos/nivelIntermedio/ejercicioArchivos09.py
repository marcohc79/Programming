"""
script en Python que solicite al usuario una cantidad de películas a registrar y los almacene en un archivo .csv con encabezado para posteriormente recuperarlos. De cada película se almacenará el título, la duración y el año.
"""

import os
import csv
import pathlib

def registerMovie(file02CSV):
    amount = int(input('How many movie do you want to registrar?: '))
    field = ['Title', 'Duration', 'Year'] 
    if not pathlib.Path(file02CSV).exists():
        with open(file02CSV, 'w', newline='') as fileCSV:
            writer = csv.DictWriter(fileCSV, fieldnames=field)
            writer.writeheader()

    with open(file02CSV, 'a', newline='') as fileCSV:
        writer = csv.DictWriter(fileCSV, fieldnames=field) 
        for i in range(amount):
            os.system('clear')
            title = input('Title: ')
            duration = input('Duration: ')
            year = input('Year: ')
            writer.writerow({'Title':title, 'Duration':duration, 'Year':year})

def loadMovie(file02CSV):
    os.system('clear')
    print('                 Load Movie')
    with open(file02CSV, 'r', newline='') as fileCSV:
        reader = csv.DictReader(fileCSV)
        for linea in reader:
            for key, value in linea.items():
                print(f'{key}: {value}')
            print('*'*50)

def main():
    archivo = 'movies02.csv' 
    registerMovie(archivo)
    loadMovie(archivo)

if __name__=='__main__':
    main()

