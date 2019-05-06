using System.Collections.Generic;
using UnityEngine;

public class Confluxsort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void confluxsort(ref List<int> data)
    {
        // figure out a value k such that k is the next smallest (or equal) power of two for data.Count
        // if (data.Count <= 1)
        // {
        //     return;
        // }
        // call confluxsort(ref data, 0, k-1);
        // if (k-1 < data.Count-1)
        // {
        //     call confluxsort(ref data, k, data.Count-1);
        //     merge(ref data, 0, k-1, data.Count-1);
        // }
    }

    private void confluxsort(ref List<int> data, int left, int right) // end is inclusive
    {
        // set up a data structure that has auxiliary space of n/2, n/4, n/8 ... 4, 2, 1 (valloc array)
        // set up a bitset that indicates if the auxiliary n/2, n/4, n/8 ... 4, 2, 1 spots are occupied
        // set up a double-ended buffer that has auxiliary space of 3n/4
        // set up a bit that indicates which side of the double-ended buffer was last used
        // keep track of the number of elements in the double-ended buffer at the location you care about (in theory this is implicit, since the double-ended buffer is temporary/ephemeral and should not store anything for successive rounds)

        // int sorted_sequence_start = left;
        // while (left < right)
        //{
        //    if (data[left] > data[left+1])
        //    {
        //        take the sequence so far and put it into the valloc array greedily if possible (and set bit) # LOCATION 1
        //        otherwise you have to put the value into the double ended buffer and merge (and flip bit) # LOCATION 2
        //        if you put the data in the double ended buffer, you must immediately do a merge operation in a while loop until you reach the top or find an unoccupied space. (and clear the bit of the current level on each iteration) # LOCATION 3
        //        sorted_sequence_start = left+1;
        //    }
        //    left++;
        //}
        // at the end, do LOCATION #1-3 one more time
        // find every bit from smallest to largest that has not been merged.
        // for each of these bits, go through the procedure, merging the data and being careful of the length of the sorted list (using the double-ended buffer for merging back and forth -- for cache coherency).
        // merge the last two levels of the n/2 slot and the valloc array (for the current bit's size) into the original array.


        // MISCELLANEOUS NOTES: (TODO, FIXME)
        // I never did the optimization where you merge directly out of the original array and the occupied slot into the valloc array (I assumed you copy it to the valloc array first). The trick here is you do need to do this if the number of elements is n/2 (the largest level) because you will be copying back into the original array during the merge.
        // I never fully elaborated on how to set up the valloc array, et cetera.
    }
}
