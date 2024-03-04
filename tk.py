import serial
from thinker import *

valor_led = 1
valor_led2 = 1

arduino = serial.Serial('COM11',9600)

def funcao_botao():
    global valor_led
    global arduino 
    if valor_led == 1:
        valor_led = 0
        arduino.write(b'1')
        label_estado_led["text"]="Ligado"
        label_estado_led["foreground"] = "blue"
    else:
        valor_led = 1
        arduino.write(b'0')
        label_estado_led["text"]="Desligado"
        label_estado_led["foreground"]= "blue"
        
def funcao_botao2():
    global valor_led2
    global arduino 
    if valor_led2 == 1:
        valor_led2 = 0
        arduino.write(b'2')
        label_estado_led2["text"]="Ligado"
        label_estado_led2["foreground"] = "blue"
    else:
        valor_led = 1
        arduino.write(b'3')
        label_estado_led2["text"]="Desligado"
        label_estado_led2["foreground"]= "blue"
        
janela = Tk()
label_1 = Label(janela, text="LED VERMELHO: ", font="Arial 15", background="light blue", foreground="red")
label_1.place(x=300, y=50)

label_estado_led = Label(janela, text="", font="Arial 22", background="light blue", foreground="yellow")
label_estado_led.place(x=315, y=140)

botao_1 = Button(janela, width=20, text="ENVIAR", command=funcao_botao, background="yellow")
botao_1.place(x=300, y=200)

janela.geometry("500X400+0+0")
janela.configure(background="light blue")

label_2 = Label(janela,text="LED VERDE: ", font="Arial 15", background="light blue", foreground="green")
label_2.place(x=50,y=50)

label_estado_led2 = Label(janela,text="",font="Arial 22", background="light blue")
label_estado_led2.place(x=50,y=140)

botao_2 = Button(janela, width=20, text="ENVIAR", command=funcao_botao, background="yellow")
botao_2.place(x=50, y=200)

janela.mainloop()

