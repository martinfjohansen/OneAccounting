package com.martinfjohansen.oneaccounting.lists.LinkedListStrings.LinkedListStringsFunctions;

import com.martinfjohansen.oneaccounting.lists.LinkedListStrings.Structures.LinkedListNodeStrings;
import com.martinfjohansen.oneaccounting.lists.LinkedListStrings.Structures.LinkedListStrings;
import com.martinfjohansen.oneaccounting.references.references.StringReference;
import com.martinfjohansen.oneaccounting.references.references.*;


import com.martinfjohansen.oneaccounting.lists.LinkedListStrings.Structures.*;

public class LinkedListStringsFunctions{
	public static LinkedListStrings CreateLinkedListString(){
		LinkedListStrings ll;

		ll = new LinkedListStrings();
		ll.first = new LinkedListNodeStrings();
		ll.last = ll.first;
		ll.last.end = true;

		return ll;
	}

	public static void LinkedListAddString(LinkedListStrings ll, char [] value){
		ll.last.end = false;
		ll.last.value = value;
		ll.last.next = new LinkedListNodeStrings();
		ll.last.next.end = true;
		ll.last = ll.last.next;
	}

	public static StringReference[] LinkedListStringsToArray(LinkedListStrings ll){
		StringReference [] array;
		double length, i;
		LinkedListNodeStrings node;

		node = ll.first;

		length = LinkedListStringsLength(ll);

		array = new StringReference [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			array[(int)(i)] = new StringReference();
			array[(int)(i)].string = node.value;
			node = node.next;
		}

		return array;
	}

	public static double LinkedListStringsLength(LinkedListStrings ll){
		double l;
		LinkedListNodeStrings node;

		l = 0d;
		node = ll.first;
		for(; !node.end; ){
			node = node.next;
			l = l + 1d;
		}

		return l;
	}

	public static void FreeLinkedListString(LinkedListStrings ll){
		LinkedListNodeStrings node, prev;

		node = ll.first;

		for(; !node.end; ){
			prev = node;
			node = node.next;
			delete(prev);
		}

		delete(node);
	}

	public static void LinkedListInsertString(LinkedListStrings ll, double index, char [] value){
		double i;
		LinkedListNodeStrings node, tmp;

		if(index == 0d){
			tmp = ll.first;
			ll.first = new LinkedListNodeStrings();
			ll.first.next = tmp;
			ll.first.value = value;
			ll.first.end = false;
		}else{
			node = ll.first;
			for(i = 0d; i < index - 1d; i = i + 1d){
				node = node.next;
			}

			tmp = node.next;
			node.next = new LinkedListNodeStrings();
			node.next.next = tmp;
			node.next.value = value;
			node.next.end = false;
		}
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
