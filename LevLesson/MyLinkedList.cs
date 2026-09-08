public class MyLinkedList<T>
{
    private Node<T>? _head;   // первый элемент списка
    private Node<T>? _tail;   // последний элемент списка
    private int _count;      // количество элементов

    // Внутренний класс узла
    private class Node<U>
    {
        public U Value;
        public Node<U>? Next;

        public Node(U value)
        {
            Value = value;
            Next = null;
        }
    }

    // Добавить элемент в конец
    public void AddLast(T value)
    {
        Node<T> newNode = new Node<T>(value);

        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail!.Next = newNode;
            _tail = newNode;
        }

        _count++;
    }

    // Добавить элемент в начало
    public void AddFirst(T value)
    {
        Node<T> newNode = new Node<T>(value);

        newNode.Next = _head;
        _head = newNode;

        if (_tail is null)
            _tail = newNode;

        _count++;
    }

    // Удалить первый элемент
    public void RemoveFirst()
    {
        if (_head is null)
            throw new InvalidOperationException("Список пуст");

        _head = _head.Next;

        if (_head is null)
            _tail = null;

        _count--;
    }

    // Проверка наличия элемента
    public bool Contains(T value)
    {
        Node<T>? current = _head;

        while (current is not null)
        {
            if (current.Value is not null && current.Value.Equals(value))
                return true;

            current = current.Next;
        }

        return false;
    }

    // Количество элементов
    public int Count => _count;

    // Перебор элементов
    public IEnumerable<T> AsEnumerable()
    {
        Node<T>? current = _head;

        while (current is not null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    public static bool operator ==(MyLinkedList<T> left, MyLinkedList<T> right)
    {
        if (left is null || right is null)
        {
            return false;
        }

        if (left.Count != right.Count)
        {
            return false;
        }

        foreach (var item in left.AsEnumerable())
        {
            if (!right.Contains(item))
            {
                return false;
            }
        }

        return true;
    }

    public static bool operator !=(MyLinkedList<T> left, MyLinkedList<T> right)
    {
        return !(left == right);
    }
}