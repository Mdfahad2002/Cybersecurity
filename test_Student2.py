# This is a test class for class Student

import unittest
from StudentCode import Student

class testStudent (unittest.TestCase):
    @classmethod
    def setUpClass(self):
        print("- - - - - Set up Class- - - - ")
        self.s1 = Student("Jones","Smith",2020)
        self.s2 = Student("Yugansh","Sen",2022)
    @classmethod
    def tearDownClass(self):
        print("- - - - - Tear down Class - - - - - ")
    
    def test_email(self):                   # test1 to test the property email
        self.assertEqual(self.s1.email,"jones.smith@dbs.ie")
        self.assertEqual(self.s2.email,"yugansh.sen@dbs.ie")
    
    def test_fullname(self):                                # test2
        self.assertEqual(self.s1.fullname,"Jones Smith")
        self.assertEqual(self.s2.fullname,"Yugansh Sen")
    
    def test_getGraduationYear(self):                   #test3 
        yr1 = self.s1.getGraduationYear()
        yr2 = self.s2.getGraduationYear()

        self.assertEqual(yr1,2022)
        self.assertEqual(yr2,2024)

if __name__ == "__main__":
    unittest.main()