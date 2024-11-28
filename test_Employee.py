import unittest
from EmployeeCode import Employee

class testEmployee(unittest.TestCase):
    @classmethod
    def setUpClass(self):
        self.e1 = Employee("Sean Jordan","A1001",5200)
        self.e2 = Employee("Sharad Pilley","M2323",3200)
        self.e3 = Employee("Shirley Smith","H100",1000)
    
    @classmethod
    def tearDownClass(cls) -> None:
        return super().tearDownClass()
    
    def test1_calNetPay(self):
        pay = self.e1.cal_NetPay()
        self.assertEqual(pay,2600.0)
        
    def test2_calNetPay(self):
        pay = self.e2.cal_NetPay()
        self.assertEqual(pay,2560.00)

    def test3_calNetPay(self):
        pay = self.e3.cal_NetPay()
        self.assertEqual(pay,900.00)
    
    def test_validateSalary(self):
        e3 = Employee("Shirley Smith","H100", -2000)
        flag = e3.validate_salary()
        self.assertFalse(flag)
        #self.assertTrue(flag)       # test fails
    
    
        
if __name__ == "__main__":
    unittest.main()
