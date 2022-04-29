#include <mega16.h>
#include <delay.h>
#include <string.h>
#include <stdio.h>

int start = 0;
int count = 0;
char r[];
#define ADC_VREF_TYPE 0x00

// Read the AD conversion result
unsigned int read_adc(unsigned char adc_input)
{
ADMUX=adc_input | (ADC_VREF_TYPE & 0xff);
// Delay needed for the stabilization of the ADC input voltage
delay_us(10);
// Start the AD conversion
ADCSRA= ADCSRA|0x40; //0x40 = 0b0100 0000
// Wait for the AD conversion to complete
while ((ADCSRA & 0x10)==0);
ADCSRA|=0x10;
return ADCW;
}
void uart_char_send(unsigned char chr){
    while (!(UCSRA & (1<<UDRE))) {}; //cho den khi bit UDRE=1  
            UDR=chr;         
}
//chuong trinh con phat mot chuoi ky tu
void uart_string_send(unsigned char *txt){
    unsigned char n, i;            
    n=strlen(txt); //Dem so ky tu             
          for (i=0; i<n; i++){
            uart_char_send(txt[i]);    //phat du lieu
            }
}
interrupt [USART_RXC] void usart_rx_isr(void)
{
char data;
data=UDR;
uart_char_send(data);
    
    if (data =='a') 
    {
     PORTC.0=1; 
     } 
     
    if (data =='b')
     {
     PORTC.0=0;
      }    
     if (data =='c') 
    {
     PORTC.1=1; 
     } 
     
    if (data =='d')
     {
     PORTC.1=0;
      }     
}
unsigned long ADC_out;
unsigned long dienap;

unsigned char tram,chuc,dvi;
unsigned long nhietdo;
// External Interrupt 0 service routine
interrupt [EXT_INT0] void ext_int0_isr(void)
{
// Place your code here
    start = 0;
    PORTD.4 = 1;
}

// External Interrupt 1 service routine
interrupt [EXT_INT1] void ext_int1_isr(void)
{
// Place your code here
   start = 1; 
}

// Timer 0 overflow interrupt service routine
interrupt [TIM0_OVF] void timer0_ovf_isr(void)
{
// Reinitialize Timer 0 value
TCNT0=0x83;
// Place your code here
count++ ;
    if(count >= 500 && start == 1){
        PORTD.4 = ~ PORTD.4; 
        // read  sensor   and send uart
        ADC_out=read_adc(0);       
        dienap = ADC_out*5000/1023;//theo mV       
        nhietdo = dienap/10;               
        sprintf(r,"%d\n",nhietdo);     
        uart_string_send(r);
    }
}

// Timer2 overflow interrupt service routine
interrupt [TIM2_OVF] void timer2_ovf_isr(void)
{
// Reinitialize Timer2 value
TCNT2=0x83;
// Place your code here

}
void button (){
if (PINB.6 == 0){   // den 1
    PORTC.0 = ~PORTC.0;
  while(PINB.6 == 0);
}
if(PINB.7 == 0)  {
    PORTC.1 = ~PORTC.1;
  while(PINB.7 == 0);
}
}

void main(void)
{


PORTB.6 = 1;
DDRD.6 = 0; 
PORTB.7 = 1;
DDRD.7 = 0; 

PORTC=0x00;
DDRC=0xff;

PORTD=0xfe;
DDRD=0x00;
PORTD.4 = 0;
DDRD.4 = 1;

PORTD.2 = 1;
DDRD.2 = 0; 
PORTD.3 = 1;
DDRD.3 = 0;
// Timer/Counter 0 initialization
// Clock source: System Clock
// Clock value: 125.000 kHz
// Mode: Normal top=0xFF
// OC0 output: Disconnected
// Timer Period: 1 ms
TCCR0=(0<<WGM00) | (0<<COM01) | (0<<COM00) | (0<<WGM01) | (0<<CS02) | (1<<CS01) | (1<<CS00);
TCNT0=0x83;
OCR0=0x00;



// Timer/Counter 2 initialization
// Clock source: System Clock
// Clock value: 125.000 kHz
// Mode: Normal top=0xFF
// OC2 output: Disconnected
// Timer Period: 1 ms
ASSR=0<<AS2;
TCCR2=(0<<PWM2) | (0<<COM21) | (0<<COM20) | (0<<CTC2) | (1<<CS22) | (0<<CS21) | (0<<CS20);
TCNT2=0x83;
OCR2=0x00;

// Timer(s)/Counter(s) Interrupt(s) initialization
TIMSK=(0<<OCIE2) | (1<<TOIE2) | (0<<TICIE1) | (0<<OCIE1A) | (0<<OCIE1B) | (0<<TOIE1) | (0<<OCIE0) | (1<<TOIE0);

// INT0: On
// INT0 Mode: Falling Edge
// INT1: On
// INT1 Mode: Falling Edge
// INT2: Off
GICR|=(1<<INT1) | (1<<INT0) | (0<<INT2);
MCUCR=(1<<ISC11) | (0<<ISC10) | (1<<ISC01) | (0<<ISC00);
MCUCSR=(0<<ISC2);
GIFR=(1<<INTF1) | (1<<INTF0) | (0<<INTF2);

// USART initialization
// USART enable
UCSRA=0x00;
UCSRB=0x98;
UCSRC=0x86;
UBRRH=0x00;
UBRRL=0x33;


ADMUX=ADC_VREF_TYPE & 0xff;
ADCSRA=0x83;

// Global enable interrupts
#asm("sei")

while (1)
      {

        if (start == 0)
        {
             PORTD.4 = 1;  
             PORTC.0 = 0;
             PORTC.1 = 0;
        }      
        
         else if(start == 1)
         {
          button();
        }  
        
       
      }
}
