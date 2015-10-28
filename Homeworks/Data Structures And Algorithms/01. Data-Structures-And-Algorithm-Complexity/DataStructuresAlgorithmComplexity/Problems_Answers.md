## Data Structures, Algorithms and Complexity Homework

1. What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  - ANSWER: Since the outer loop is running exactly n-times and the inner loop will execute exactly n times for each interation of the outer loop.
			Thats mean that we have quadratic complexity - O(n*n)
  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```

2. What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  - ANSWER: We have two nested loops, so in the worst case scenario we have O(n*m) complexity.
			The fastest way will be if the first element in every row is odd. Then the inner loop will never be executed and 
			complexity ill be linear - O(n).
  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```

3. (*) What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  - ANSWER: Since the method calls itself recursively we have n-times executes of it. In every method execution the for loop makes m-iterrations.
			So we have O(m*n) complexity
			PS: we can get a IndexOutOfRange Exception if n>m since col is checked against row length in the loop. Maybe is a mistake in the task.
  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```
