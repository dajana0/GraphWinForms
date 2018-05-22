using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphWinForms.Helpers
{
    public class Prufer
    {
        public int[] encode(TNode tree)
        {
            int n = TNode.CountVertices(tree);
            if (n <= 2)
            {
                return null;
            }

            TNode treeToDecode = tree;

            int[] result = new int[n - 2];
            for (int x = 0; x < n - 2; x++)
            {
                TNode lowestNode = treeToDecode.FindLowestLeaf();
                TNode nearestNeighbor = lowestNode.Parent == null ? lowestNode.Children[0] : lowestNode.Parent;
                result[x] = (int)nearestNeighbor.label;

                if (nearestNeighbor.Parent == lowestNode)
                {
                    nearestNeighbor.Parent = null;
                }
                else
                {
                    nearestNeighbor.RemoveChild(lowestNode);
                }
                if (lowestNode.Parent != null)
                    lowestNode.Parent.RemoveChild(lowestNode);
                else if (lowestNode == treeToDecode)
                {
                    treeToDecode = treeToDecode.Children[0];
                }

            }
            return result;
        }



        public TNode decode(List<int> a)
        {
            List<int> b = new List<int>();
            for (int x = 1; x <= a.Count + 2; x++)
            {
                b.Add(x);
            }

            TNode root = new TNode(1);
            HashSet<TNode> reminidingNodes = new HashSet<TNode>();
            while (b.Count != 2)
            {
                int minb = b.Where(y => !a.Any(y2 => y2 == y)).Min();
                int firstA = a.First();

                TNode parent = null;
                TNode child = null;

                TNode node = root.FindChild(firstA);
                //sprawdzenie w root A
                if (node == null)
                {
                    node = root.FindChild(minb);
                }

                //sprawdzenie w root B
                if (node == null)
                {
                    node = FindNodeInList(reminidingNodes, minb);
                }
                //sprawdzenie czy istnieje w liscie min b 
                if (node == null)
                {
                    node = FindNodeInList(reminidingNodes, firstA);
                }
                //sprawdzenie czy istnieje w liście firstA
                if (node != null)
                {
                    parent = node;
                }


                //jeśli nie istnieje rodzic stwórz go
                if (parent == null)
                {
                    if (firstA < minb)
                    {
                        parent = new TNode(firstA);
                    }
                    else
                    {
                        parent = new TNode(minb);
                    }
                }
                //jeśli nie istnieje dziecko stwórz go
                int childLabel = 0;
                if (parent.label == firstA)
                {
                    childLabel = minb;
                }
                else
                {
                    childLabel = firstA;
                }
                child = root.FindChild(childLabel);
                if (child == null)
                {
                    child = FindNodeInList(reminidingNodes, childLabel);
                }
                if (child == null)
                {
                    child = new TNode(childLabel);
                }



                parent.AddChild(child);
                if (parent != root)
                    reminidingNodes.Add(parent);

                a.Remove(a.First());
                b.Remove(minb);
            }

            TNode childLast = null;
            TNode parentLast = root.FindChild(b[0]);
            if (parentLast == null)
            {
                parentLast = root.FindChild(b[1]);
            }

            childLast = root.FindChild(parentLast.label == b[0] ? b[1] : b[0]);
            if (childLast == null)
            {
                childLast = FindNodeInList(reminidingNodes, parentLast.label == b[0] ? b[1] : b[0]);
            }
            if (childLast == null)
            {
                childLast = new TNode(parentLast.label == b[0] ? b[1] : b[0]);
            }

            parentLast.AddChild(childLast);

            return root;
        }

        private TNode FindNodeInList(HashSet<TNode> list, int label)
        {
            TNode result;
            foreach (TNode node in list)
            {
                if (node.label == label)
                    return node;
                result = node.FindChild(label);
                if (result != null)
                    return result;
            }
            return null;
        }

    }
}