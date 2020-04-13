/* Given a sequence of integers as an array, determine whether it is possible to obtain a strictly increasing sequence by removing no more than one element from the array.*/

bool almostIncreasingSequence(int[] sequence) {
  int l = sequence.Length, p = 0, c = 0;
  for (int i = 1; i < l; i++)
  {
    if (sequence[i-1]>=sequence[i])
    {
      p=i; 
      c++;
    }
  }
  if (c > 1) return false;
  if (c == 0) return true;
  if (p == l-1 || p == 1) return true;
  if (sequence[p-1] < sequence[p+1]) return true;
  if (sequence[p-2] < sequence[p]) return true;
  return false;
}
