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

        //return head value
        public void returnFirst(){
            if(head == null){
                Console.WriteLine("This list is empty. There are no nodes.");
            }
            else{
                Node curr= head;
                Console.WriteLine("The first node has a val of " + curr.val);
            }
        }

        //Add a Node to the end of the SLL
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

        //Add node to front of list
        public void addFront(Object newObject){
            Node newAdd = new Node(newObject);

            if(head == null){
                head= newAdd;
            }
            else{
                Node curr= head;
                head = newAdd;
                newAdd.next=curr;
            }
        }

        //Add a Node after a given position in list
        public void addAfterPosition(Object newObject, int position){
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

        //remove first node
        public Node removeFront(){
            if(head == null){
                return null;
            }
            else{
                Node temp= head;
                Node curr= head;
                head=curr.next;
                temp.next= null;
                return temp;
            }
        }

        //SLL contains a given value
        public bool Contains(object value){
            if(head == null){
                return false;
            }
            else{
                Node curr= head;
                while(curr != null){
                    if(curr.val == value){
                        return true;
                    }
                    else{
                       curr= curr.next; 
                    }   
                }
                return false;
            }
        }

        //SLL find Max
        public Node Max(){
            if(head == null){
                return null;
            }
            else{
                Node curr= head;
                Node max=head;
                // int maxval=(int)curr.val;
                while(curr != null){
                    if((int)curr.val > (int)max.val){
                        max=curr;
                    }
                    else{
                       curr= curr.next; 
                    }   
                }
                Console.WriteLine("max node val"+ max.val);
                return max;
            }
        }

        //SLL find Min
        public Node Min(){
            if(head == null){
                return null;
            }
            else{
                Node curr= head;
                Node min=head;
                // int maxval=(int)curr.val;
                while(curr != null){
                    if((int)curr.val < (int)min.val){
                        min=curr;
                    }
                    else{
                       curr= curr.next; 
                    }   
                }
                Console.WriteLine("min node val"+ min.val);
                return min;
            }
        }

        //SLL find Min
        public int Average(){
            if(head == null){
                return 0;
            }
            else{
                Node curr= head;
                int average= 0;
                int count= 0; 
                // int maxval=(int)curr.val;
                while(curr != null){
                    average += (int)curr.val;
                    count++;
                    curr= curr.next; 
                } 
                Console.WriteLine("avg node val"+ average/count);
                return average/count;  
            }

        }
        




    }//end of SLL class









        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // SLList myList = new SLList();

            // myList.addToEnd("Hello");
            // myList.addToEnd("Magical");
            // myList.addToEnd("World");
            // myList.PrintNodes();
            // Console.WriteLine("*************************************");
            // Console.WriteLine(myList.Contains("Hello"));
            // Console.WriteLine(myList.Contains("unicorn"));
            // Console.WriteLine(myList.Contains("World"));
            //myList.returnFirst();
            //myList.addFront("A new string");
            //myList.PrintNodes();
            //Console.WriteLine("*************************************");
            //Console.WriteLine(myList.removeFront());
            //myList.PrintNodes();
            //Console.WriteLine(myList.countNodes());
            //myList.addAfterPosition("A new string", 2);
            //myList.PrintNodes();
            //Console.WriteLine(myList.countNodes());
            //Console.WriteLine(myList.returnEnd());
            //Console.WriteLine(myList.removeEnd());

            SLList myList2 = new SLList();

            myList2.addToEnd(100);
            myList2.addToEnd(30);
            myList2.addToEnd(4);
            myList2.PrintNodes();
            Console.WriteLine("*************************************");
            Console.WriteLine(myList2.Max());
            Console.WriteLine(myList2.Min());
            Console.WriteLine(myList2.Average());






        }
    }
}

