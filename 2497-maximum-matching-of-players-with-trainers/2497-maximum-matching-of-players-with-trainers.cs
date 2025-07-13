public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
        Array.Sort(players);
        Array.Sort(trainers);
        int i = 0, j = 0;

        for (; i < players.Length && j < trainers.Length; j++) {
            if (players[i] <= trainers[j]) i++;
        }

        return i;
    }
}