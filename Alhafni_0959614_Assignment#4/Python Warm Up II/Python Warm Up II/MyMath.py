import math
class MyMath:
     pi = 3.14 # static field

     def computeCircleArea(radius): # static method 
         return pi * radius * radius
     def computeCylinderVolume(radius, length) : #static method
         return MyMath.pi * math.pow(radius,2) * length
    # cannot use pi by itself, has to be qualified by MyMath
     def __init__(self, name):
         self.name = name # name is non static field
     def showName(self) : # non static method
        return self.name
