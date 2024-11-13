# TCP-client1 
# TCP client code to send a connection request to server and receives a 'Hi...' from the server 

import socket

try:
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)           # To specify a connection oriented service
    host = socket.gethostname()
    port = 9999

    sock.connect((host,port))
    print("Client is connected with the server .... ")
    print("Peername: ",sock.getpeername())
    print("Socket: ",sock.getsockname)

    resp = sock.recv(1024)
    print(resp.decode())

except ConnectionRefusedError:
    print("Server process is not running...")
