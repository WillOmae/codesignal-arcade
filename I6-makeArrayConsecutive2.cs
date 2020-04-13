/* arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1...figure out the minimum number of additional statues needed. */

int makeArrayConsecutive2(int[] statues) {
    int len = statues.Length;
    if (len <= 0) return 0;
    bool flag;
    do
    {
        flag = false;
        for (int i = 0; i < len - 1; i++)
        {
            if (statues[i] > statues[i + 1])
            {
                flag = true;
                int temp = statues[i];
                statues[i] = statues[i + 1];
                statues[i + 1] = temp;
            }
        }
    } while (flag);
    int sum = 0;
    for (int i = 0; i < len - 1; i++)
    {
        Console.Write(statues[i] + ", ");
        int diff = statues[i + 1] - statues[i] - 1;
        if(diff >= 1)
        {
            sum += diff;
        }
    }
    return sum;
}
