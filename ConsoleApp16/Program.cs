using System.Collections;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region 1
            /*
            int n = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                numbers.Add(x);
            }

            for (int i = 0; i < q; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int count = 0;

                foreach (int num in numbers)
                {
                    if (num > x)
                        count++;
                }

                Console.WriteLine(count);
            }
            */
            #endregion
            #region 2
            /*
            int n= int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                numbers.Add(x);
            }
            bool isPalindrome = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (numbers[i] != numbers[n - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? "YES" : "NO");
            */
            #endregion
            #region 3
            /*
            static void ReverseQueue(Queue<int> queue)
            {
                Stack<int> stack = new Stack<int>();
                while (queue.Count > 0)
                    stack.Push(queue.Dequeue());

                while (stack.Count > 0)
                    queue.Enqueue(stack.Pop());
            }
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            ReverseQueue(queue);

            foreach (int item in queue)
                Console.Write(item + " ");
            */
            #endregion
            #region 4
            /*
            static bool IsBalanced(string str)
            {
                Stack<char> stack = new Stack<char>();
                foreach (char c in str)
                {
                    if (c == '(' || c == '{' || c == '[')
                        stack.Push(c);
                    else if (c == ')' || c == '}' || c == ']')
                    {
                        if (stack.Count == 0) return false;
                        char open = stack.Pop();
                        if (!((open == '(' && c == ')') || (open == '{' && c == '}') || (open == '[' && c == ']')))
                            return false;
                    }
                }
                return stack.Count == 0;
            }
            string input = Console.ReadLine();
            Console.WriteLine(IsBalanced(input) ? "Balanced" : "Not Balanced");
            */

            #endregion
            #region 5
            /*
            HashSet<int> set = new HashSet<int>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { 
            
            int x=int.Parse(Console.ReadLine());
                set.Add(x);
            
            }
            */

            #endregion
            #region 6
            /*
            static void RemoveOddNumbers(ArrayList list)
            {
                for (int i =0; i<list.Count; i++)
                {
                    int num = (int)list[i]; 
                    if (num % 2 != 0)       
                    {
                        list.RemoveAt(i);    
                    }
                }
            }
            */
            #endregion
            #region 7
            /*
            Queue<object> queue = new Queue<object>();

            queue.Enqueue(1);           
            queue.Enqueue("Apple");     
            queue.Enqueue(5.28);    
            */
            #endregion
            #region 8
            /*
            static void SearchTarget(Stack<int> stack, int target)
            {
                int count = 0;
                bool found = false;

                foreach (int item in stack)
                {
                    count++;
                    if (item == target)
                    {
                        found = true;
                        Console.WriteLine($"Target was found successfully and the count = {count}");
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Target was not found");
                }
            }
            Stack<int> stack = new Stack<int>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { 
            int x=int.Parse(Console.ReadLine());
                stack.Push(x);
            
            
            }
            int target = int.Parse(Console.ReadLine());

            SearchTarget(stack, target);
            */

            #endregion
            #region 9
            /*
            List<int> list = new List<int>();
            int n=int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                int x=int.Parse(Console.ReadLine());
                list.Add(x);


            }
            List<int> list1 = new List<int>();
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list1.Add(x);


            }
            List<int> list2 = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list1.Count; j++)
                {
                    if (list[i] == list1[j])
                    {
                        list2.Add(list[i]);
                        list.Remove(list[i]);
                        list1.Remove(list1[j]);
                        break;


                    }


                }
            }
            foreach(int x in list2)
                Console.WriteLine(x);
            */
            #endregion
            #region 10
            /*
            List<int> list = new List<int>([1,2,3,7,5]);
            List<int> list1 = new List<int>();
            int sum = 0;
            int t=int.Parse(Console.ReadLine());
            for (int i = 0; i < list.Count; i++) {
                sum += list[i];
                list1.Add(list[i]);
                for (int j = 0; j < list.Count; j++)
                {
                    if (sum > t)
                    {
                        sum -= list[i];
                        list1.RemoveAt(list[i]);
                    }

                    sum += list[j];
                    list1.Add(list[j]);
                    if (sum > t)
                    {
                        sum -= list[j];
                        list1.RemoveAt(list[j]);
                    }
                    if (sum==t)
                        break;


                }
                        }
            foreach(int i in list1) 
                Console.WriteLine(i);
            */
            #endregion
            #region 11
            /*
            Queue<int> queue = new Queue<int>([1,2,3,4,5]);
            Stack<int> stack = new Stack<int>();
            int k=int.Parse(Console.ReadLine());
            for(int i = 0; i < k; i++) 
            stack.Push(queue.Dequeue());

            foreach(int i in stack)
                Console.WriteLine(i);
            foreach(int i in queue)
                Console.WriteLine(i);
            */
            #endregion
        }
    }
}

