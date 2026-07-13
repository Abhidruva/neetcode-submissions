public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        HashSet<Tuple<int,int,int>> uniqueTriplets= new HashSet<Tuple<int,int,int>>();
        List<List<int>> res = new List<List<int>>();
        Array.Sort(nums);
        int n=nums.Length;

        for(int i=0;i<n;i++){
            for(int j=i+1;j<n;j++){
                for(int k=j+1;k<n;k++){
                    if (nums[i]+nums[j]+nums[k]==0){
                        var triplet = Tuple.Create(nums[i],nums[j],nums[k]);
                        uniqueTriplets.Add(triplet);
                    }
                }
            }
        }

        foreach( var triplet in uniqueTriplets){
            res.Add(new List<int>{triplet.Item1,triplet.Item2,triplet.Item3});
        }
        return res;
    }
}
