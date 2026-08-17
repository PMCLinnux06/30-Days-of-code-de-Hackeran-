class Animal {
    comer() {
        console.log("El animal come");
    }
}

class Perro extends Animal {
    ladrar() {
        console.log("Guau");
    }
}

const perro = new Perro();
perro.comer();
perro.ladrar();
