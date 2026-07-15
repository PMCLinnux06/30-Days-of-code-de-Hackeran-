print("===================================")
print("      SISTEMA DE FACTURACIÓN")
print("===================================")

cliente = input("Digite el nombre del cliente: ")

subtotal = 0
total_propina = 0
total_itbis = 0
total_general = 0

for i in range(5):

    print("\n==============================")
    print("Producto", i + 1)
    print("==============================")

    nombre = input("Nombre del producto: ")
    precio = float(input("Precio del producto: "))
    propina = float(input("Porcentaje de propina: "))
    itbis = float(input("Porcentaje de ITBIS: "))

    valor_propina = precio * propina / 100
    valor_itbis = precio * itbis / 100
    total = precio + valor_propina + valor_itbis

    subtotal += precio
    total_propina += valor_propina
    total_itbis += valor_itbis
    total_general += total

    print("\nResumen del producto")
    print("Producto:", nombre)
    print("Precio: RD$", precio)
    print("Propina: RD$", valor_propina)
    print("ITBIS: RD$", valor_itbis)
    print("Total: RD$", total)

print("\n===================================")
print("          FACTURA FINAL")
print("===================================")

print("Cliente:", cliente)
print("Subtotal: RD$", subtotal)
print("Propina: RD$", total_propina)
print("ITBIS: RD$", total_itbis)
print("TOTAL GENERAL: RD$", total_general)