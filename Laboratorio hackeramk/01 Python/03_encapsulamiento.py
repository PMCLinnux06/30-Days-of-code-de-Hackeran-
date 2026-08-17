class Cuenta:
    def __init__(self, saldo):
        self.__saldo = saldo

    def depositar(self, cantidad):
        self.__saldo += cantidad

    def mostrar_saldo(self):
        print("Saldo:", self.__saldo)

cuenta = Cuenta(100)
cuenta.depositar(50)
cuenta.mostrar_saldo()
