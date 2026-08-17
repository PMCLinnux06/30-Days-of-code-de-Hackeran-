#include <iostream>
using namespace std;

class Jugador {
    string nombre;
    int nivel;

public:
    Jugador(string n, int l) {
        nombre = n;
        nivel = l;
    }

    void mostrar() {
        cout << nombre << " nivel " << nivel << endl;
    }
};

int main() {
    Jugador jugador("Pedro", 5);
    jugador.mostrar();
    return 0;
}
