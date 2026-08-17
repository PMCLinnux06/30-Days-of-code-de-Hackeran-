class Jugador:
    def __init__(self, nombre, nivel):
        self.nombre = nombre
        self.nivel = nivel

    def mostrar(self):
        print(self.nombre, "nivel", self.nivel)

jugador = Jugador("Pedro", 5)
jugador.mostrar()
