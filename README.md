# TemperatureControlArduino
Temperature controller for Arduino


Arduino sketch:
-----------------

```
const int btnSetMode = 3;
const int btnTempDown = 2;
const int ledPin = 8;

byte incomingByte;

void setup()
{
  pinMode (btnSetMode, OUTPUT);
  pinMode (btnTempDown, OUTPUT);
  digitalWrite (btnSetMode, LOW);
  digitalWrite (btnTempDown, LOW);
  // serial port
  Serial.begin(9600);
}

void loop()
{
   if(Serial.available() > 0) {
    incomingByte = Serial.read();

    if(incomingByte == '1') {
      digitalWrite(btnSetMode, HIGH);
      delay(500);
      digitalWrite (btnSetMode, LOW);
    }

    else if(incomingByte == '0') {
      digitalWrite(btnTempDown, HIGH);
      delay(500);
      digitalWrite (btnTempDown, LOW);
    }

    else if(incomingByte == '9') {
      digitalWrite(ledPin, HIGH);
      delay(1000);
      digitalWrite(ledPin, LOW);
    }


  }


}

```
