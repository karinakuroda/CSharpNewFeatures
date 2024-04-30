namespace MatrixTest;
using FluentAssertions;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var arraySize = 3;
        var zeroElementInRow = -1;
        var zeroElementInColumn = -1;
        int[][] matrix;
        matrix = new int[arraySize][];
        matrix[0] = new[] { 1, 1, 1 };
        matrix[1] = new[] { 1, 0, 1 };
        matrix[2] = new[] { 1, 1, 1 };
        
        int[][] expectedMatrix;
        expectedMatrix = new int[arraySize][];
        expectedMatrix[0] = new[] { 1, 0, 1 };
        expectedMatrix[1] = new[] { 0, 0, 0 };
        expectedMatrix[2] = new[] { 1, 0, 1 };

        //1,0,1 [0][1]
        //0,0,0 [1][]
        //1,0,1 [2][1]
        //zeroElementInRow=1
        //zeroElementInColumn = 1
        for (int j = 0; j <= arraySize-1; j++)
        {
            for (int i = 0; i <= arraySize-1; i++)
            {
                if (matrix[j][i] != 0) continue;
                
                zeroElementInRow = j;
                zeroElementInColumn = i;
            }
        }

        for (int i = 0; i <= arraySize-1; i++)
        {
            matrix[zeroElementInRow][i] = 0;
            matrix[i][zeroElementInColumn] = 0;
        }
        matrix.Should().BeEquivalentTo(expectedMatrix);
    }
    
    
}