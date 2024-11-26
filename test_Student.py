# This is a test class for class Student

import unittest
from StudentCode import Student

class testStudent (unittest.TestCase):
    def test_email(self):                   # test1 to test the property email
        s1 = Student("Jones","Smith",2020)
        s2 = Student("Yugansh","Sen",2022)

        self.assertEqual(s1.email,"jones.smith@dbs.ie")
        self.assertEqual(s2.email,"yugansh.sen@dbs.ie")
    
    def test_fullname(self):                                # test2
        s1 = Student("Jones","Smith",2020)
        s2 = Student("Yugansh","Sen",2022)

        self.assertEqual(s1.fullname,"Jones Smith")
        self.assertEqual(s2.fullname,"Yugansh Sen")
    
    def test_getGraduationYear(self):                   #test3 
        s1 = Student("Jones","Smith",2020)
        s2 = Student("Yugansh","Sen",2022)

        yr1 = s1.getGraduationYear()
        yr2 = s2.getGraduationYear()

        self.assertEqual(yr1,2022)
        self.assertEqual(yr2,2024)

if __name__ == "__main__":
    unittest.main()