public class Solution {
    public int NumIslands(char[][] grid) {

        if(grid.Length == 0) return 0; 

        int rows = grid.Length;
        int cols = grid[0].Length;
        int count = 0;

        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                if(grid[i][j] == '1'){
                    count++;
                    DFS(grid, i, j);
                }
            }
        }
        return count;
    }
    
    private void DFS(char[][] grid, int row, int col){

        int rows = grid.Length;
        int cols = grid[0].Length;

        if(row < 0 || col < 0 || row >= rows || col >= cols || grid[row][col] == '0')
            return;
        
        grid[row][col] = '0';

        //up
        DFS(grid, row-1, col);
        //down
        DFS(grid, row+1, col);
        //left
        DFS(grid, row, col-1);
        //right
        DFS(grid, row, col+1);
    }
}