# Class Student 

class Student:
    def __init__(self, fname, lname, year):             #constructor for the class Student
        self.fname = fname
        self.lname = lname
        self.year = year
    
    @property                                           # property email
    def email(self):
        fname = self.fname.lower()
        lname = self.lname.lower()
        email = fname +"."+lname+"@dbs.ie"
        return(email)
    
    @property                                           # property fullname    
    def fullname(self):
        fullname = self.fname+" "+self.lname
        return fullname
    
    def getGraduationYear(self):
        return int(self.year+2)
    