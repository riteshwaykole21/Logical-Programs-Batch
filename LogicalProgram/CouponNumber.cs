using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class CouponNumber
    {
        int count = 0;
        public void RandomCouponNumber()
        {
            int[] RandomCouponArray = new int[10];
            Random random = new Random();   
            for(int i = 0; i < RandomCouponArray.Length; i++)
            {
                int number = random.Next(1,20);
                if(!IsExit(RandomCouponArray,number))
                {
                    RandomCouponArray[i] = number;
                }
            }
            count++;
            foreach(var data in RandomCouponArray)
            {
                Console.WriteLine("Random Number Are " +data+ " ");
            }
            Console.WriteLine("{0} Random Number Are Needed To Have 10 Distinct Coupon Number",count );
        }
        public bool IsExit(int[]randomArrays,int ranNum)
        {
            foreach(int data in randomArrays)
            {
                if (data== ranNum)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
