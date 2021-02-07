using System;
using System.Collections.Generic;

namespace Data_Tree_Depth
{
    public class BranchService
    {
        public Branch NewBranch(int key)
        {
            Branch temp = new Branch();
            temp.key = (char)key;
            temp.branch = new List<Branch>();
            return temp;
        }
        public int DepthOfTree(Branch ptr)
        {
            if (ptr == null)
                return 0;

            int depth = 0;
            foreach (Branch it in ptr.branch)
                depth = Math.Max(depth, DepthOfTree(it));

            return depth + 1;
        }
    }
}
