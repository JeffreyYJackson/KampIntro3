namespace MyDict
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;
        
        private TKey[] _tempKeys;
        private TValue[] _tempValues;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }
        
        
        public void Add(TKey key, TValue value)
        {
            
        }
    }
}