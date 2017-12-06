import java.awt.print.Printable;
import java.util.ArrayList;
import java.util.List;
import java.util.Stack;

import javax.annotation.PostConstruct;

import com.sun.org.apache.xalan.internal.xsltc.runtime.Node;


public class exe01 {

	/**
	 * @param args
	 */
	//public static void main(String[] args) {
		// TODO Auto-generated method stub
		//System.out.println(que01(47));
//		char[] str = new char[100];
//		String string = "";
//		for (int i = 0; i < string.length(); i++) {
//			str[i] = string.charAt(i);
//		}
//		System.out.println(replaceBlank(str,11));
//		System.out.println(str);
		
//		System.out.println(countOnes(1));
		
//		ListNode node1 = new ListNode(1);
//		ListNode node2 = new ListNode(2);
//		ListNode node3 = new ListNode(3);
//		node1.next = node2;
//		node2.next = node3;
////		node1.print();
//		ListNode node4 = reverse2(node1);
//		node4.print();
		
//		int[] arr = {9,1,2,4,5,6,7};
//		System.out.println(findMin(arr));
		
//		int[] pre = {1,2,3};
//		int[] in = {3,2,1};
//		
//		TreeNode node = buildTree(pre,in);
//		node.print();
		
//		int[] nums = {16,17,4,3,5,2};
//		arrayReplaceWithGreatestFromRight(nums);
//		for (int i = 0; i < nums.length; i++) {
//			System.out.println(nums[i]);
//		}
		
//		MyQueue queue = new MyQueue();
//		queue.push(1);
//		System.out.println(queue.pop());
//		queue.push(2);
//		queue.push(3);
//		System.out.println(queue.top());
//		System.out.println(queue.pop());
//		ListNode node1 = new ListNode(1);
//		ListNode node2 = new ListNode(2);
//		ListNode node3 = new ListNode(3);
//		ListNode node4 = new ListNode(2);
//		node1.next = node2;
//		node2.next = node3;
//		node3.next = node4;
//		ListNode res = removeElements(node1,2);
//		res.print();
//		int[] a = {5,3,4,1,2};
//		sortIntegers(a);
//		for (int i = 0; i < a.length; i++) {
//			System.out.println(a[i]);
//		}
//		TreeNode root = new TreeNode(1);
//		TreeNode root1 = new TreeNode(-5);
//		TreeNode root2 = new TreeNode(2);
//		TreeNode root3 = new TreeNode(0);
//		TreeNode root4 = new TreeNode(3);
//		TreeNode root5 = new TreeNode(-4);
//		TreeNode root6 = new TreeNode(-5);
//		root.left = root1;
//		root.right = root2;
//		root1.left = root3;
//		root1.right = root4;
//		root2.left = root5;
//		root2.right = root6;
//		
//		TreeNode max = maxNode(root);
//		System.out.println(max.val);
	//}
	
	public class Rectangle {
		
		public float width,height;
		
		public Rectangle(float _wid,float _hei){
			width = _wid;
			height = _hei;
		}
		
		public int getArea(){
			return (int)(width * height);
		}
	}
	
	//�ڶ�������Ѱ��ֵ���Ľڵ㲢���ء�
	public static TreeNode maxNode(TreeNode root) {
        if(root == null)
        	return root;
        TreeNode max = root;
        max = findMax(root,max);
        return max;
    }
	public static TreeNode findMax(TreeNode root,TreeNode max){
		if(root == null)
			return max;
		if (root.val > max.val) {
			max = root;
		}
		if(root.left != null){
			max = findMax(root.left,max);
		}
		if(root.right != null){
			max = findMax(root.right,max);
		}
		return max;
	}
	
	public int countNodes(ListNode head) {
	        int len = 0;
	        while(head != null){
	        	len ++;
	        	head = head.next;
	        }
	        return len;
    }
	
	public static void sortIntegers(int[] A) {
		//ð��
		for (int i = 0; i < A.length; i++) {
			for (int j = 0; j < A.length-i-1; j++) {
				if (A[j] > A[j+1]) {
					int t = A[j];
					A[j] = A[j+1];
					A[j+1] = t;
				}
			}
		}
		//ѡ������
//        for (int i = 0; i < A.length; i++) {
//			for (int j = i + 1; j < A.length; j++) {
//				if (A[i] > A[j]) {
//					int t = A[i];
//					A[i] = A[j];
//					A[j] = t;
//				}
//			}
//		}
    }
	
	//ɾ�������е��ڸ���ֵval�����нڵ㡣
	public static ListNode removeElements(ListNode head, int val) {
		if(head == null)
			return head;
		ListNode p = head,q = head.next;
		while(q != null){
			if(q.val == val){
				p.next = q.next;
				q = q.next;
			}else{
				p = q;
				q = q.next;
			}
		}
		if(head.val == val) head = head.next;
		return head;
    }
	
