namespace Chapter10_IndexersAndProperties.DynamicArray;

public class DynamicArray
{
    private int[] arr;
    private int capacity;
    private const int initialSize = 10;
    
    public int Length { get; private set; }
    public bool Error { get; private set; }

    public DynamicArray()
    {
        arr = new int[initialSize];
        capacity = initialSize;
    }

    public void Add(int elem)
    {
        if (Length == capacity)
        {
            int[] newArr = new int[capacity * 2];
            for (int i = 0; i < Length; i++)
            {
                newArr[i] = arr[i];
            }

            arr = newArr;
            capacity = capacity * 2;
        }

        arr[Length] = elem;
        Length++;
    }

    public int this[int index]
    {
        get
        {
            if (ok(index))
            {
                Error = false;
                return arr[index];
            }
            else
            {
                Error = true;
                return 0;
            }
        }

        set
        {
            if (ok(index))
            {
                Error = false;
                arr[index] = value;
            }
            else
            {
                Error = true;
            }
        }
    }

    private bool ok(int index)
    {
        if (index >= 0 && index < Length) return true;
        return false;
    }
}