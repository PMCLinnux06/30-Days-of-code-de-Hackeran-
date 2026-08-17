#include <iostream>
using namespace std;

class Cuenta {
private:
    double saldo;

public:
    Cuenta(double s) {
        saldo = s;
    }

    void depositar(double cantidad) {
        saldo += cantidad;
    }

    void mostrarSaldo() {
        cout << "Saldo: " << saldo << endl;
    }
};

int main() {
    Cuenta cuenta(100);
    cuenta.depositar(50);
    cuenta.mostrarSaldo();
    return 0;
}
