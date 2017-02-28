from Student import Student
class GraduateStudent(Student):
    def __init__(self, firstName=None, lastName=None, id=None, thesis=None):
        super().__init__(firstName,lastName,id)
        if not thesis:
            self.thesis = "unknown" 
        else:
            self.thesis = thesis

    def computeGrade(self) :
         sum = 0
         for testscore in self.tests:
             sum += int(testscore)
         avg = sum/len(self.tests)
         grade = ""
         if avg > 92:
            grade = "A"
         elif avg > 87:
             grade = "A-"
         elif avg > 85:
            grade = "B"
         else:
             grade = "B"
         return grade    def __str__(self):
        return super().__str__() + ' Thesis: '+ self.thesis
    


