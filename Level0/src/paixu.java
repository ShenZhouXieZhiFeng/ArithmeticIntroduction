
public class paixu {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = {1,7,4,8,2,9};
//		insert(arr);
//		selected(arr);
		maopao(arr);
		for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}
	}
	
	//1,7,4,8,2,9
	public static void guibing(int[] arr) {
		
	}
	
	//冒泡排序，一遍遍的让最满足条件的数据冒出来
	//两两之间进行对比，如果满足条件（较大或较小）则进行交换
	//第一遍之后，最大或最小的数就能够被放置到最左边或最右边
	public static void maopao(int[] arr) {
//		for (int i = 0; i < arr.length; i++) {
//			for (int j = i; j < arr.length; j++) {
//				if (arr[i] > arr[j]) {
//					int t = arr[i];
//					arr[i] = arr[j];
//					arr[j] = t;
//				}
//			}
//		}
		//从左到右扫描过去
//		for (int i = 0; i < arr.length; i++) {
//			for (int j = 0; j < arr.length - i - 1; j++) {
//				if (arr[j] > arr[j+1]) {
//					int t = arr[j];
//					arr[j] = arr[j+1];
//					arr[j+1] = t;
//				}
//			}
//		}
		//从右到左扫描
		//1,7,4,8,2,9
		//1 7 4 8 9 2
		//1 7 4 9 8 2
		//1 7 9 4 8 2
		//1 9 7 4 8 2
		//9 1 7 4 8 2
//		for (int i = arr.length - 1; i >= 0; i--) {
//			for (int j = arr.length - 1; j > arr.length - i - 1; j--) {
//				if (arr[j] > arr[j-1]) {
//					int t = arr[j];
//					arr[j] = arr[j-1];
//					arr[j-1] = t;
//				}
//			}
//		}
		//优化
		int v = 0;
		boolean swaped;//使用一个标志判断接下来是否还会执行数据交换
		int n = arr.length;
		//1,7,4,8,2,9 
		do {
			swaped = false;
			for (int i = 1; i < n; i++) {
				if (arr[i - 1] > arr[i]) {
					v ++;
					int temp = arr[i - 1];
					arr[i - 1] = arr[i];
					arr[i] = temp;
					swaped = true;//如果此次有发生数据交换，说明while还有执行的必要
				}
			}
			n--;
		} while (swaped);//如果本次循环没有发生数据交换，说明后续的数据都是按照规则排列的，没有必要再进行循环
//		System.out.println(v);
	}
	
	
	//选择排序
	//假设当前要排序的数（n）最小，从n+1开始比较，如果n+1的数小于n的数，就将两者进行交换
	//核心是选择二字，从后面的数中依次的选择出最小的数，放置到当前要排序的位置上
	public static void selected(int[] arr) {
		int len = 0;
		for (int i = 0; i < arr.length; i++) {
			for (int j = i + 1; j < arr.length; j++) {
				if(arr[j] < arr[i]){
					int temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
					len++;
				}
			}
		}
		System.out.println(len);
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
