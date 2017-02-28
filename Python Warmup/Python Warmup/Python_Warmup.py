
from Student import Student

def display_file():
    read = open("c:/temp/students.txt","r")
    for line in read:
        print(line)


def processGrade():
    read = open("c:/temp/students.txt","r")
    out = open("c:/temp/grades.txt","w")
    for line in read:
        info = line.split('\t')
        s = Student("","",0)
        s.id = info[0]
        s.firstName = info[1]
        s.lastName = info[2]
        s.add_grade(float(info[3]))
        s.add_grade(float(info[4]))
        grade = s.compute_grade()
        out.write(s.id + '\t'+s.lastName +' \t'+grade+' ')
    out.close()
    print('done processing...')

if __name__ == "__main__":
   display_file()
   processGrade()
