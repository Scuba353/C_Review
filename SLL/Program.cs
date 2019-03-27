using System;

namespace SLL
{
    class Program
    {
    
    public class Node
    {
        //reference for next pointer
        public Node next;
        //reerecen for the node val- which is an object
        public Object val;

        public Node(Object createNode){
            this.next=null;
            this.val= createNode;
        }
    }

    public class SLList
    {
        //reference to the begining of the list
        private Node head;

        //all SSList functions follow here- they are functions of the list data structure not the individual nodes
        
        //Count all nodes in a list
        public int countNodes(){
            if(head == null){
                return 0;
            }
            else{
                Node curr= head;
                int count= 0;
                while(curr != null){
                    curr= curr.next;
                    count ++;
                }
                return count;
            }
        }

        //print all node and their next pointers in a SLL
        public void PrintNodes(){
            if(head == null){
                Console.WriteLine("This list is empty. There are no nodes.");
            }
            else{
                Node curr= head;
                while(curr != null){
                    Console.WriteLine("This node holds a val of " + curr.val + " and a next pointing to "+ curr.next);
                    curr = curr.next;
                }
            }
        }

        //Add a Node to the end of the SLL- Create new node, traverse, add new node to end
        public void addToEnd(Object newObject){
            Node newAdd = new Node(newObject);

            if(head == null){
                head= newAdd;
            }
            else{
                Node curr= head;
                while(curr.next !=null){
                    curr = curr.next;
                }
                curr.next= newAdd;
            }
        }

        //Add a Node to the end of the SLL- Create new node, traverse to int position, add after that position 
        public void addAnywhere(Object newObject, int position){
            Node newAdd = new Node(newObject);

            if(head == null){
                head= newAdd;
            }
            else{
                Node curr= head;
                int count= 0;
                if(count < position){
                    curr = curr.next; 
                    count ++;
                    Console.WriteLine (count);
                }
                newAdd.next = curr.next;
                curr.next = newAdd; 
            }
        }

        //Return Last Node
        public Node returnEnd(){

            if(head == null){
                return null;
            }
            else{
                Node curr= head;
                while(curr.next != null){
                    curr = curr.next;
                }
                return curr;
            }
        }

        //Remove End Node
        public Node removeEnd(){

            if(head == null){
                return null;
            }
            else{
                Node curr= head;
                Node temp= head;
                while(curr.next != null){
                    temp= curr;
                    curr = curr.next;
                }
                temp.next= null;
                return curr;
            }
        }




    }//end of SLL class









        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SLList myList = new SLList();

            myList.addToEnd("Hello");
            myList.addToEnd("Magical");
            myList.addToEnd("World");
            //myList.PrintNodes();
            //Console.WriteLine(myList.countNodes());
            //myList.addAnywhere("A new string", 2);
            //myList.PrintNodes();
            //Console.WriteLine(myList.countNodes());
            Console.WriteLine(myList.returnEnd());
            Console.WriteLine(myList.removeEnd());








        }
    }
}

