import java.util.ArrayList;
import java.util.List;

import javax.annotation.PostConstruct;


public class exe01 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
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
		
		int[] nums = {16,17,4,3,5,2};
		arrayReplaceWithGreatestFromRight(nums);
		for (int i = 0; i < nums.length; i++) {
			System.out.println(nums[i]);
		}
		
//		MyQueue queue = new MyQueue();
//		queue.push(1);
//		System.out.println(queue.pop());
//		queue.push(2);
//		queue.push(3);
//		System.out.println(queue.top());
//		System.out.println(queue.pop());
	}
	
	public class MyQueue {
		List<Integer> nums;
	    public MyQueue() {
	    	nums = new ArrayList<Integer>();
	    }

	    /*
	     * @param element: An integer 压入栈底
	     * @return: nothing
	     */
	    public void push(int element) {
	        // write your code here
	    	nums.add(element);
	    }

	    /*
	     * @return: An integer 删除队顶元素并返回
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
	     * @return: An integer 返回队顶元素
	     */
	    public int top() {
	        // write your code here
	    	if (nums.size() <= 0) {
				return -1;
			}
	    	return nums.get(0);
	    }
	}
	
//	给一整数数组, 用当前元素之后数组中的最大元素来替换当前元素(右侧的最大元素). 
//	因为最后一个元素的右边没有元素了, 所以用 -1 来替换这个值. 
//	举个例子, 如果数组为 [16,17,4,3,5,2], 那么它就需要修改为 [17,5,5,5,2,-1].
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
	
	
	
	//前序遍历和中序遍历树构造二叉树
	//preorder前序遍历
	//inorder中序遍历
	public static TreeNode buildTree(int[] preorder, int[] inorder) {
		TreeNode root = makeTree(preorder, 0,preorder.length, inorder, 0, inorder.length);
		return root;
    }
	public static TreeNode makeTree(int[] preorder,int startPre,int lenper,int[] inorder,int startIn,int lenIn) {
		if (lenper < 1) {
			return null;
		}
		TreeNode root;
		//找到这一组的跟节点，即前序遍历的第一个节点
		int rootVal = preorder[startPre];
		root = new TreeNode(rootVal);
		//遍历中序遍历，找到跟节点
		int offset;
		boolean isFound = false;
		//从当前中序遍历组的起始节点到它的长度
		for (offset = 0;offset < lenIn;offset ++) {
			if (inorder[offset + startIn] == rootVal) {
				isFound = true;
				break;
			}
		}
		if (!isFound) {
			return root;
		}
		//根据找到的offset值划分中序遍历数组
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
	
	//问题我没理解，但是在lincode平台通过了
//	假设一个旋转排序的数组其起始位置是未知的（比如0 1 2 4 5 6 7 可能变成是4 5 6 7 0 1 2）。
//	你需要找到其中最小的元素。
//	你可以假设数组中不存在重复的元素。
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
	//翻转链表
	//给出一个链表1->2->3->null，这个翻转后的链表为3->2->1->null
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
		//优化
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

	//计算在一个 32 位的整数的二进制表示中有多少个 1.
	public static int countOnes(int num) {
//		if (num < 0) {
//			num = -num;
//		}
//		int count = 0;
//		//假设num = 6，二进制为0110(8,4,2,1)
//        while(num != 0){
//        	//位与，如果num对应二进制的第0为为1，位与0x01的结果为1
//            count += num & 0x01;
//            //二进制右移动一位，一次后0110变成0011，即3
//            num = num >> 1;
//        }
//        return count;
		int count = 0;
        while(num!=0){
        	//num & (num-1);可以去掉num对应二进制最右边的1
            num = num & (num-1);
            count++;
        }
        return count;
    }
	
	//设计一种方法，将一个字符串中的所有空格替换成 %20 。你可以假设该字符串有足够的空间来加入新的字符，且你得到的是“真实的”字符长度。
	//你的程序还需要返回被替换后的字符串的长度。
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
	
//	查找斐波纳契数列中第 N 个数。
//	所谓的斐波纳契数列是指：
//	前2个数是 0 和 1 。
//	第 i 个数是第 i-1 个数和第i-2 个数的和。
//	斐波纳契数列的前10个数字是：
//	0, 1, 1, 2, 3, 5, 8, 13, 21, 34 ...
	public static int que01(int n) {
		if (n == 1) {
			return 0;
		}else if(n == 2) {
			return 1;
		}
		//递归，速度慢很多
//		return que01(n - 1) + que01(n - 2);
		//循环方式，核心思想是将前两个数一直保存下来，重复的变化
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
