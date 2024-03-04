int ledVerde = 10;
int ledVermelho = 8;
int valor_recebido;

void setup() {
 pinMode(ledVerde,OUTPUT);
 pinMode(ledVermelho,OUTPUT);
 Serial.begin(9600); //Inicia a comunicação serial

}
 
void loop() {
 if (Serial.available() > 0){
  valor_recebido = Serial.read();
} 
 if(valor_recebido === '1'){
    digitalWrite(ledVermelho, HIGH);
 }
 else if(valor_recebido === '0'){
    digitalWrite(ledVermelho, LOW);
 }
 if(valor_recebido === '2'){
    digitalWrite(ledVerde, HIGH);
 }
 else if(valor_recebido === '3'){
    digitalWrite(ledVerde, LOW);
 }

}
