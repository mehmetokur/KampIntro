using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<TKey,TValue>
    {
        TKey[] _keyArray;
        TKey[] _keyTempArray;
        TValue[] _valueArray;
        TValue[] _valueTempArray;

        public Dictionary()
        {
            _keyArray = new TKey[0];
            _valueArray = new TValue[0];
        }

        public void Add(TKey Name, TValue Age)
        {
            _keyTempArray = _keyArray;
            _valueTempArray = _valueArray;
            _keyArray = new TKey[_keyArray.Length + 1];
            _valueArray = new TValue[_valueArray.Length + 1];

            for (int i = 0; i < _keyTempArray.Length; i++)
            {
                _keyArray[i] = _keyTempArray[i];
                _valueArray[i] = _valueTempArray[i];
            }

            _keyArray[_keyArray.Length - 1] = Name;
            _valueArray[_valueArray.Length - 1] = Age;

    
        }
        public int Count
        {
            get { return _keyArray.Length; }
        }

  
    }
}
