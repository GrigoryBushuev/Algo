using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MinHeap<T> where T : IComparable<T>
    {
        private T[] _heapData;
        private uint _heapSize;

        public MinHeap(uint size)
        {
            _heapData = new T[size];
        }

        public uint Size => _heapSize;

        public void Add(T value)
        {
            EnsureCapacity();
            _heapData[++_heapSize] = value;
            if (_heapSize > 1)
                Swim();
        }

        public T DeleteMin()
        {
            var min = _heapData[1];
            //to avoid loitering
            _heapData[_heapSize] = default(T);
            _heapSize--;
            Sink();
            return min;
        }

        #region private methods

        private void EnsureCapacity()
        {
            if (_heapSize >= _heapData.Length - 1)
                Array.Resize(ref _heapData, _heapData.Length << 1);
        }

        private void Swap(uint left, uint right)
        {
            var temp = _heapData[left];
            _heapData[left] = _heapData[right];
            _heapData[right] = temp;
        }

        private void Sink()
        {

        }

        private uint GetParentIndex(uint index)
        {
            return index >> 1;
        }

        private void Swim()
        {
            var currentIndex = _heapSize;
            var parentIndex = GetParentIndex(currentIndex);
            while (currentIndex > 1 && _heapData[currentIndex].CompareTo(_heapData[parentIndex]) < 0)
            {
                Swap(currentIndex, parentIndex);
                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }
        #endregion
    }
}
