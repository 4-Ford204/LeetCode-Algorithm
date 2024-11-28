public class Solution {
    public string PredictPartyVictory(string senate) {
        int senatorNumber = senate.Length;
        Queue<int> rQueue = new Queue<int>();
        Queue<int> dQueue = new Queue<int>();

        for (int i = 0; i < senatorNumber; i++) {
            if (senate[i] == 'R') rQueue.Enqueue(i);
            else dQueue.Enqueue(i); 
        }

        while (rQueue.Count() > 0 && dQueue.Count() > 0) {
            var rIndex = rQueue.Dequeue();
            var dIndex = dQueue.Dequeue();

            if (rIndex < dIndex) rQueue.Enqueue(rIndex + senatorNumber);
            else dQueue.Enqueue(dIndex + senatorNumber);
        }

        return rQueue.Count() > 0 ? "Radiant" : "Dire";
    }
}