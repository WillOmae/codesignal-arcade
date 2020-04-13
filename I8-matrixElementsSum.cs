/* Given matrix, a rectangular matrix of integers...add up all the values that don't appear below a 0 */

int matrixElementsSum(int[][] matrix) {
    int sum = 0;
    int b1 = matrix.GetUpperBound(0);
    for (int i = 0; i <= b1; i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            if (matrix[i][j] == 0)
            {
                if (i < b1)
                {
                    matrix[i + 1][j] = 0;
                }
            }
            else
            {
                sum += matrix[i][j];
            }
        }
    }
    return sum;
}
