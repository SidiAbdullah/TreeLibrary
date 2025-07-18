using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class TreeNode<T>
{
    public T value { get; set; }
    public List<TreeNode<T>> childrens { get; set; }
    public TreeNode(T value)
    {
        this.value = value;
        childrens = new List<TreeNode<T>>();
    }
    public void addChild(TreeNode<T> node)
    {
        childrens.Add(node);
    }
}
public class Tree<T>
{
    public TreeNode<T> root { get; private set; }
    public Tree(T rootValue)
    {
        root = new TreeNode<T>(rootValue);
    }
    public void printTree(TreeNode<T> root, string indent = "-")
    {
        Console.WriteLine(indent + root.value);
        foreach (var child in root.childrens)
        {
            printTree(child, "   " + indent);
        }
    }
}

class Program
{
    static void Main()
    {
        var tree = new Tree<string>("algebra");
        var polynomes = new TreeNode<string>("polynomes");
        var inequalties = new TreeNode<string>("inequalties");
        var fonctional_equations = new TreeNode<string>("fonctional_equations");
        tree.root.addChild(polynomes);
        tree.root.addChild(inequalties);
        tree.root.addChild(fonctional_equations);

        // polynomes childs
        var degree1 = new TreeNode<string>("firstDegreePolynome");
        var degree2 = new TreeNode<string>("SecondDegreePolynome");
        var degree3 = new TreeNode<string>("ThirdDegreePolynome");
        polynomes.addChild(degree1);
        polynomes.addChild(degree2);
        polynomes.addChild(degree3);
        // inequalties childs
        var AM_GM = new TreeNode<string>("AM_GM_inequality");
        inequalties.addChild(AM_GM);

        tree.printTree(tree.root);
    }
}