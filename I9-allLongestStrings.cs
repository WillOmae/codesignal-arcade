/* Given an array of strings, return another array containing all of its longest strings. */

string[] allLongestStrings(string[] inputArray) {
    int longest = 0, count = 0;
    foreach (string s in inputArray)
    {
        if (s.Length >= longest)
        {
            longest = s.Length;
        }
    }
    List<string> output = new List<string>(inputArray.Length);
    foreach (string s in inputArray)
    {
        if (s.Length == longest) output.Add(s);
    }
    return output.ToArray();
}
