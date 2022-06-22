class Person:
    def __init__(self, name='', year=None):
        self._name = name
        self._year = year

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

    def __str__(self):
        return f'''Name: {self.name}
Year: {self.year}'''
