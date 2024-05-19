#include "LinkedList.h"

template <typename T>
void LinkedList<T>::Add(T item)
{
    _internalList.push_back(item);
}