	//***����������
	//����һ�����������ҳ�����·���и��ڵ�����ܺ͵��ڸ��� Ŀ��ֵ ��·����
	//һ����Ч��·����ָ���ǴӸ��ڵ㵽Ҷ�ڵ��·����
	public List<List<Integer>> binaryTreePathSum(TreeNode root, int target) {
		List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(null == root) return result;
        Stack<Integer> stack = new Stack<Integer>();
        binaryTreePathSum(result, stack, root, 0, target);
        return result;
    }
	public void binaryTreePathSum(List<List<Integer>> result, Stack<Integer> stack, TreeNode root, int sum, int target) {
		sum += root.val;
		stack.push(root.val);
		if(sum == target && root.left == null && root.right == null){
			List<Integer> list = new ArrayList<Integer>(stack);
			result.add(list);
			stack.pop();
			return;
		}else{
			if (root.left != null) {
				binaryTreePathSum(result,stack,root.left,sum,target);
			}else if(root.right != null){
				binaryTreePathSum(result,stack,root.right,sum,target);
			}
			stack.pop();
		}
    }
	
	public class MyQueue {
		List<Integer> nums;
	    public MyQueue() {
	    	nums = new ArrayList<Integer>();
	    }

	    /*
	     * @param element: An integer ѹ��ջ��
	     * @return: nothing
	     */
	    public void push(int element) {
	        // write your code here
	    	nums.add(element);
	    }

	    /*
	     * @return: An integer ɾ���Ӷ�Ԫ�ز�����
	     */
	    public int pop() {
	    	if (nums.size() <= 0) {
				return -1;
			}
	    	int v = nums.get(0);
	    	nums.remove(0);
	    	return v;
	    }

	    /*
	     * @return: An integer ���ضӶ�Ԫ��
	     */
	    public int top() {
	        // write your code here
	    	if (nums.size() <= 0) {
				return -1;
			}
	    	return nums.get(0);
	    }
	}
	
//	��һ��������, �õ�ǰԪ��֮�������е����Ԫ�����滻��ǰԪ��(�Ҳ�����Ԫ��). 
//	��Ϊ���һ��Ԫ�ص��ұ�û��Ԫ����, ������ -1 ���滻���ֵ. 
//	�ٸ�����, �������Ϊ [16,17,4,3,5,2], ��ô������Ҫ�޸�Ϊ [17,5,5,5,2,-1].
	public static void arrayReplaceWithGreatestFromRight(int[] nums) {
		if(nums.length <= 0)
			return;
        for (int i = 0; i < nums.length - 1; i++) {
        	nums[i] = nums[i+1];
			for (int j = i + 2; j < nums.length; j++) {
				if (nums[j] > nums[i]) {
					nums[i] = nums[j];
				}
			}
		}
        nums[nums.length - 1] = -1;
    }
	
	
	
	//ǰ�������������������������
	//preorderǰ�����
	//inorder�������
	public static TreeNode buildTree(int[] preorder, int[] inorder) {
		TreeNode root = makeTree(preorder, 0,preorder.length, inorder, 0, inorder.length);
		return root;
    }
	public static TreeNode makeTree(int[] preorder,int startPre,int lenper,int[] inorder,int startIn,int lenIn) {
		if (lenper < 1) {
			return null;
		}
		TreeNode root;
		//�ҵ���һ��ĸ��ڵ㣬��ǰ������ĵ�һ���ڵ�
		int rootVal = preorder[startPre];
		root = new TreeNode(rootVal);
		//��������������ҵ����ڵ�
		int offset;
		boolean isFound = false;
		//�ӵ�ǰ������������ʼ�ڵ㵽���ĳ���
		for (offset = 0;offset < lenIn;offset ++) {
			if (inorder[offset + startIn] == rootVal) {
				isFound = true;
				break;
			}
		}
		if (!isFound) {
			return root;
		}
		//�����ҵ���offsetֵ���������������
		root.left = makeTree(preorder, startPre+1, offset, inorder, startIn, offset);
		root.right = makeTree(preorder, startPre + offset + 1, lenper - offset - 1, inorder, startIn + offset + 1, lenIn - offset - 1);
		return root;
	}
	public static class TreeNode {
	    public int val;
	    public TreeNode left, right;
	    public TreeNode(int val) {
	    	this.val = val;
	    	this.left = this.right = null;
	    }
	    public void print() {
			System.out.println(val);
			if (left != null) {
				left.print();
			}else {
				System.out.println("#");
			}
			if (right != null) {
				right.print();
			}else {
				System.out.println("#");
			}
		}
	}
	
