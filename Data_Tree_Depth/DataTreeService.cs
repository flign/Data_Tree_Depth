using System;

namespace Data_Tree_Depth
{
    public class DataTreeService
    {
        private readonly BranchService branchService = new BranchService();
        public Branch CreateDataTree()
        {
            /* Creating tree below:
            *              A 
            *           /     \   
            *          B       C
            *         /      / | \ 
            *        D      E  F  G
            *              /  / \
            *             H  I   J
            *                |
            *                K
            */
            Branch tree = branchService.NewBranch('A');
            tree.branch.Add(branchService.NewBranch('B'));
            tree.branch.Add(branchService.NewBranch('C'));
            tree.branch[0].branch.Add(branchService.NewBranch('D'));
            tree.branch[1].branch.Add(branchService.NewBranch('E'));
            tree.branch[1].branch.Add(branchService.NewBranch('F'));
            tree.branch[1].branch.Add(branchService.NewBranch('G'));
            tree.branch[1].branch[0].branch.Add(branchService.NewBranch('H'));
            tree.branch[1].branch[1].branch.Add(branchService.NewBranch('I'));
            tree.branch[1].branch[1].branch.Add(branchService.NewBranch('J'));
            tree.branch[1].branch[1].branch[0].branch.Add(branchService.NewBranch('K'));
            return tree;
        }
        public void PrintDepth(Branch tree)
        {
            Console.Write("Giliausias lygmuo: " + branchService.DepthOfTree(tree) + "\n");
        }
    }
}
