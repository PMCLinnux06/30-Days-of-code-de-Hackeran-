#!/bin/python3

import math
import os
import random
import re
import sys


if __name__ == "__main__":
    n = int(input().strip())

    binary_str = bin(n)[2:]
    max_ones = max(len(group) for group in binary_str.split("0"))

    print(max_ones)
