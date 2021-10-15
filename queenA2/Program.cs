using System;
using System.Collections.Generic;

namespace queenA2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int r_q = 5;
            int c_q = 3;
            int k = 2;
            List<int> ob1 = new List<int>();
            ob1.Add(5);
            ob1.Add(5);
            List<int> ob2 = new List<int>();
            ob2.Add(4);
            ob2.Add(2);
            List<int> ob3 = new List<int>();
            ob3.Add(2);
            ob3.Add(3);
            /*List<int> ob4 = new List<int>();
            ob4.Add(5);
            ob4.Add(3);
            List<int> ob5 = new List<int>();
            ob5.Add(5);
            ob5.Add(4);
            List<int> ob6 = new List<int>();
            ob6.Add(4);
            ob6.Add(2);
            List<int> ob7 = new List<int>();
            ob7.Add(5);
            ob7.Add(3);
            List<int> ob8 = new List<int>();
            ob8.Add(5);
            ob8.Add(4);*/

            List<List<int>> obstacles = new List<List<int>>();
            obstacles.Add(ob1);
            obstacles.Add(ob2);
            obstacles.Add(ob3);
            /*obTotal.Add(ob4);
            obTotal.Add(ob5);
            obTotal.Add(ob6);
            obTotal.Add(ob7);
            obTotal.Add(ob8);*/


            int up = (n - r_q);
     
            int left = (c_q - 1);
   
            int right = n - c_q;


            int down = r_q - 1;
  
            int up_right = Math.Min(up, right);
    
            int down_right = Math.Min(right, down);
   
            int up_left = Math.Min(left, up);
    
            int down_left = Math.Min(left, down);
   


            int obLine = 0;

            foreach (List<int> item in obstacles)
            {
                if (item[0] < r_q)
                {
                    //down-left
                    if (r_q - item[0] == c_q - item[0])
                    {
                        obLine = c_q - item[1]-1;
                        if(down_left>obLine)
                        down_left = obLine;//1-1 = 0;
                    }
                    //down
                    if (item[1] == c_q)
                    {
                        obLine = r_q - item[0]-1;
                        if(down>obLine)
                        down = obLine;
                    }
                    //down-right
                    if (r_q - item[0] == item[1] - c_q)
                    {
                        obLine = item[1] - c_q-1;
                        if(down_right>obLine)
                        down_right = obLine;
                    }

                }
                //left
                if (item[1] < c_q && item[0] == r_q)
                {
                    obLine = c_q-item[1]-1;
                    if(left>obLine)
                    left = obLine;  //2-1=1
                }

                //right
                if (item[1] > c_q && item[0] == r_q)
                {
                    obLine = item[1]-c_q-1;//4 - 4 +1= 0
                    if(right>obLine)
                    right = obLine;//1-1=0
                }
                //up-side
                if (item[0] > r_q)//3 d, item[0]= 3
                {
                    //1-up-left 
                    if (item[0] - r_q == c_q - item[1])//item[1]=2, 
                    {
                        obLine = c_q-item[1] - 1;
                        if(up_left>obLine)
                        up_left = obLine;
                    }
                    //up
                    if (item[1] == c_q )
                    {
                        obLine = item[0]-r_q -1 ;//4-4+1 = 1
                        if(up>obLine)
                        up = obLine;//2-1=1
                    }

                    //up-right
                    if (item[0] - r_q == item[1] - c_q)
                    {
                        //4-3=1
                        obLine = item[0]-r_q-1;
                        if(up_right>obLine)
                        up_right = obLine;//1-1 = 0
                    }

                }
                /*if (item[0] > r_q)//3 d, item[0]= 3
                {
                    //1-up-left 
                    if (item[0]-r_q==c_q-item[1])//item[1]=2, 
                    {
                        obLine = item[0]-r_q;
                        if (up_left > obLine)
                        {
                            up_left = obLine-1;
                        }

                    }
                    //up
                    if (item[1] == c_q)
                    {
                        obLine = item[0]-r_q;//5-5+1 = 1
                        if (up > obLine)
                        {
                            up = obLine-1;//2-1=1    
                        }
                    }

                    //up-right
                    if (item[0]-r_q==item[1] - c_q)
                    {
                        //4-3=1
                        obLine = item[0]-r_q;
                        if (up_right < obLine)
                        {
                            up_right = obLine-1;//1-1 = 0

                        }
                    }

                }

                //left
                
                //right
                if (item[1] > c_q && item[0] == r_q)
                {
                    //obLine = 
                    //issue: the isssu we have is, the obstacle check will always be the last one,
                    //but if there are two ob in a same dirction,
                    //it will mess up the final result
                    obLine = item[1] - c_q ;
                    if (right > obLine)
                    {
                        right = obLine-1;
                    }
                }

                //down
                if (item[0] < c_q)
                {
                    //down-right
                    if (r_q - item[0] == item[1] - c_q)
                    {
                        obLine = r_q - item[0];
                        if (down_right > obLine)
                        {
                            down_right = obLine - 1;
                        }
                    }
                    //down
                    if (item[1] == c_q)
                    {
                        obLine = r_q - item[0];
                        if (down > obLine)
                        {
                            down = obLine - 1;
                        }
                    }
                    //down-left
                    if (r_q-item[0]==c_q-item[0])
                    {
                        obLine = r_q - item[0];
                        if (down_left > obLine)
                        {
                            down_left = obLine-1;
                        }
                    }
                    
                    
                }
                if (item[1] < c_q && item[0] == r_q)
                {
                    obLine = c_q - item[1];
                    if (left > obLine)
                    {
                        left = obLine - 1;
                    }
                }*/

                /*if (item[1] == c_q)
                {
                    //down
                    if (item[0] < r_q)
                    {
                        if (down > Math.Min(oldDown, r_q - 1 - item[0]))
                        {
                            down = Math.Min(oldDown, r_q - 1 - item[0]);
                        }
                    }

                    else

                    {
                        if (up > Math.Min(oldUp, item[0] - r_q - 1))
                        {
                            up = Math.Min(oldUp, item[0] - r_q - 1);
                        }
                    }

                }

                else if (item[0] == r_q)
                {
                    if (item[1] < c_q)
                    {
                        if (left > Math.Min(oldLeft, c_q - 1 - item[1]))
                        {

                            left = Math.Min(oldLeft, c_q - 1 - item[1]);
                        }
                    }

                    else
                    {
                        if (right > Math.Min(oldRight, item[1] - c_q - 1))
                        {
                            right = Math.Min(oldRight, item[1] - c_q - 1);

                        }
                    }
                }
                else if (Math.Abs(item[0] - r_q) == Math.Abs(item[1] - c_q))
                {
                    if (item[1] > c_q)
                    {
                        if (item[0] > r_q)
                        {
                            if (up_right > Math.Min(oldUp_right, item[1] - c_q - 1))
                            {
                                up_right = Math.Min(oldUp_right, item[1] - c_q - 1);

                            }
                        }

                        else
                        {
                            if (down_right > Math.Min(oldDown_right, item[1] - c_q - 1))
                                down_right = Math.Min(oldDown_right, item[1] - c_q - 1);
                        }
                    }
                }

                else if (item[0] > r_q && item[1]<c_q)
                {
                    if (up_left > Math.Min(oldUp_left, c_q - 1 - item[1]))
                    {
                        up_left = Math.Min(oldUp_left, c_q - 1 - item[1]);

                    }

                }

                else if(item[0]<r_q && item[1]<c_q)
                {
                    if (down_left > Math.Min(oldDown_left, c_q - 1 - item[1]))
                    {

                        down_left = Math.Min(oldDown_left, c_q - 1 - item[1]);
                    }
                }*/
                Console.WriteLine(up_left + " " + up + " " + up_right + " " + left + " " + right + " " + down_left + " " + down + " " + down_right);
            }
            /*foreach(List<int> item in obTotal)
            {
                Console.WriteLine("here");
                if (item[0] > r_q)//3 d, item[0]= 3
                {
                    //1-up-left 
                    if (item[1] < c_q)//item[1]=2, 
                    {
                        obLine = n - item[0] + 1; 
                        if(up_left< up_left - obLine)
                        {
                            up_left = up_left - obLine;
                        }

                    }
                    //up
                    if (item[1] == c_q)
                    {
                        obLine = n - item[0] + 1;//5-5+1 = 1
                        if(up < up - obLine)
                        {
                            up = up - obLine;//2-1=1    
                        }
                    }

                    //up-right
                    if (item[1] > c_q)
                    {
                        //4-3=1
                        obLine = n - item[0];
                        if(up_right < up_right - obLine)
                        {
                            up_right = up_right - obLine;//1-1 = 0

                        }
                    }

                }

                //left
                if (item[1] < c_q && item[0]==r_q)
                {
                    //obLine = c_q-item[0];
                    if(left < left - item[1])
                    {
                        left = left - item[1];
                    }
                }

                //right
                if (item[1] > c_q && item[0]==r_q)
                {
                    //obLine = 
                    //issue: the isssu we have is, the obstacle check will always be the last one,
                    //but if there are two ob in a same dirction,
                    //it will mess up the final result
                    obLine = item[1] - c_q - 1;
                    if (right < obLine)
                    {

                    }
                    right = Math.Abs(right - item[1]);
                }

                //down
                if (item[0]< c_q)
                {
                    //down-left
                    if (item[1] < c_q)
                    {
                        down_left = down_left - item[0];//1-1 = 0;
                    }
                    //down
                    if (item[1] == c_q)
                    {
                        Console.WriteLine(item[0]);
                        down = down - item[0];
                    }
                    //down-right
                    if (item[1] > c_q)
                    {
                        obLine = item[1] - c_q-1;
                        Console.WriteLine(obLine);
                        down_right = down_right - obLine;//1
                        //down_right = Math.Min(down_right, item[0] - c_q - item[0]);
                    }

                }
                Console.WriteLine(up_left + " " + up + " " + up_right + " " + left + " " + right + " " + down_left + " " + down + " " + down_right);
            }*/






            int total = up_left + up + up_right + left + right + down_left + down + down_right;


            //total = 8

            Console.WriteLine(total);

        }
    }
}
