# TCP - Server2 
# This is a connection oriented server which accepts single connection at a time and responds with a 'Hi' message

import socket 

def server_process():
    try:
        sock = socket.socket(socket.AF_INET,socket.SOCK_STREAM)
        host = socket.gethostname()
        port = 9999                         # 0-1023 are well known ports
                                        # 1024 - 49151 are reserved for user server application
                                        # 49152 - 65535 are reserved for clients
        print(sock)

        sock.bind((host, port))
        print("Server is  ready..... ")
        sock.listen()
        sock.settimeout(10)

        print("Listening to the socket for the connection......")

        conn, addr= sock.accept()

        print("Connected with ",addr)
        msg= b"Hi..."
        conn.sendall(msg)

        conn.close()
    except TimeoutError:
        print("Server process terminates now....")

if __name__ == "__main__":
    server_process()
