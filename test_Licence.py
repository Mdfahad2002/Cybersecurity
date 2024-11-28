
import unittest
from LicenceApplication import Applicant

class test_Applicant(unittest.TestCase):
    @classmethod
    def setUpClass(self):
        self.id1 = Applicant("Joe Becker","Dublin-20",29)
        self.id2 = Applicant("Joana Mauris","Dublin-13",15)
        
    @classmethod
    def tearDownClass(self):
        pass
    
    def test1_apply(self):
        dd, mon, yr = self.id1.apply(10,'Jun',2024)
        self.assertEqual(dd, 10)
        self.assertEqual(mon.strip(),'Jul')
        self.assertEqual(yr, 2024)
    
    def test2_apply(self):
        dd, mon, yr = self.id2.apply(23,'Nov',2023)
        self.assertEqual(dd, 23)
        self.assertEqual(mon.strip(),'Dec')
        self.assertEqual(yr, 2023)
    
    # test_case: 20-Dec-2023
    def test3_apply(self):
        dd, mon, yr = self.id2.apply(20,'Dec',2023)
        self.assertEqual(dd, 20)
        self.assertEqual(mon.strip(),'Jan')
        self.assertEqual(yr, 2024)
    
    # test_case: 31-Mar-2020
    def test4_apply(self):
        dd, mon, yr = self.id2.apply(31,'Mar',2020)
        self.assertEqual(dd, 30)
        self.assertEqual(mon.strip(),'Apr')
        self.assertEqual(yr, 2020)

    # test_case: 28, 29, 30, 31 Jan
    # Change the source code with relevant code
    
    def test1_validate_age(self):       
        flag = self.id2.validate_age()
        self.assertTrue(flag)               # test FAILS    

    def test2_validate_age(self):
        flag = self.id2.validate_age()
        self.assertFalse(flag)

    # test_case: -ve date (-20-Jan-2020)
    # Change the source code accordingly
    
    # test_case: -ve year (20-Jan- -2020)
    # Change the souce code accordinly
    
    # test_case: 19-jan-2020
    # Change the souce code accordinly
    
    # test_case: 19-JAN-2020
    # Change the souce code accordinly
    
        
if __name__ == "__main__":
    unittest.main()
