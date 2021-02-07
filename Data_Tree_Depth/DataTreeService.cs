using System;

namespace Data_Tree_Depth
{
    public class DataTreeService
    {
        private readonly BranchService nodeService = new BranchService();
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
            Branch tree = nodeService.NewBranch('A');
            tree.branch.Add(nodeService.NewBranch('B'));
            tree.branch.Add(nodeService.NewBranch('C'));
            tree.branch[0].branch.Add(nodeService.NewBranch('D'));
            tree.branch[1].branch.Add(nodeService.NewBranch('E'));
            tree.branch[1].branch.Add(nodeService.NewBranch('F'));
            tree.branch[1].branch.Add(nodeService.NewBranch('G'));
            tree.branch[1].branch[0].branch.Add(nodeService.NewBranch('H'));
            tree.branch[1].branch[1].branch.Add(nodeService.NewBranch('I'));
            tree.branch[1].branch[1].branch.Add(nodeService.NewBranch('J'));
            tree.branch[1].branch[1].branch[0].branch.Add(nodeService.NewBranch('K'));
            return tree;
        }
        public void PrintDepth(Branch tree)
        {
            Console.Write("Giliausias lygmuo: " + nodeService.DepthOfTree(tree) + "\n");
        }
    }
}
