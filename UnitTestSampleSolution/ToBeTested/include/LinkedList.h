#pragma once

#include <vector>

namespace ToBeTested
{
    // Make it gereric
    template<typename T>
    class LinkedList
    {
        std::vector<T> _internalList{};
    public:
        void Add(T item);
    };
}

