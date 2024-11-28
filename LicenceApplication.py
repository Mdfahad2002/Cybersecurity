# Licence Class

class Applicant:
    months = ["Jan","Feb","Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct","Nov", "Dec"]
    @property
    def Name(self):
        return self._name
    
    def __init__(self, name, addr, age):
        self._name = name
        self._addr = addr
        self._age = age
    
    def apply(self, dd, mon, yyyy):
        self.dd = dd
        self.mon = mon
        self.yr = yyyy
                
        if self.dd == 31:
            self._issueDay = 30
        else:
            self._issueDay = dd
        
        if mon == 'Dec':
            self._issueMon = 'Jan'
            self._issueYr = self.yr + 1
        else:
            index = Applicant.months.index(mon)
            self._issueMon = Applicant.months[index+1]
            self._issueYr = yyyy
        
        return self._issueDay, self._issueMon, self._issueYr

    def validate_age(self):
        if self._age < 16:
            return False
        else:
            return True
    
    def show_details(self):
        print(" - - - - -  - - - - -  - - - - -  - - - - - ")
        print("Applicant Name: ",self._name)
        print("Address: ",self._addr)
        print("Apply Date: ",self.dd,"-",self.mon,"-",self.yr)
        print("Licence will be issued on: ",self._issueDay,"-",self._issueMon,self._issueYr)
        
def main():
    id1 = Applicant("Joe Becker","Dublin-20",29)
    id2 = Applicant("Joana Mauris","Dublin-13",15)
    
    id1.apply(10,'Jun',2024)
    id1.show_details()
    
    id2.apply(23,'Aug',2023)
    id2.show_details()
    
if __name__ == "__main__":
    main()
    
