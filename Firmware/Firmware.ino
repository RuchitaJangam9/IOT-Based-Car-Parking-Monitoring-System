
// Include Libraries
#include "Arduino.h"


// Pin Definitions
#define IROBJAVOID_1_PIN_OUT	2
#define IROBJAVOID_2_PIN_OUT	3
#define IROBJAVOID_3_PIN_OUT	4
#define IROBJAVOID_4_PIN_OUT	5
#define IROBJAVOID_5_PIN_OUT	6
#define IROBJAVOID_6_PIN_OUT	7



// Global variables and defines

// object initialization


// define vars for testing menu
const int timeout = 10000;       //define timeout of 10 sec
char menuOption = 0;
long time0;

// Setup the essentials for your circuit to work. It runs first every time your circuit is powered with electricity.
void setup() 
{
    // Setup Serial which is useful for debugging
    // Use the Serial Monitor to view printed messages
    Serial.begin(9600);
    while (!Serial) ; // wait for serial port to connect. Needed for native USB
    Serial.println("start");
    
    pinMode(IROBJAVOID_1_PIN_OUT, INPUT);
    pinMode(IROBJAVOID_2_PIN_OUT, INPUT);
    pinMode(IROBJAVOID_3_PIN_OUT, INPUT);
    pinMode(IROBJAVOID_4_PIN_OUT, INPUT);
    pinMode(IROBJAVOID_5_PIN_OUT, INPUT);
    pinMode(IROBJAVOID_6_PIN_OUT, INPUT);
    menuOption = menu();
    
}

// Main logic of your circuit. It defines the interaction between the components you selected. After setup, it runs over and over again, in an eternal loop.
void loop() 
{
    
    
    if(menuOption == '1') {
    // IR Obstacle Avoidance Sensor #1 - Test Code
    //Read IR obstacle Sensor. irObjAvoid_1Var will be '1' if an Obstacle was detected
    //Use the onboard trimmer to set the distance of alert
    bool irObjAvoid_1Var = !digitalRead(IROBJAVOID_1_PIN_OUT);
    Serial.print(F("ObjAvoid: ")); Serial.println(irObjAvoid_1Var);

    }
    else if(menuOption == '2') {
    // IR Obstacle Avoidance Sensor #2 - Test Code
    //Read IR obstacle Sensor. irObjAvoid_2Var will be '1' if an Obstacle was detected
    //Use the onboard trimmer to set the distance of alert
    bool irObjAvoid_2Var = !digitalRead(IROBJAVOID_2_PIN_OUT);
    Serial.print(F("ObjAvoid: ")); Serial.println(irObjAvoid_2Var);

    }
    else if(menuOption == '3') {
    // IR Obstacle Avoidance Sensor #3 - Test Code
    //Read IR obstacle Sensor. irObjAvoid_3Var will be '1' if an Obstacle was detected
    //Use the onboard trimmer to set the distance of alert
    bool irObjAvoid_3Var = !digitalRead(IROBJAVOID_3_PIN_OUT);
    Serial.print(F("ObjAvoid: ")); Serial.println(irObjAvoid_3Var);

    }
    else if(menuOption == '4') {
    // IR Obstacle Avoidance Sensor #4 - Test Code
    //Read IR obstacle Sensor. irObjAvoid_4Var will be '1' if an Obstacle was detected
    //Use the onboard trimmer to set the distance of alert
    bool irObjAvoid_4Var = !digitalRead(IROBJAVOID_4_PIN_OUT);
    Serial.print(F("ObjAvoid: ")); Serial.println(irObjAvoid_4Var);

    }
    else if(menuOption == '5') {
    // IR Obstacle Avoidance Sensor #5 - Test Code
    //Read IR obstacle Sensor. irObjAvoid_5Var will be '1' if an Obstacle was detected
    //Use the onboard trimmer to set the distance of alert
    bool irObjAvoid_5Var = !digitalRead(IROBJAVOID_5_PIN_OUT);
    Serial.print(F("ObjAvoid: ")); Serial.println(irObjAvoid_5Var);

    }
    else if(menuOption == '6') {
    // IR Obstacle Avoidance Sensor #6 - Test Code
    //Read IR obstacle Sensor. irObjAvoid_6Var will be '1' if an Obstacle was detected
    //Use the onboard trimmer to set the distance of alert
    bool irObjAvoid_6Var = !digitalRead(IROBJAVOID_6_PIN_OUT);
    Serial.print(F("ObjAvoid: ")); Serial.println(irObjAvoid_6Var);

    }
    
    if (millis() - time0 > timeout)
    {
        menuOption = menu();
    }
    
}



