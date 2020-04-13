/* Given an array of integers, find the pair of adjacent elements that has the largest product and return that product. */

int adjacentElementsProduct(int[] inputArray) {
    int lenA = inputArray.Length;
    if (lenA <= 0) return 0;
    int product = int.MinValue;
    for(int i = 0; i < lenA - 1; i++)
    {
        int curProduct = inputArray[i] * inputArray[i + 1];
        if (curProduct > product)
        {
            product = curProduct;
        }
    }
    return product;
}
