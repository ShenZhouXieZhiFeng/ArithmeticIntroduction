
public class paixu {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = {1,7,1,4,8,2,9};
		insert(arr);
		for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}
	}
	
	//插入排序
	//核心和在二次循环中需要从后往前比较
	//1,3,5    2,6
	//排第n个数时，假设前n-1个数已经排列好了，将第n个数的值保存起来
	//开始把第n-1个数开始，与第n个数进行比较，如果第n个数比较小，就将对应的被比较到的数往后移动一位
	//最后把保存起来的第n个数赋给最后一次比较成功的数的位置
	public static void insert(int[] arr) {
		//我的第一个版本,代码多，做的交换比较少
//		int t = 0;
//		int v = -1;
//		for (int i = 1; i < arr.length; i++) {
//			t = arr[i];
//			for (int j = i; j >= 0; j--) {
//				if (arr[j] > t) {
//					arr[j+1] = arr[j];
//					v = j;
//				}
//			}
//			if(v != -1){
//				arr[v] = t;
//			}
//			v = -1;
//		}
		for(int i = 1;i < arr.length ; i++){
			for(int j = i;j > 0;j --){
				if(arr[j] < arr[j-1]){
					int temp = arr[j];
					arr[j] = arr[j-1];
					arr[j-1] = temp;
				}else{
					//接下来是无用功
					break;
				}
			}
		}
		
	}
}
