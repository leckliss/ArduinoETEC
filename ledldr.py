import serial
import time

porta = "COM4"
velocidade = 9600
comand = serial.Serial(porta, velocidade)
sensorldr = 0  # Inicialize a variável sensorldr

while True:
    # Leia a linha da porta serial e remova espaços em branco
    data = comand.readline().decode().strip()

    try:
        # Tente converter os dados lidos para um número inteiro
        sensorldr = int(data)
        print("Valor do LDR:", sensorldr)
    except ValueError:
        # Se não for possível converter para inteiro, imprima uma mensagem de erro
        print("Valor inválido recebido:", data)

    time.sleep(0.5)
    if sensorldr > 940:
        comand.write(b'O')
    else:
        comand.write(b'o')

  # Feche a conexão com a porta serial (corrigido "command" para "comand")
