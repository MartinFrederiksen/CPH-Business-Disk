using System;
using System.Collections.Generic;

namespace Week4.Sorting
{
    public class TrieSort : ISort<string>
    {
        public Node root = null;
        private string[] unsorted;
        private List<string> sorted = new List<string>();

        public TrieSort(string[] arr)
        {
            this.unsorted = arr;
        }

        public string[] sort() {
            for(int i = 0; i < unsorted.Length; i++) {
                insert(unsorted[i], i);
            }
            print(root);
            return sorted.ToArray();
        }

        public void insert(string word, int index) {
            if(root == null)
                root = new Node();

            Node current = root;

            for(int i = 0; i < word.Length; i++) {
                char c = word[i];

                if(current.getChild(c) == null)
                    current.addChild(c);

                current = current.getChild(c);
            }

            current.addIndex(index);
        }
        
        private void print(Node node) {
            if(node == null)
                return;

            if(node.getIndices().Count > 0)
                foreach(int index in node.getIndices())
                    sorted.Add(unsorted[index]);

            for(char index = 'a'; index <= 'z'; index++)
                print(node.getChild(index));
        }

        public class Node {
            Dictionary<char, Node> children;
            List<int> indices;

            public Node() {
                children = new Dictionary<char, Node>();
                indices = new List<int>();
            }

            public Node getChild(char c) {
                return children.ContainsKey(c) ? children[c] : null;
            }

            public Node addChild(char c) {
                return children[c] = new Node();
            }

            public List<int> getIndices() 
            {
                return indices;
            }
    
            public void addIndex(int index)
            {
                indices.Add(index);
            }
        }
    }
}