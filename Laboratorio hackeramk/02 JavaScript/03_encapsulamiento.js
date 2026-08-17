class Cuenta {
    #saldo;

    constructor(saldo) {
        this.#saldo = saldo;
    }

    depositar(cantidad) {
        this.#saldo += cantidad;
    }

    mostrarSaldo() {
        console.log("Saldo:", this.#saldo);
    }
}

const cuenta = new Cuenta(100);
cuenta.depositar(50);
cuenta.mostrarSaldo();