// Menu function for selecting the components to be tested
// Follow serial monitor for instrcutions
char menu()
{

    Serial.println(F("\nWhich component would you like to test?"));
    Serial.println(F("(1) IR Obstacle Avoidance Sensor #1"));
    Serial.println(F("(2) IR Obstacle Avoidance Sensor #2"));
    Serial.println(F("(3) IR Obstacle Avoidance Sensor #3"));
    Serial.println(F("(4) IR Obstacle Avoidance Sensor #4"));
    Serial.println(F("(5) IR Obstacle Avoidance Sensor #5"));
    Serial.println(F("(6) IR Obstacle Avoidance Sensor #6"));
    Serial.println(F("(menu) send anything else or press on board reset button\n"));
    while (!Serial.available());

    // Read data from serial monitor if received
    while (Serial.available()) 
    {
        char c = Serial.read();
        if (isAlphaNumeric(c)) 
        {   
            
            if(c == '1') 
    			Serial.println(F("Now Testing IR Obstacle Avoidance Sensor #1"));
    		else if(c == '2') 
    			Serial.println(F("Now Testing IR Obstacle Avoidance Sensor #2"));
    		else if(c == '3') 
    			Serial.println(F("Now Testing IR Obstacle Avoidance Sensor #3"));
    		else if(c == '4') 
    			Serial.println(F("Now Testing IR Obstacle Avoidance Sensor #4"));
    		else if(c == '5') 
    			Serial.println(F("Now Testing IR Obstacle Avoidance Sensor #5"));
    		else if(c == '6') 
    			Serial.println(F("Now Testing IR Obstacle Avoidance Sensor #6"));
            else
            {
                Serial.println(F("illegal input!"));
                return 0;
            }
            time0 = millis();
            return c;
        }
    }
}

/*******************************************************

*    Circuito.io is an automatic generator of schematics and code for off
*    the shelf hardware combinations.

*    Copyright (C) 2016 Roboplan Technologies Ltd.

*    This program is free software: you can redistribute it and/or modify
*    it under the terms of the GNU General Public License as published by
*    the Free Software Foundation, either version 3 of the License, or
*    (at your option) any later version.

*    This program is distributed in the hope that it will be useful,
*    but WITHOUT ANY WARRANTY; without even the implied warranty of
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*    GNU General Public License for more details.

*    You should have received a copy of the GNU General Public License
*    along with this program.  If not, see <http://www.gnu.org/licenses/>.

*    In addition, and without limitation, to the disclaimers of warranties 
*    stated above and in the GNU General Public License version 3 (or any 
*    later version), Roboplan Technologies Ltd. ("Roboplan") offers this 
*    program subject to the following warranty disclaimers and by using 
*    this program you acknowledge and agree to the following:
*    THIS PROGRAM IS PROVIDED ON AN "AS IS" AND "AS AVAILABLE" BASIS, AND 
*    WITHOUT WARRANTIES OF ANY KIND EITHER EXPRESS OR IMPLIED.  ROBOPLAN 
*    HEREBY DISCLAIMS ALL WARRANTIES, EXPRESS OR IMPLIED, INCLUDING BUT 
*    NOT LIMITED TO IMPLIED WARRANTIES OF MERCHANTABILITY, TITLE, FITNESS 
*    FOR A PARTICULAR PURPOSE, NON-INFRINGEMENT, AND THOSE ARISING BY 
*    STATUTE OR FROM A COURSE OF DEALING OR USAGE OF TRADE. 
*    YOUR RELIANCE ON, OR USE OF THIS PROGRAM IS AT YOUR SOLE RISK.
*    ROBOPLAN DOES NOT GUARANTEE THAT THE PROGRAM WILL BE FREE OF, OR NOT 
*    SUSCEPTIBLE TO, BUGS, SECURITY BREACHES, OR VIRUSES. ROBOPLAN DOES 
*    NOT WARRANT THAT YOUR USE OF THE PROGRAM, INCLUDING PURSUANT TO 
*    SCHEMATICS, INSTRUCTIONS OR RECOMMENDATIONS OF ROBOPLAN, WILL BE SAFE 
*    FOR PERSONAL USE OR FOR PRODUCTION OR COMMERCIAL USE, WILL NOT 
*    VIOLATE ANY THIRD PARTY RIGHTS, WILL PROVIDE THE INTENDED OR DESIRED
*    RESULTS, OR OPERATE AS YOU INTENDED OR AS MAY BE INDICATED BY ROBOPLAN. 
*    YOU HEREBY WAIVE, AGREE NOT TO ASSERT AGAINST, AND RELEASE ROBOPLAN, 
*    ITS LICENSORS AND AFFILIATES FROM, ANY CLAIMS IN CONNECTION WITH ANY OF 
*    THE ABOVE. 
********************************************************/