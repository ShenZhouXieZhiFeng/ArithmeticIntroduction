import java.util.Arrays;
import java.util.HashSet;


public class shudu {

	/**
	 * @param args
	 */
//	public static void main(String[] args) {
//		// TODO Auto-generated method stub
////		char[][] arrs = {{'5','.','.','.','7','.','.','.','.'},
////						 {'4','7','.','.','.','.','.','.','.'},
////						 {'3','.','.','.','.','.','.','.','.'},
////						 {'2','.','.','.','.','.','.','.','.'},
////						 {'1','.','.','.','.','.','.','.','.'},
////						 {'6','.','.','.','.','.','.','.','.'},
////						 {'7','.','.','.','.','.','.','.','.'},
////						 {'8','.','.','.','.','.','.','.','.'},
////						 {'9','.','.','.','.','.','.','.','.'}};
////		System.out.println(isValidSudoku(arrs));
//		test(0,0);
//	}
	
	public static void test(int i,int j) {
		for(int k = 0; k < 16 ; k++){
			//随着k的增大，xx也慢慢增大，yy一个周期，xx增大一次
			int xx = i + k/5;
			//yy的值每次增大一个，并在0-（n-1）之间循环
			int yy = j + k%5;
			System.out.println(xx + "|" + yy);
		}
	}
	
	//判断数独是否合法
	public static boolean isValidSudoku(char[][] board) {
		StringBuilder str = new StringBuilder();
		
		for (int i = 0; i < board.length; i++) {
			for (int j = 0; j < board[i].length; j++) {
				String s = String.valueOf(board[i][j]);
				if (str.indexOf(s) >= 0 && !s.equals(".")) {
					return false;
				}
				str.append(s);
			}
			str.delete(0, str.length());
		}
		
		for (int i = 0; i < board.length; i++) {
			for (int j = 0; j < board.length; j++) {
				String s = String.valueOf(board[j][i]);
				if (str.indexOf(s) >= 0 && !s.equals(".")) {
					return false;
				}
				str.append(s);
			}
			str.delete(0, str.length());
		}
		
		for (int i = 0; i < board.length;i+=3 ) {
			for (int j = 0; j < board.length; j+=3) {
				for(int k = 0; k <9 ; k++){
					int xx = i + k/3;
					int yy = j + k%3;
					String s = String.valueOf(board[xx][yy]);
					if (str.indexOf(s) >= 0 && !s.equals(".")) {
						System.out.println(xx + "|" + yy);
						return false;
					}
					str.append(s);
                }
				str.delete(0, str.length());
			}
		}

        return true;
    }
}
