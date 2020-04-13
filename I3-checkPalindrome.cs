/* Given the string, check if it is a palindrome. */

bool checkPalindrome(string inputString) {
    StringBuilder sb = new StringBuilder(inputString.Length);
    for (int i = inputString.Length - 1; i >= 0; i--)
    {
        sb.Append(inputString[i]);
    }
    return inputString.Equals(sb.ToString());
}
