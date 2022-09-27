// public void MatrixMultiplicate(int[,] aMatrix, int[,] bMatrix, out int[,] product)
    // https://learn.microsoft.com/ru-ru/cpp/parallel/amp/walkthrough-matrix-multiplication?
    // view=msvc-160&viewFallbackFrom=vs-2019
    // проверка работы программы: 
    // https://ru.onlinemschool.com/math/assistance/matrix/multiply/?
    // oms_all=a%3d%7b%7b4,5%7d,%7b2,2%7d,%7b4,5%7d%7d,b%3d%7b%7b3,4,5,2%7d,%7b4,2,3,3%7d%7d
    //https://github.com/Herobrina2306/Dz8.git

    {
        product = new int[aMatrix.GetLength(0),bMatrix.GetLength(1)];
        for (int row = 0; row < aMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < bMatrix.GetLength(1); col++)
            {
                for (int inner = 0; inner < bMatrix.GetLength(0); inner++)
                {
                    product[row,col] += aMatrix[row,inner] * bMatrix[inner,col];
                }
            }
        }
    }
