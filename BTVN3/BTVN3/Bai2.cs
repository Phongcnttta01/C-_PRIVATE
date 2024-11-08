namespace BTVN3;

public class Bai2
{
    public string s;

    public Bai2(string s)
    {
        this.s = s;
    }

    public bool IsValidBrackets(string s)
    {
        // Khởi tạo ngăn xếp
        Stack<char> stack = new Stack<char>();

        // Duyệt từng ký tự trong chuỗi
        foreach (char c in s)
        {
            // Nếu ký tự là dấu ngoặc mở, thêm vào ngăn xếp
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            // Nếu ký tự là dấu ngoặc đóng
            else if (c == ')' || c == ']' || c == '}')
            {
                // Kiểm tra xem ngăn xếp có rỗng không
                if (stack.Count == 0)
                    return false;

                // Lấy phần tử trên cùng của ngăn xếp
                char top = stack.Pop();

                // Kiểm tra xem có khớp với dấu ngoặc đóng không
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                {
                    return false;
                }
            }
        }

        // Nếu ngăn xếp vẫn còn phần tử, chuỗi không hợp lệ
        return stack.Count == 0;
    }
}