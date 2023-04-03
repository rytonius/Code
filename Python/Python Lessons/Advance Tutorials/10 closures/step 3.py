def transmit_to_space(message):
    "this is the enclosing function"
    def data_transmitter():
        "the nested function"
        print(message)
    return data_transmitter

fun2 = transmit_to_space("Burn the Sun!")
fun2()