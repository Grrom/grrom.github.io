from msvcrt import kbhit
import turtle

ts = turtle.getscreen()
t = turtle.Turtle()
t.speed(500)


def reset_cursor():
    t.penup()
    t.setx(0)
    t.sety(0)
    t.pendown()


def draw_main_body():
    def draw_head():
        t.penup()
        t.sety(200)
        t.pendown()

        t.circle(100)
        reset_cursor()

    def draw_body():
        t.penup()
        t.sety(-50)
        t.pendown()

        t.circle(160)
        reset_cursor()

    def draw_left_foot():
        t.penup()
        t.sety(-80)
        t.setx(-20)
        t.pendown()
        t.left(90)

        t.circle(80, extent=180)
        t.left(90)
        t.forward(160)
        reset_cursor()

    def draw_right_foot():
        t.penup()
        t.sety(-80)
        t.setx(180)
        t.pendown()
        t.left(90)

        t.circle(80, extent=180)
        t.left(90)
        t.forward(160)
        reset_cursor()

    t.color("black")
    t.begin_fill()

    draw_head()
    draw_body()
    draw_left_foot()
    draw_right_foot()

    t.end_fill()


def draw_eyes():

    t.penup()
    t.sety(320)
    t.setx(-40)
    t.pendown()

    t.color("white")
    t.begin_fill()

    t.circle(25)
    t.penup()
    t.setx(40)
    t.pendown()
    t.circle(25)

    t.end_fill()
    t.color("black")
    reset_cursor()


draw_main_body()


draw_eyes()
