public class LRUCache {

	private class Node
	{
    	public int Key;
    	public int Value;
		public Node Previous;
		public Node Next;
	
    	public Node(int key,int val)
    	{
       		Value = val;
			Key = key;
		}
	}
	
	private Dictionary<int, Node> map;
	private Node head;
	private Node tail;
	private int capacity;
	
	public LRUCache(int capacity){
		
		if(capacity <= 0) throw new ArgumentException("Capacity must be greater than zero.");
		
		this.capacity = capacity;
		map = new Dictionary<int, Node>();
		
		head = new Node(0,0);
		tail = new Node(0,0);
		
		head.Next = tail;
		tail.Previous = head;
	}
	
	public int Get(int key){
		if(!map.ContainsKey(key)) return -1;
		
		var node = map[key];
		
		Remove(node);
		AddToFront(node);
		
		return node.Value;

	}
	
	public void Put(int key, int value){
		if(map.ContainsKey(key)){
			Node node = map[key];
			
			node.Value = value;
			Remove(node);
			AddToFront(node);
			return;
		}else{
			if(capacity == map.Count){
				
				Node lru = RemoveTail();
				map.Remove(lru.Key);
				
			}
			
			Node node = new Node(key, value);	
			map.Add(key,node);
			AddToFront(node);
			
		}
	}
	
	private void AddToFront(Node node)
	{
		Node headNext = head.Next;

		head.Next = node;
		node.Previous = head;

		node.Next = headNext;
		headNext.Previous = node;
	}
	
	private void Remove(Node node){		
		node.Next.Previous = node.Previous;
		node.Previous.Next = node.Next;
		node.Previous = null;
		node.Next = null;
	}
	
	private Node RemoveTail(){
		Node lru = tail.Previous;
		Remove(lru);
		return lru;
	}
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */