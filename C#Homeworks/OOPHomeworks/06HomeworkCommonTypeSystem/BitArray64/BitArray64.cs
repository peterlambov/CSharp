using System;
using System.Collections.Generic;
using System.Linq;
public class BitArray64 : IEnumerable<int>
{
    private ulong array;

    public BitArray64(ulong array)
    {
        this.Array = array;
    }


    public ulong Array
    {
        get
        {
            return this.array;
        }
        set
        {
            this.array = value;
        }
    }


    public IEnumerator<int> GetEnumerator()
    {
        int[] bits = this.GetArray();
        for (int i = 0; i < bits.Length; i++)
        {
            yield return bits[i];
        }

    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public override bool Equals(object obj)
    {
        BitArray64 temporary = obj as BitArray64;
        if (temporary == null)
        {
            return false;
        }

        if (!Object.Equals(temporary, this))
        {
            return false;
        }
        return true;

    }


    public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray)
    {
        return BitArray64.Equals(firstArray, secondArray);
    }

    public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
    {
        return !BitArray64.Equals(firstArray, secondArray);
    }

    public override int GetHashCode()
    {
        return this.array.GetHashCode() ^ 1;
    }
    public int this[int index]
    {
        get
        {
            if (index < 0 || index > 63)
            {
                throw new IndexOutOfRangeException();
            }
            
            return this.GetArray()[index];
        }
    }

    public int[] GetArray()
    {
        ulong num = this.array;

        int[] bits = new int[64];
        int counter = 63;

        while (num > 0)
        {
            bits[counter] = (int)num % 2;
            num = num / 2;
            counter--;
        }

        do
        {
            bits[counter] = 0;
            counter--;
        }
        while (counter >= 0);

        return bits;

    }
}

