using System;

class FriendBits
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        bool leftBit = false;
        bool rightBit = false;
        uint? onLeft = uint.MaxValue;
        uint? onRight = uint.MaxValue; ;
        string friends = string.Empty;
        string alones = string.Empty;
        for (int bitN = 31; bitN >= 0; bitN--)
        {
            uint currentB = (n & ((uint)1 << bitN)) != 0 ? (uint)1 : (uint)0;
            
            leftBit = bitN < 31;
            if (leftBit)
            {
                onLeft = (n & ((uint)1 << bitN+1)) != 0 ? (uint)1 : (uint)0;
            }
            else
            {
                onLeft = null;
            }
            rightBit = bitN > 0;
            if (rightBit)
            {
                onRight = (n & ((uint)1 << bitN-1)) != 0 ? (uint)1 : (uint)0;
            }
            else
            {
                onRight = null;
            }
            if ((leftBit && rightBit) && (currentB == onLeft || currentB == onRight))
            {
                friends = friends + currentB;
            }
            else if (leftBit && currentB == onLeft)
            {
                friends = friends + currentB;
            }
            else if (rightBit && currentB == onRight)
            {
                friends = friends + currentB;
            }
            else
            {
                alones = alones + currentB;
            }

        }
        if (string.IsNullOrEmpty(friends))
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(Convert.ToUInt32(friends, 2));
        }
        
        if (string.IsNullOrEmpty(alones))
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(Convert.ToUInt32(alones, 2));
        }
    }
}
