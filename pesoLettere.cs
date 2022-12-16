using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
        int valore=0;
        char lettera;
        for(int i=0;i<input.Length;i++){
            lettera=input[i];
            switch (lettera){
                    case 'a': case 'e': case 'i': case 'o': case'u': case'l': case'n': case'r': case 's': case 't': case 'A': case'O':
                    valore++;
                    break;
                    case 'd': case'g':
                    valore=valore+2;
                    break;
                    case 'b': case 'c': case 'm': case'p': case'C':case'M': case 'B':
                    valore=valore+3;
                    break;
                    case 'f': case 'h': case 'v': case'w': case'y':    
                    valore=valore+4;        
                    break;
                    case 'k':
                    valore=valore+5;
                    break;
                    case 'j': case 'x':
                    valore=valore+8;
                    break;
                    case 'q':case 'z':
                    valore=valore+10;
                    break;
                    

            }



        }
        return valore;
         
    }
}