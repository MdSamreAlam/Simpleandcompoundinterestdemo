using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompoundInterestCalculation;
using Xunit;

namespace DemoLibrary.Test
{
   public class CompoundInterest
    {
        [Fact]
        public void testcompoundinterest()
        {


            //compoundIntrest.CalculateCompoundInterest(1000, 7, 1);
            //Arrange
            CompoundIntrest compoundIntrest = new CompoundIntrest();

           
            //Act
        double actual = compoundIntrest.CalculateCompoundInterest(1000,0.07,1);
            //Asset
            Assert.Equal(1070, actual);
           
        }
    }
}
