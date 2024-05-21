using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class BoxE
    {
        // 간단한 속성 생성 방법
        private int width; // 인스턴스 변수(필드)
        public int Width // 속성 (구분을 위해 대문자로 시작)
        {
            get; // 추출
            set; // 저장
        }

        private int height; // 인스턴스 변수(필드)
        public int Height // 속성
        {
            get; // 추출
            set; // 저장
        }

        public int Area() // 인스턴스 메서드
        {
            // return this.width * this.height; // this <- 자기자신을 의미
            return Width * Height;
        }

        public BoxE(int width, int height) // 생성자
        {
            if(width > 0 && height > 0)
            {
                Width = width;
                Height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 해주세요");
            }
        }
    }
}
