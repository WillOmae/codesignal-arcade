/* Your task is to find the area of a polygon for a given n. */

int shapeArea(int n) {
    int product = n * n;
    if(n > 0)
    {
        product += (n - 1) * (n - 1);
    }
    return product;
}
