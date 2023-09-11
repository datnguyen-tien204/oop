using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Stack
    {
        private int top;
        public int[] arr;
        public Stack() 
        {
            this.top = -1;
            arr=new int[20];
        }
        public Stack(int size)
        {
            arr = new int[size] ;

            top = -1;
              
        }
        public Boolean CheckEmpty()
        {
            if (top==-1)
            {
                return true;
            }    
            else
                return false;
        }
        public Boolean CheckFull()
        {
            if (top == arr.Length - 1)
                return true;
            else
                return false;
        }

        public void Push(int values)
        {
            
            if(CheckFull()==true)
            {
                Console.WriteLine("Stack full. Khong the them vao");
                
            }    
            else
            {

                //top += 1;
                arr[++top] = values;
              

            }    
        }
        public void Pop()
        {
            if(CheckEmpty()==true) 
            {
                Console.WriteLine("Khong the POP do stack rong");
            }
            else
            { 
                
                arr[top]=top--; 
               
            }
        }
        public void ShowStack()
        {
            for(int i=0;i<arr.Length;i++) 
            {
                Console.Write(arr[i]+",");
            }
        }
    }
}