	//������û���⣬������lincodeƽ̨ͨ����
//	����һ����ת�������������ʼλ����δ֪�ģ�����0 1 2 4 5 6 7 ���ܱ����4 5 6 7 0 1 2����
//	����Ҫ�ҵ�������С��Ԫ�ء�
//	����Լ��������в������ظ���Ԫ�ء�
	public static int findMin(int[] nums) {
		int min = nums[0];
		for (int i = 1; i < nums.length; i++) {
			if (nums[i] < min) {
				min = nums[i];
			}
		}
		return min;
	}
	
	public static ListNode reverse2(ListNode head){
		if (head == null || head.next == null) {
			return head;
		}
		ListNode prev = reverse2(head.next);
        head.next.next = head;
        head.next = null;
		return prev;
	}
	//��ת����
	//����һ������1->2->3->null�������ת�������Ϊ3->2->1->null
	public static ListNode reverse(ListNode head) {
//		if (head == null) {
//			return null;
//		}
//		if (head.next == null) {
//			return head;
//		}
//		List<ListNode> temps = new ArrayList<ListNode>();
//		while (true) {
//			temps.add(head);
//			head = head.next;
//			if (head.next == null) {
//				temps.add(head);
//				break;
//			}
//		}
//		for (int i = temps.size() - 1; i > 0; i --) {
//			temps.get(i).next = temps.get(i-1);
//		}
//		temps.get(0).next = null;
//		return head;
		//�Ż�
		ListNode prev = null;
        while(head!=null){
            ListNode tmp = head.next;
            head.next = prev;
            prev = head;
            head = tmp;
        }
        return prev;
    }
	public static class ListNode {
		public int val;
		public ListNode next;
		public ListNode(int val) {
			this.val = val;
	        this.next = null;
		}
		public void print() {
			System.out.println(val);
			if (next != null) {
				next.print();
			}
		}
	}

	//������һ�� 32 λ�������Ķ����Ʊ�ʾ���ж��ٸ� 1.
	public static int countOnes(int num) {
//		if (num < 0) {
//			num = -num;
//		}
//		int count = 0;
//		//����num = 6��������Ϊ0110(8,4,2,1)
//        while(num != 0){
//        	//λ�룬���num��Ӧ�����Ƶĵ�0ΪΪ1��λ��0x01�Ľ��Ϊ1
//            count += num & 0x01;
//            //���������ƶ�һλ��һ�κ�0110���0011����3
//            num = num >> 1;
//        }
//        return count;
		int count = 0;
        while(num!=0){
        	//num & (num-1);����ȥ��num��Ӧ���������ұߵ�1
            num = num & (num-1);
            count++;
        }
        return count;
    }
	
	//���һ�ַ�������һ���ַ����е����пո��滻�� %20 ������Լ�����ַ������㹻�Ŀռ��������µ��ַ�������õ����ǡ���ʵ�ġ��ַ����ȡ�
	//��ĳ�����Ҫ���ر��滻����ַ����ĳ��ȡ�
	public static int replaceBlank(char[] string, int length) {
		if (string == null || string.length == 0) {
			return 0;
		}
		char[] res = new char[string.length];
		int len = 0;
		for (int i = 0; i < length; i++,len++) {
			if (string[i] == ' ') {
				res[len] = '%';
				res[++len] = '2';
				res[++len] = '0';
			}else {
				res[len] = string[i];
			}
		}
		
		for (int i = 0; i < len; i++) {
			string[i] = res[i];
		}
		return len;
//		int reallen = length;
//        for(int i = 0;i<length;i++){
//            if(string[i] == ' ')
//                reallen += 2;
//        }
//        int index = reallen;
//        for(int i = length - 1;i>= 0 ;i-- ){
//            if(string[i] == ' '){
//                string[--index] = '0';
//                string[--index] = '2';
//                string[--index] = '%';
//            }else{
//                string[--index] = string[i];
//            }
//        }
//        return reallen;
    }
	
//	����쳲����������е� N ������
//	��ν��쳲�����������ָ��
//	ǰ2������ 0 �� 1 ��
//	�� i �����ǵ� i-1 �����͵�i-2 �����ĺ͡�
//	쳲��������е�ǰ10�������ǣ�
//	0, 1, 1, 2, 3, 5, 8, 13, 21, 34 ...
	public static int que01(int n) {
		if (n == 1) {
			return 0;
		}else if(n == 2) {
			return 1;
		}
		//�ݹ飬�ٶ����ܶ�
//		return que01(n - 1) + que01(n - 2);
		//ѭ����ʽ������˼���ǽ�ǰ������һֱ�����������ظ��ı仯
	    int num1=0;
        int num2=1;
        int sum = 0;
        for (int i = 3; i <= n; i++) {
        	sum = num1 + num2;
            num1 = num2;
            num2 = sum;
        }
        return sum;
	}

}