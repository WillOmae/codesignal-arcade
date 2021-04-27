/* Ticket numbers usually consist of an even number of digits. A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half. Given a ticket number n, determine if it's lucky or not. */

bool isLucky(int n) {
    string s = n.ToString();
    int numCount = s.Length;
    int half = numCount / 2;
    int rightTotal = 0, leftTotal = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (i < half)
        {
            rightTotal += int.Parse(s[i].ToString());
        }
        else
        {
            leftTotal += int.Parse(s[i].ToString());
        }
    }
    return rightTotal == leftTotal;
}
