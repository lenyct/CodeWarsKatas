using Geneva;
using System;

public class Program
{
    
    public static void Main(string[] args)
    {

        //TreeNode leaf1 = new TreeNode(null, null);
        //TreeNode leaf2 = new TreeNode(null, null);
        //TreeNode leaf3 = new TreeNode(null, null);
        //TreeNode node2 = new TreeNode(leaf1, null);
        //TreeNode node3 = new TreeNode(leaf1, null);
        //TreeNode node = new TreeNode(node2, null);
        //TreeNode root = new TreeNode(node, leaf2);

        //Console.WriteLine(TreeHeight.CalculateHeight(root));
        //Console.ReadLine();

        //var d = new Dispatcher();

        //d.AcquireWorker(1).PerformTask("Task11");
        //d.AcquireWorker(2).PerformTask("Task21");

        //Console.WriteLine(string.Join(", ", d.AcquireWorker(2).Tasks));

        //d.ReleaseWorker(2);

        //d.AcquireWorker(1).PerformTask("Task12");


        //Console.WriteLine(string.Join(", ", d.AcquireWorker(1).Tasks));
        //d.ReleaseWorker(1);
        //Console.WriteLine(d.Workers);
        //Console.ReadLine();



        //public static void Main(string[] args)
        //{
        //Grasshopper g = new Grasshopper(5, 2);
        //Console.WriteLine(g.WhereAmI());

        //g.EatAndHopRight();
        //Console.WriteLine(g.WhereAmI());

        //g.EatAndHopLeft();
        //Console.WriteLine(g.WhereAmI());


        Grasshopper g = new Grasshopper(10, 6);
        Console.WriteLine(g.WhereAmI());

        g.EatAndHopRight();
        Console.WriteLine(g.WhereAmI());

        g.EatAndHopRight();
        Console.WriteLine(g.WhereAmI());

        g.EatAndHopLeft();
        Console.WriteLine(g.WhereAmI());

        //g.EatAndHopRight();
        //Console.WriteLine(g.WhereAmI());
        //    }
        //}
    }
}
