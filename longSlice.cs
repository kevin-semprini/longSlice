using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        int maggiore,maggioreTot = 1;
        int lenght = digits.Length;
        int temp;
        
        for (int i = 0; i < lenght; i++){
            if (!(char.IsNumber(digits[i]))){
                throw new System.ArgumentException();
            }
        }

        if (span < 0){
            throw new System.ArgumentException();
        }


        if (span > lenght){
            throw new System.ArgumentException();
        }
        
        if( span==0 ){
            return 1;
        }

        char[] numeri = digits.ToCharArray();

        for (int i = 0; i <= lenght-span; i++)
        {
            maggiore = 1;
            temp = i;
        
            for (int j = 0; j < span; j++){
                maggiore = maggiore * (digits[temp]-48);
                temp = temp + 1;
            }


            if (maggiore > maggioreTot){
                maggioreTot = maggiore;
            }
            if (maggioreTot == 1){
                maggioreTot = 0;
            }
            
        }
        
        
        return maggioreTot;
    }
}