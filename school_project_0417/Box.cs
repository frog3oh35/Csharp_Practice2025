﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_project_0417
{
    internal class Box
    {
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else
                {
                    Console.WriteLine("높이는 자연수를 입력해주세요.");
                }
            }
        }

        public Box (int width, int height)
        {
            Width = width;
            Height = height;
        }

        //인스턴스 메서드
        public int Area() { return this.width * this.Height; }

    }
}
