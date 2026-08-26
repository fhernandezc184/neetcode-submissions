public class Solution {
    public int NumIslands(char[][] grid) {

        if(grid.Length == 0) return 0; 

        int rows = grid.Length;
        int cols = grid[0].Length;
        int count = 0;
        Stack<(int, int)> stack = new Stack<(int, int)>();
        int[][] directions = {
            [-1,0], //up
            [+1,0], //down
            [0,-1], //left
            [0,+1] //right
            };

        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                if(grid[i][j] == '1'){
                    count++;
                    grid[i][j] = '0';
                    stack.Push((i,j));

                    while(stack.Count > 0){
                        var cell = stack.Pop();

                        foreach(int[] direction in directions){
                            var row = cell.Item1 + direction[0];
                            var col = cell.Item2 + direction[1];

                            if(row < 0 || col < 0 || row >= rows || col >= cols)
                                continue;

                            if(grid[row][col] == '1'){
								grid[row][col] = '0';
								stack.Push((row, col));
							}
                        }

                    }
                }
            }
        }
        return count;
    }
}