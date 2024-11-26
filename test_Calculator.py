# Unit test for Calculator
# A test class to test code Calulator .py

import unittest
import Calculator

class TestCalculator(unittest.TestCase):
    def test_add(self):
        result = Calculator.add(20,40)
        self.assertEqual(result,60)

        result = Calculator.add(-20,-40)
        self.assertEqual(result,-60)

        result = Calculator.add(-20,40)
        self.assertEqual(result,20)

    def test_subtract(self):                    # test2: for method subtract
        result = Calculator.multiply(5,10)
        self.assertEqual(result, 50)

    def test_divide(self):                      #test3 : for method divide
        result = Calculator.divide(30,2)
        self.assertEqual(result,15)

        """result = Calculator.divide(30,0)            # test fails
        self.assertEqual(result, 0)"""

        with self.assertRaises(ZeroDivisionError):
            result = Calculator.divide(30,0)

if __name__ == "__main__":
    unittest.main()
        
