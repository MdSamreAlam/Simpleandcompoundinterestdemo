﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateInterestDemo.Interfaceclass
{
    /* 
COPY RIGHT @AUGMENTO LABS 2020
Created By Alam
*/
    public interface IfactoryInterest
    {
        double Interest(double amount, double interest, int years,int annualfrequency=0);

    }
}
