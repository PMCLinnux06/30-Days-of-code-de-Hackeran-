# Enter your code here. Read input from STDIN. Print output to STDOUT
# Enter your code here. Read input from STDIN. Print output to STDOUT

t = int(input())

for _ in range(t):
    palabra = input()

    pares = ""
    impares = ""

    for i in range(len(palabra)):
        if i % 2 == 0:
            pares += palabra[i]
        else:
            impares += palabra[i]

    print(pares, impares)
