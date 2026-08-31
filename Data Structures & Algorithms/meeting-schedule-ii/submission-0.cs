/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
		PriorityQueue<int, int> rooms = new PriorityQueue<int, int>();
		int maxRooms = 0;
		
		intervals.Sort((a ,b) => a.start.CompareTo(b.start));
		
		
		for(var i = 0; i < intervals.Count; i++){
			
			if(rooms.TryPeek(out _, out int endEarliest) && endEarliest <= intervals[i].start){
					rooms.Dequeue();
			}
			rooms.Enqueue(intervals[i].end, intervals[i].end);
			maxRooms = Math.Max(maxRooms, rooms.Count);
			
		}
		
		return maxRooms;
    }
}
