# Enter your code here. Read input from STDIN. Print output to STDOUT
import sys


def solve():
    input_data = sys.stdin.read().splitlines()
    if not input_data:
        return

    n = int(input_data[0])
    phone_book = {}

    for i in range(1, n + 1):
        parts = input_data[i].split()
        phone_book[parts[0]] = parts[1]

    for i in range(n + 1, len(input_data)):
        query = input_data[i]
        if query in phone_book:
            print(f"{query}={phone_book[query]}")
        else:
            print("Not found")


if __name__ == "__main__":
  solve()
