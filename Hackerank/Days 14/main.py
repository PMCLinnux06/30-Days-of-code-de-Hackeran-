class Difference:
    def __init__(self, a):
        self.__elements = a

	# Add your code here
    def __init__(self, a):
        self.__elements = a
        self.maximumDifference = 0

    def computeDifference(self):
        self.maximumDifference = max(self.__elements) - min(self.__elements)

# End of Difference class

# End of Difference class