using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Node
{
  public Node next;
  public int data;
}

public class MyLinkedList
{
  private Node _topElement;

  /// <summary>
  /// Adds a new Value at the end of the list
  /// </summary>
  /// <param name="value"></param>
  public void Add(int value)
  {
    if (_topElement == null)
    {
      _topElement = new Node();
      _topElement.data = value;
    }
    else
    {
      Node elementToAdd = new Node();
      elementToAdd.data = value;

      Node current = _topElement;
      while (current.next != null)
        current = current.next;
      current.next = elementToAdd;
    }
  }

  /// <summary>
  /// Checks if the given value is included in the list
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  public bool Exists(int value)
  {
    for (Node current = _topElement; current != null; current = current.next)
    {
      if (current.data == value)
        return true;
    }
    return false;
  }

  /// <summary>
  /// Returns the lenght of the list
  /// </summary>
  /// <returns></returns>
  public int Length()
  {
    int length = 0;
    for (Node current = _topElement; current != null; current = current.next)
    {
      length++;
    }
    return length;
  }

  /// <summary>
  /// Returns the Value of the Index in the list
  /// </summary>
  /// <param name="index"></param>
  /// <returns></returns>
  public int Get(int index)
  {
    int position = 0;
    for (Node current = _topElement; current != null; current = current.next)
    {
      if (position == index)
        return current.data;
      position++;
    }
    throw new IndexOutOfRangeException("The index is not in the list");
  }

  /// <summary>
  /// Removes the given value from the list
  /// </summary>
  /// <param name="value"></param>
  public void Remove(int value)
  {
    for (Node current = _topElement; current != null; current = current.next)
    {
      if (_topElement.data == value)
      {
        _topElement = current.next;
      }
      else if (current.next != null && current.next.data == value)
      {
        current.next = current.next.next;
      }
    }
  }
}

