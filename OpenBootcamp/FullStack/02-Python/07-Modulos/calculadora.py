class Calc:
    def __init__(self, *args):
        self.args = args

    def suma(self):
        sum = 0
        for arg in self.args:
            sum += arg
        return sum

    def resta(self):
        res = 0
        for arg in self.args:
            res -= arg
        return res 

    def multiplicar(self):
        mul = 1
        for arg in self.args:
            mul *= arg
        return mul
    
    def dividir(self):
        div = self.args[0]
        for arg in self.args:
            if arg == 0:
                return False
            div /= arg
        return div

