public class Solution {
    private const int kMaxScore = int.MaxValue;
    private const int kStartCity = 1;
    private const int kFrom = 0;
    private const int kTo = 1;
    private const int kDist = 2;

    private class Dsu {
        private int[] mParent;
        private int[] mMinScore;

        public Dsu(int size_) {
            mParent = new int[size_ + 1];
            mMinScore = new int[size_ + 1];
            for (int i = 0; i <= size_; i++) {
                mParent[i] = i;
                mMinScore[i] = kMaxScore;
            }
        }

        public int Find(int city_) {
            if (mParent[city_] == city_) {
                return city_;
            }
            mParent[city_] = Find(mParent[city_]);
            return mParent[city_];
        }

        public void Unite(int cityU_, int cityV_, int dist_) {
            int rootU = Find(cityU_);
            int rootV = Find(cityV_);

            int newMinScore = Math.Min(Math.Min(mMinScore[rootU], mMinScore[rootV]), dist_);

            if (rootU != rootV) {
                mParent[rootV] = rootU;
            }
            
            mMinScore[rootU] = newMinScore;
        }

        public int GetMinScore(int city_) {
            return mMinScore[Find(city_)];
        }
    }

    public int MinScore(int cityTot_, int[][] roads_) {
        Dsu dsu = new Dsu(cityTot_);
        
        foreach (var road_ in roads_) {
            dsu.Unite(road_[kFrom], road_[kTo], road_[kDist]);
        }
        
        return dsu.GetMinScore(kStartCity);
    }
}