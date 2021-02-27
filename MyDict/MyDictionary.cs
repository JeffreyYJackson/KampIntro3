namespace MyDict
{
    public class MyDictionary<TKey, TValue>
    {
        public TKey[] _keys;
        public TValue[] _values;
        
        private TKey[] _tempKeys;
        private TValue[] _tempValues;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }
        
        
        public void Add(TKey key, TValue value)
        {
            _tempKeys = _keys;
            _tempValues = _values;

            _keys = new TKey[_tempKeys.Length + 1];
            _values = new TValue[_tempValues.Length + 1];
            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _values[i] = _tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        
    }
}