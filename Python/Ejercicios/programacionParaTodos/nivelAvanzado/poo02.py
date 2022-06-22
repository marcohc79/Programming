"""
script en Python que implemente una clase Persona con las siguientes propiedades:
    nombre
    edad
Además se deberán agregar los comportamientos:
    hablar(mensaje) - mensaje: el mensaje que dirá la persona.
    comer(alimenta) - alimento: el mensaje que consume la persona.
"""

class Person:
    def __init__(self):
        self._name = ''
        self._year = None

    @property
    def name(self):
        return self._name
    @name.setter
    def name(self, value):
        self._name = value
    @name.deleter
    def name(self):
        del self._name

    @property
    def year(self):
        return self._year
    @year.setter
    def year(self, value):
        self._year = value
    @year.deleter
    def year(self):
        del self._year

    def speak(self, message):
        print(f'{self._name}: {message}')

    def eat(self, food):
        print(f'{self._name} is eating {food}')

def main():
    person_01 = Person()
    person_02 = Person()

    person_01.name = 'Marco Huamani'
    person_01.year = 31

    person_02.name = 'Brian Jeremias'
    person_02.year = 18

    print('First person data: ')
    print(f'Name: {person_01.name}')
    print(f'Year: {person_01.year}')

    print('Second person data: ')
    print(f'Name: {person_02.name}')
    print(f'Year: {person_02.year}')

    person_01.speak(f'Hello {person_02.name} How are you?')
    person_02.speak(f'Hey {person_01.name} Nice to see you.')

    person_01.eat('Oranje')
    person_02.eat('Banana')


if __name__ == '__main__':
    main()
