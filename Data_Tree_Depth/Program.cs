using System;

namespace Data_Tree_Depth
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTreeService dataTreeService = new DataTreeService();

            dataTreeService.PrintDepth(dataTreeService.CreateDataTree());
            Console.ReadKey();
        }
    }
}
