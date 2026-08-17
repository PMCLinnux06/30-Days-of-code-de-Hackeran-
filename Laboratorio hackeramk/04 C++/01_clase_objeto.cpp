#include <iostream>
using namespace std;

class Persona {
public:
    string nombre;

    void saludar() {
        cout << "Hola, soy " << nombre << endl;
    }
};

int main() {
    Persona persona;
    persona.nombre = "Pedro";
    persona.saludar();
    return 0;
}
