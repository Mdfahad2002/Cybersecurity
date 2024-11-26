# Working with Databases SQLite
 
import sqlite3

try:
    con = sqlite3.connect('music.sqlite3')          # Connecting to SQLite DB
except sqlite3.DatabaseError:
    print("Can not connect with the database sqlite3")

try:
    cur = con.cursor()                              # Creating a cursor

    cur.execute('drop table if exists Movies')
    cur.execute('CREATE TABLE Movies (title TEXT, year NUMBER, score NUMBER)')
    input("Table is created....")

    # Insert records in Movies
    cur.execute("""INSERT INTO Movies VALUES 
            ("The Lion King",1994, 4),
            ("Tangled",2010,5),
            ("Moana",2026,4)
            """)
    input("Records are inserted.....")
    
    con.commit()
    input("Data is saved.....")

    cur.execute("SELECT * FROM Movies")
    for row in cur:
        print(row)
    
    input("Rows in the ascending order of score....")
    cur.execute("SELECT * FROM Movies order by SCORE")
    for row in cur:
        print(row)

    cur.execute("UPDATE Movies set score=3 where title='Moana'")
    input("Ipdated data in the ascending order of score....")
    cur.execute("SELECT * FROM Movies order by SCORE")
    for row in cur:
        print(row)
                
except sqlite3.DatabaseError:
    print("Error ")
    con.rollback()

finally:
    cur.close()
    con.close()