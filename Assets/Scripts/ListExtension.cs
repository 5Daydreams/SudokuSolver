﻿using System.Collections.Generic;
using UnityEngine;

public static class ListExtension
{
    public static IList<T> GetRandomElements<T>(this IList<T> list, int count)
    {
        var temp = new List<T>();

        for (int i = count; i > 0; i--)
        {
            int j = Random.Range(0, list.Count);
            temp.Add(list[j]);
            list.RemoveAt(j);
            count--;
        }

        foreach (var tempElement in temp)
        {
            list.Add(tempElement);
        }

        return temp;
    }

    public static T PopRandomElement<T>(this IList<T> list)
    {
        int randomIndex = Random.Range(0, list.Count);
        T poppedElement = list[randomIndex];
        list.RemoveAt(randomIndex);
        return poppedElement;
    }
}