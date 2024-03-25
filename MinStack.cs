namespace LeetCode
{
    public class MinStack
    {
        //155. Min Stack
        private Stack<int> _stack;
        private Stack<int> _minStack;

        public MinStack()
        {
            _stack = new Stack<int>();
            _minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            _stack.Push(val);
            if(_minStack.Count <= 0 )
            {
                _minStack.Push(val);
                return;
            }
            else
            {
                int outvar = _minStack.Peek();
                if( outvar > val )
                {
                    _minStack.Push(val);
                }
            }
        }

        public void Pop()
        {
            int popped = _stack.Pop();
            if (popped == _minStack.Peek())
            {
                _minStack.Pop();
            }
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            if (_minStack.Count == 0)
                return 0;
            return _minStack.Peek();
        }
    }
}
