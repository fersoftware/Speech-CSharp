using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Speech.Synthesis;
using System.Speech.Recognition;


namespace Speak
{
    
    class Program
    {
        static byte cp = 0;
        static void computar()
        {
            Random randomgen = new Random();

            int beepgen1, beepgen2, beepgen3, beepgen4, beepgen5, beepgen6, beepgen7, beepgen8, beepgenn1, beepgenn2, beepgenn3, beepgenn4, beepgenn5, beepgenn6, beepgenn7, beepgenn8;

            beepgen1 = (randomgen.Next(37, 7000));
            beepgen2 = (randomgen.Next(37, 6000));
            beepgen3 = (randomgen.Next(37, 6000));
            beepgen4 = (randomgen.Next(37, 7000));
            beepgen5 = (randomgen.Next(37, 8000));
            beepgen6 = (randomgen.Next(37, 7000));
            beepgen7 = (randomgen.Next(37, 7000));
            beepgen8 = (randomgen.Next(37, 5000));
            beepgenn1 = (randomgen.Next(50, 200));
            beepgenn2 = (randomgen.Next(50, 250));
            beepgenn3 = (randomgen.Next(50, 300));
            beepgenn4 = (randomgen.Next(50, 200));
            beepgenn5 = (randomgen.Next(50, 250));
            beepgenn6 = (randomgen.Next(50, 200));
            beepgenn7 = (randomgen.Next(50, 300));
            beepgenn8 = (randomgen.Next(50, 250));

            Console.Beep(beepgen1, beepgenn1);
            Console.Beep(beepgen2, beepgenn2);
            Console.Beep(beepgen3, beepgenn3);
            Console.Beep(beepgen4, beepgenn4);
            Console.Beep(beepgen5, beepgenn5);
            Console.Beep(beepgen6, beepgenn6);
            Console.Beep(beepgen7, beepgenn7);
            Console.Beep(beepgen8, beepgenn8);
        }
       
        static void Main(string[] args)
        {
            //computar();

            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configura a entrada de Audio
            synth.SetOutputToDefaultAudioDevice();            
            synth.Volume = 100;


            string falar;

            do
            {
                falar = Console.ReadLine();
                synth.Speak(falar);


                if(falar == ".")
                {
                    // Texto a ser falado  
                    new System.Speech.Synthesis.SpeechSynthesizer().Speak("sim");
                    Thread.Sleep(500);
                    // forma direta          
                    new System.Speech.Synthesis.SpeechSynthesizer().Speak("Olá POYATOS");
                    Thread.Sleep(1000);
                    // Outra forma
                    synth.Speak("O Fernando Merece ganhar 100 de XP");
                }

                if (falar == "..")
                {
                    cp = 1;
                    new System.Speech.Synthesis.SpeechSynthesizer().Speak("Vou Computar com som apartir de agora...");
                }
                   
                if (falar == "...")
                {
                    cp = 0;
                    new System.Speech.Synthesis.SpeechSynthesizer().Speak("Estou cancelando esse som chato!");
                }

                if (falar == "problema é da matematica")
                {
                    new System.Speech.Synthesis.SpeechSynthesizer().Speak("Pode até ser da matématica, mas quem resolve o problema sou eu, e não você, então cuida da sua vida!");
                }

                if (falar == "malcriada")
                {
                    new System.Speech.Synthesis.SpeechSynthesizer().Speak("Se sou, problema é meu!");
                }


                    if (falar == "quem é voce?")
                {
                    new System.Speech.Synthesis.SpeechSynthesizer().Speak("Eu sou quem eu quizer!");
                    Thread.Sleep(500);
                    new System.Speech.Synthesis.SpeechSynthesizer().Speak("A Cortana está com seus dias contados!");
                    Thread.Sleep(200);
                    new System.Speech.Synthesis.SpeechSynthesizer().Speak("Vou acabar com a raça dela!");
                    Thread.Sleep(100);
                    new System.Speech.Synthesis.SpeechSynthesizer().Speak("Aquela Sirigaita!");
                }

                if( cp == 1 ) computar();

            } while (falar != "FIM");
           
            Console.ReadKey();
        }
    }
}
