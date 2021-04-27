/* Given two strings, find the number of common characters between them. */

int commonCharacterCount(string s1, string s2) {
    int count = 0;
    var done = new List<char>();
    var haystack = s1.Length <= s2.Length ? s1 : s2;
    foreach (var needle in haystack)
    {
        if (!done.Contains(needle))
        {
            var i1 = s1.Count(a => a == needle);
            var i2 = s2.Count(a => a == needle);
            count += Math.Min(i1, i2);
            done.Add(needle);
        }
    }
    return count;
}
