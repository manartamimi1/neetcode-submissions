public class Solution {
    public bool IsValidSudoku(char[][] board) {
       
        for(int row = 0 ; row < board.Length ; row++){
              HashSet<char> result = new HashSet<char>();
            for(int col =0; col< board[row].Length ; col++){
                char current = board[row][col];
                if(current == '.'){
                    continue;
                }
                if(result.Contains(current)){
                     return false;
                }
                result.Add(current);
            }
            }
            for(int col = 0 ; col < board.Length ; col++){
              HashSet<char> result1 = new HashSet<char>();
            for(int row =0; row< board.Length ; row++){
                char current = board[row][col];
                if(current == '.'){
                    continue;
                }
                if(result1.Contains(current)){
                     return false;
                }
                result1.Add(current);

            }
            }
       for (int startRow = 0; startRow < 9; startRow += 3)
{
    for (int startCol = 0; startCol < 9; startCol += 3)
    {
        HashSet<char> result2 = new HashSet<char>();

        for (int row = startRow; row < startRow + 3; row++)
        {
            for (int col = startCol; col < startCol + 3; col++)
            {
                char current = board[row][col];

                if (current == '.')
                {
                    continue;
                }

                if (result2.Contains(current))
                {
                    return false;
                }

                result2.Add(current);
            }
        }
    }
}
        
        return true;
    }
}
