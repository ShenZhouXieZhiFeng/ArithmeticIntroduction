
public class paixu {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] arr = {1,7,4,1,8,2,9,16,9,23,56};
//		insert(arr);
		selected(arr);
		for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}
	}
	
	//ѡ������
	//���赱ǰҪ���������n����С����n+1��ʼ�Ƚϣ����n+1����С��n�������ͽ����߽��н���
	//������ѡ����֣��Ӻ���������ε�ѡ�����С���������õ���ǰҪ�����λ����
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
	
	//��������
	//���ĺ��ڶ���ѭ������Ҫ�Ӻ���ǰ�Ƚ�
	//1,3,5    2,6
	//�ŵ�n����ʱ������ǰn-1�����Ѿ����к��ˣ�����n������ֵ��������
	//��ʼ�ѵ�n-1������ʼ�����n�������бȽϣ������n�����Ƚ�С���ͽ���Ӧ�ı��Ƚϵ����������ƶ�һλ
	//���ѱ��������ĵ�n�����������һ�αȽϳɹ�������λ��
	public static void insert(int[] arr) {
		//�ҵĵ�һ���汾,����࣬���Ľ����Ƚ���
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
					//�����������ù�
					break;
				}
			}
		}
		
	}
}