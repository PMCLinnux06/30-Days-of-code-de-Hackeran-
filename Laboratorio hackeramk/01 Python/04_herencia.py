class Animal:
    def comer(self):
        print("El animal come")

class Perro(Animal):
    def ladrar(self):
        print("Guau")

perro = Perro()
perro.comer()
perro.ladrar()
