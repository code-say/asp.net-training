﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyStack : ICloneable
    {
        private int[] a;
        private int top;
        private int size;
        //intialization through constructor
        public MyStack(int si)
        {
            a = new int[si];
            top = -1;
            size = si;
        }
        //it is for clone method
        public MyStack(int[] a, int k)
        {
            this.a = a;
            this.top = k;

        }
        //push operation means pushing the value to the stack[LIFO]
        public void push(int item)
        {
            if (top == (size - 1))//If this condition meet then will throw custom  stackexception with message StackOverflow
            {

                throw new StackException("Stack Overflow");

            }
            else
            {
                a[++top] = item;
            }
        }
        //Removing operation means popping the value from the stack[LIFO]
        public int pop()
        {
            if (top == -1)//If this condition meet then will throw custom  stackexception with message Stackunderflow
            {
                throw new StackException("Stack Underflow");
            }
            else
            {
                Console.WriteLine("Poped item: " + a[top]);
                int i = top--;
                return a[i];
            }
        }
        //Printing the every element of the stack
        public void print()
        {
            if (top == -1)
            {
                Console.WriteLine("Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item " + (i + 1) + ":" + a[i]);
                }
            }
        }

        //implementing interface operation [clone]
        //implementing interface operation [clone]
        public object Clone()
        {

            return new MyStack(a, top);

        }
    }
}
