using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class BoxC
    {
        // 값을 안전하게 변경하기 위한 getter와 setter
        // 변수를 바로 변경할 수는 없지만 변수를 변경하는 메서드를
        // 만들고 메서드를 호출해 변경

        private int width; // 인스턴스 변수(필드)
        private int height;
        public int Area() // 인스턴스 메서드
        {
            return this.width * this.height;
        }
        public BoxC(int width, int height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이를 자연수로 초기화 해주세요.");
            }
        }

        // Getter
        public int GetWidth(int width) {  return width; }
        public int GetHeight(int height) {  return height; }

        // Setter
        public void SetWidth(int width)
        {
            if (width > 0) { this.width = width; }
            else { Console.WriteLine("너비와 높이를 자연수로 초기화 해주세요."); }
        }
        public void SetHeight(int height)
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("너비와 높이를 자연수로 초기화 해주세요."); }
        }
    }
}
