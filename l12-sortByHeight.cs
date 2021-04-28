/* Some people are standing in a row in a park. There are trees between them which cannot be moved. Your task is to rearrange the people by their heights in a non-descending order without moving the trees. People can be very tall! NB: -1 means tree, else is person's height. */

int[] sortByHeight(int[] a) {
    var men = a.Where(i => i != -1).ToArray();
    Array.Sort(men);
    int toSelect = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] != -1)
        {
            a[i] = men[toSelect++];
        }
    }
    return a;
}
