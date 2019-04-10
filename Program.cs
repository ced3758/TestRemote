

namespace TestRemote
{
    using System;
    using System.Threading;
    using Unosquare.RaspberryIO;
    using Unosquare.WiringPi;
    using Unosquare.RaspberryIO.Abstractions;

    class Program
    {
        static int toto = 0;
        static void ISRCallback() => toto++;
        static void Main(string[] args)
        {
            Pi.Init<BootstrapWiringPi>();

            Console.WriteLine("Hello World!");
            //Console.WriteLine("toto!");

            //Interrupt input
            var inputInterrupt = Pi.Gpio[P1.Pin21];
            inputInterrupt.PinMode = GpioPinDriveMode.Input;
/*
            while(true){

            Console.WriteLine("IS actived = " + inputInterrupt.Read().ToString());
            Thread.Sleep(500);
            }
 */            


            inputInterrupt.RegisterInterruptCallback(EdgeDetection.FallingEdge, ISRCallback);
/*
            //Set Output
            var led = Pi.Gpio[P1.Pin37];
            var led2 = Pi.Gpio[P1.Pin35];
            led.PinMode = GpioPinDriveMode.Output;
            led2.PinMode = GpioPinDriveMode.Output;
            int cpt = 10;
            while(cpt-- > 0)
            {
                led.Write(true);
                Thread.Sleep(500);
                led.Write(false);
                led2.Write(true);
                Thread.Sleep(500);
                led2.Write(false);
            }


            // PwmTest
            var pwmLed = Pi.Gpio[P1.Pin12] as GpioPin;
            pwmLed.PinMode = GpioPinDriveMode.PwmOutput;
            pwmLed.PwmMode = PwmMode.Balanced;
            pwmLed.PwmClockDivisor = 2;

            int cycles = 5;

            //while (cycles-- > 0)
            while (true)
            {
                for (int i = 0; i <= 100; i++)
                {
                    pwmLed.PwmRegister = (int)pwmLed.PwmRange / 100 * i;
                    Thread.Sleep(10);
                }

                for (int i = 0; i <= 100; i++)
                {
                    pwmLed.PwmRegister = (int)pwmLed.PwmRange - ((int)pwmLed.PwmRange / 100 * i);
                    Thread.Sleep(10);
                }

                Console.WriteLine(cycles.ToString() +" " + pwmLed.PwmRegister.ToString());
            }

            pwmLed.PwmRegister = 0;

 */
            while   (true){

                Console.WriteLine(toto.ToString());
                Thread.Sleep(500);
            }
        }


    }
}
