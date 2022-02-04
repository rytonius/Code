import math

def square(base):
    return base ** 2

def triange(base, height):
    return base*height/2

def rectangle(width, height):
    return width*height

def circle(radius):
    return math.pi*(radius**2)

def addition(first, second):
    return first + second

def subtraction(first, second):
    return first - second

def multiple(first, second):
    return first*second

def division(first, second):
    return ("{} r {}".format((first // second), (first % second)))

def donut(outside_radius, inside_radius):
    return circle(outside_radius) - circle(inside_radius)

def calculate_resolution(width, height):
    return "{}x{}".format(width*2,height*2)
