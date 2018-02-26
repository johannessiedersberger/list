using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test
{
  class Test
  {
    [Test]
    public void TestAdd()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(1);
      list.Add(2);
      list.Add(3);

      Assert.That(list.Length(), Is.EqualTo(3));
      Assert.That(list.Get(0), Is.EqualTo(1));
      Assert.That(list.Get(1), Is.EqualTo(2));
      Assert.That(list.Get(2), Is.EqualTo(3));
    }

    [Test]
    public void TestExists()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(1);
      list.Add(2);
      list.Add(3);

      Assert.That(list.Exists(1), Is.EqualTo(true));
      Assert.That(list.Exists(2), Is.EqualTo(true));
      Assert.That(list.Exists(3), Is.EqualTo(true));
      Assert.That(list.Exists(5), Is.EqualTo(false));
    }

    [Test]
    public void TestLength()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(1);
      list.Add(2);
      list.Add(3);

      Assert.That(list.Length(), Is.EqualTo(3));
    }

    [Test]
    public void TestRemove()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(1);
      list.Add(2);
      list.Add(3);


      list.Remove(2);

      Assert.That(list.Length(), Is.EqualTo(2));
      Assert.That(list.Get(0), Is.EqualTo(1));
      Assert.That(list.Get(1), Is.EqualTo(3));
    }

    [Test]
    public void TestGet()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(1);
      list.Add(2);
      list.Add(3);

      Assert.That(list.Get(1), Is.EqualTo(2));
      Assert.Throws<IndexOutOfRangeException>(() => list.Get(10));
    }
  }
}
