def transmit_to_space(message):
    "This is the enclosing function"
    def data_transmitter():
        "the nested function"
        print(message)
        
    data_transmitter()
    
print(transmit_to_space("Test message"))