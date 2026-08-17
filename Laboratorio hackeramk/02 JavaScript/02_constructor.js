class Jugador {
    constructor(nombre, nivel) {
        this.nombre = nombre;
        this.nivel = nivel;
    }

    mostrar() {
        console.log(this.nombre + " nivel " + this.nivel);
    }
}

const jugador = new Jugador("Pedro", 5);
jugador.mostrar();
