namespace NullableStructEnumIndexer
{
    internal class CustomResize<T>
    {
        private static int Count = 0;
        private static int Capacity = 4;
        private static T[] array = new T[Capacity];
        private int Length;


        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public override string ToString()
        {
            string output = "Numbers: ";
            for (int i = 0; i < Count; i++)
            {
                output += $",{array[i]}";
            }
            return output;
        }
        public void Add(T value)
        {
            Count++;
            if (Count > Capacity)
            {
                ArrayResizeAvto();
            }
            array[Count - 1] = value;

        }
        public void AddRange(params T[] nums)
        {
            foreach (T value in nums)
            {
                Add(value);
            }
        }
        public bool Contains(T element)
        {
            bool found = false;
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(element))
                {
                    found = true;
                    break;

                }

                Console.WriteLine("Number found");

            }
            if (found == false)
            {
                Console.WriteLine("Not found");
            }
            return found;
        }
        public void Sum()
        {
            if (typeof(T) == typeof(int))
            {
                int sum = 0;
                for (int i = 0; i < Count; i++)
                {
                    sum += Convert.ToInt32(array[i]);
                }
                Console.WriteLine($"Sum is {sum}");
            }
            else
            {
                Console.WriteLine("Not numbers, impossible to count");
            }
        }
        public void Remove(T element)
        {
            int index = Array.IndexOf(array, element);
            if (index == -1) return;
            T[] newArray = new T[Capacity];
            int newIndex = 0;
            for (int i = 0; i < Count; i++)
            {
                if (i == index) continue;
                newArray[newIndex++] = array[i];
            }

            array = newArray;
            Count--;
        }
        public void RemoveRange(params T[] element)
        {
            foreach (T item in element)
            {
                Remove(item);
            }
        }
        public void ArrayResizeAvto()
        {
            Capacity *= 2;
            Array.Resize(ref array, Capacity);

        }

        public int CountMethod()
        {
            return Count;
        }

    }
}

