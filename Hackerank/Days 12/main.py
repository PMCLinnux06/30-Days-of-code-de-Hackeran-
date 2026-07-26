class Person:
    def __init__(self, firstName, lastName, idNumber):
        self.firstName = firstName
        self.lastName = lastName
        self.idNumber = idNumber
    def printPerson(self):
        print("Name:", self.lastName + ",", self.firstName)
        print("ID:", self.idNumber)

class Student(Person):
    def __init__(self, firstName, lastName, idNumber, scores):
        super().__init__(firstName, lastName, idNumber)
        self.scores = scores

    def calculate(self):
        promedio = sum(self.scores) / len(self.scores)
        
        if 90 <= promedio <= 100:
            return 'O'
        elif 80 <= promedio < 90:
            return 'E'
        elif 70 <= promedio < 80:
            return 'A'
        elif 55 <= promedio < 70:
            return 'P'
        elif 40 <= promedio < 55:
            return 'D'
        else:
            return 'T'

line = input().split()
firstName = line[0]
lastName = line[1]
idNum = line[2]
numScores = int(input()) # not used, but read from input
scores = list(map(int, input().split()))

s = Student(firstName, lastName, idNum, scores)
s.printPerson()
print("Grade:", s.calculate())