using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Easy
{
    public class PowerOfTwoClass
    {
        public bool PowerOfTwo(int n)
        {
            if(n == 1) return true;
        
            int div = n;
            if(div < 0) return false;
            
            int rest;
            
            while(div > 1){
                rest = div % 2;
                if(rest != 0) return false;
                else div = div / 2;
            }
            
            if(div == 1) return true;
            else return false;
        }
    }
}
