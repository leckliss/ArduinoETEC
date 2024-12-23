import serial

porta = 'COM4'
velocidade = 9600
comando = serial.Serial(porta, velocidade);

#Em seguida informamos a estrutura de decisão e os comandos que usarem

while True:
    opcao= input("Selecione a para apagar o led ou A para acender! \n")
    if opcao== "A":
        comando.write(b'A')
    if opcao=="a":
        comando.write(b'a')
comand.close()