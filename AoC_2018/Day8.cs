using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /*
    */
    public class Day8 : Day
    {
        public override string Title => "2018 - Day 8";

        public override void PartOne()
        {
            base.PartOne();
            //var input = "".SplitAsIntsBy();//Inputs.Day8.SplitAsIntsBy();
            //var allNodes = new List<Node>();
            var input = "2 3 0 3 10 11 12 1 1 0 1 99 2 1 1 2".SplitAsIntsBy();
            /*
             *  2 3 0 3 10 11 12 1 1 0 1 99 2 1 1 2
                A----------------------------------
                    B----------- C-----------
                                     D-----
                In this example, each node of the tree is also marked with an underline starting with a letter for easier identification. In it, there are four nodes:

                A, which has 2 child nodes (B, C) and 3 metadata entries (1, 1, 2).
                B, which has 0 child nodes and 3 metadata entries (10, 11, 12).
                C, which has 1 child node (D) and 1 metadata entry (2).
                D, which has 0 child nodes and 1 metadata entry (99).
             */

            //OldMethod(input, allNodes);
            //Console.WriteLine(allNodes.SelectMany(s => s.Metadata).Sum());

            var index = 0;
            var mainNode = FindNodes(input, ref index);
            Console.WriteLine(mainNode.SumMetadata);
        }

        private Node FindNodes(List<int> input, ref int index)
        {
            Node node = new Node();
            int startIndex = index;

            node.Header.NumberOfNodes = input[startIndex];
            node.Header.NumberOfMetadata = input[startIndex+1];

            index += 2;
            if (node.Header.NumberOfNodes > 0)
            {
                for (int i = 0; i < node.Header.NumberOfNodes; i++)
                {
                    node.SubNodes.Add(FindNodes(input, ref index));
                }
            }

            if (node.Header.NumberOfMetadata > 0)
            {
                for (int i = 0; i < node.Header.NumberOfMetadata; i++)
                {
                    node.Metadata.Add(input[index]);
                    index++;
                }
            }

            return node;
        }

        private static void OldMethod(List<int> input, List<Node> allNodes)
        {
            for (int i = input.Count - 1; i >= 0; i--)
            {
                var currentHeaderIndex = new { Nodes = i - 1, Metadata = i };

                if (currentHeaderIndex.Nodes < 0 || currentHeaderIndex.Metadata > input.Count)
                {
                    continue;
                }

                var currentHeader = new Header { NumberOfNodes = input[currentHeaderIndex.Nodes], NumberOfMetadata = input[currentHeaderIndex.Metadata] };
                //var subListCount = input.Count - currentPairIndex.Metadata;
                var nodes = new List<Node>();
                var metadata = new List<int>();

                for (int j = currentHeaderIndex.Metadata + 1; j < input.Count; j++)
                {
                    var node = allNodes.FirstOrDefault(f => f.NodeIndex == j);
                    if (node != null)
                    {
                        nodes.Add(node);
                        j = node.LastIndex;
                    }
                    else
                    {
                        if (allNodes.Any(a => a.MetaIndex == j))
                        {
                        }
                        else
                        {
                            metadata.Add(input[j]);
                        }
                    }

                    if (currentHeader.NumberOfNodes == nodes.Count && currentHeader.NumberOfMetadata == metadata.Count)
                    {
                        allNodes.Add(new Node
                        {
                            NodeIndex = currentHeaderIndex.Nodes,
                            Header = currentHeader,
                            LastIndex = j,
                            SubNodes = nodes,
                            Metadata = metadata
                        });

                        i = currentHeaderIndex.Nodes;
                        break;
                    }
                }
            }
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine();
        }
    }

    public class Node
    {
        public int NodeIndex;
        public int MetaIndex => NodeIndex + 1;
        public Header Header;
        public List<int> Metadata = new List<int>();
        public List<Node> SubNodes = new List<Node>();
        public int SumMetadata => Metadata.Sum() + SubNodes.Sum(s => s.SumMetadata);
        public int LastIndex;
    }

    public class Header
    {
        public int NumberOfNodes;
        public int NumberOfMetadata;
    }
}
