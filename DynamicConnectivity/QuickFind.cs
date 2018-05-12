namespace DynamicConnectivity
{
    public class QuickFind
    {
        private int[] _components;

        public QuickFind(int num)
        {
            _components = new int[num];
            for (var i = 0; i < num; i++)
            {
                _components[i] = i;
            }
        }

        public bool IsConnected(int p, int q)
        {
            return _components[p] == _components[q];
        }

        public void Union(int p, int q)
        {
            var pId = Find(p);
            var qId = Find(q);

            for (var i = 0; i < _components.Length; i++)
            {
                if (_components[i] == pId)
                    _components[i] = qId;
            }
        }

        private int Find(int p)
        {
            return _components[p];
        }
    }
}
