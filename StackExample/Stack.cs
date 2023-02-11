using System.Collections;

namespace StackExample;

class Stack
{
    private readonly ArrayList _stack = new ArrayList();
    
    public void PushItem(object item)
    {
        _stack.Add(item);
    }

    public ArrayList PopItem()
    {
        try
        {
            if (_stack.Count == 0)
            {
                throw new IndexOutOfRangeException("No items to pop");
            }
            var popEle = _stack[^1];
            _stack.RemoveAt(_stack.Count - 1);
            Console.WriteLine(popEle);
        }
        catch (Exception e)
        {
            //throw new Exception(e.Message);
            Console.WriteLine(e.Message);
        }
        return _stack;
    }
}