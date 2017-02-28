from Student import Student
from MyMath import MyMath
from GraduateStudent import GraduateStudent
import sys

if __name__ == "__main__":
    s1 = Student()
    s1.firstName = "Joseph"
    s1.lastName = "Stalin"
    s1.id = 1234
    s1.add_grade(45)
    s1.add_grade(90)
    s1.grade = s1.compute_grade()
    print(s1)

    s2 = Student()
    s2.firstName = "Vladimir"
    s2.lastName = "Lenin"
    s2.id = 2222    
    s2.add_grade(90)
    s2.add_grade(80)
    s2.grade = s2.compute_grade()
    print(s2)    g1 = GraduateStudent("Karl","Marx",666)
    g1.add_grade(85)
    g1.add_grade(91)
    g1.grade = g1.computeGrade()
    print(g1)    MyMath.pi = 3.141517 #invoking static field
    mm = MyMath("XYZ")
    print(mm.pi)
    mm2 = MyMath("PQR")
    print (mm2.showName() + " " + str(mm2.pi))
    print (MyMath.computeCylinderVolume(4.5, 7.2)) #invoking static method