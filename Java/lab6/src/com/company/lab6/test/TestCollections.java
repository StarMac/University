package com.company.lab6.test;

import com.company.lab6.model.Wood;

import java.util.*;

public class TestCollections {
    public static void main() {
///////lab 6
        //6.2.1.2
        Random rnd = new Random();
        Collection<Integer> c1 = new Vector<>();
        for (int i = 0; i < 15; i++) {
            c1.add(rnd.nextInt(10));
        }
        System.out.println("Collection vector");
        for (Integer x: c1) {
            System.out.printf("%d ", x);
        }

        Collection<Integer> c2 = new TreeSet<>();
        c2.addAll(c1);
        System.out.println("\nCollection TreeSet");
        c2.forEach((x)-> System.out.printf("%d ", x));
        //6.2.1.3
        Collection<Integer> c11 = new ArrayList<>();
        Collection<Integer> c12 = new LinkedHashSet<>();
        Collection<Integer> c13 = new ArrayList<>();

        for (int i = 0; i < 10; i++) {
            c11.add(rnd.nextInt(10));
            c12.add(rnd.nextInt(10));
        }
        System.out.println();
        c13.addAll(c11); c13.removeAll(c12);
        System.out.println(c11 + " removeAll " + c12 + " = " + c13);

        c13.clear(); c13.addAll(c12); c13.removeAll(c11);
        System.out.println(c12 + " removeAll " + c11 + " = " + c13);

        c13.clear(); c13.addAll(c11); c13.retainAll(c12);
        System.out.println(c11 + " retainAll " + c12 + " = " + c13);

        c13.clear(); c13.addAll(c11); c13.retainAll(c11);
        System.out.println(c12 + " retaintAll " + c11 + " = " + c13);

        Collection<Integer> c111 = new ArrayList<>();
        for (int i = 0; i < 10; i++) {
            c111.add(rnd.nextInt(10));
        }

        Collection<Integer> c112 = new LinkedHashSet<>();
        c112.addAll(c111);
        boolean b1 = c111.containsAll(c111);
        System.out.println(c111 + "ContainsAll" + c112 + " = " + b1);

        Collection<Integer> c113 = new TreeSet<>();
        c113.addAll(c111);
        boolean b2 = c111.containsAll(c113);
        System.out.println(c111 + "ContrainsAll" + c113 + " = " + b2);

        //6.2.2.2
        ArrayList<Integer> c1111 = new ArrayList<>();
        for (int i = 0; i < 10; i++) {
            c1111.add(rnd.nextInt(10));
        }
        System.out.println("c1111 before sort()= " + c1111);

        c1111.sort(new Comparator<Integer>() {    //c1111.sort((a,b) -> a - b);
            @Override
            public int compare(Integer a, Integer b) {
                return a - b;
            }
        });

        System.out.println("c1111 after sort()= " + c1111);
        //6.2.3.1
        Collection<Integer> coll = new ArrayDeque<>();
        //Methods for Collection
        Collections.addAll(coll, 1, 3, 5, 3, 4, 2, 14);
        Collections.addAll(coll, new Integer[]{3,7,12});
        System.out.println("coll = " + coll);
        System.out.println("Collections.frequency = " + Collections.frequency(coll, 3));
        System.out.println("Collections.max = " + Collections.max(coll));
        System.out.println("Collections.min = " + Collections.min(coll));
        //6.2.3.2

        //Methods for List
        System.out.println();

        List<Integer> list = new ArrayList<>(coll);
        System.out.println("list = " + list);
        Collections.swap(list, 2, 6);
        System.out.println("Collections.swap = " + list);

        Collections.sort(list);
        System.out.println("Collections.sort = " + list);

        System.out.println("Collections.binarySearch = " + Collections.binarySearch(list, 3, (a,b)-> b - a));

        Collections.reverse(list);
        System.out.println("Collections.reverse = " + list);

        Collections.shuffle(list);
        System.out.println("Collections.shuffle = " + list);

        Collections.replaceAll(list, 3, 8);
        System.out.println("Collections.replaceAll = " + list);

        Collections.fill(list, 0);
        System.out.println("Collections.fill = " + list);

        System.out.print("\n\n");
        HashSet<Wood> set = new HashSet<>();
        set.add(new Wood(1, "Lypa", 1f));
        set.add(new Wood(1, "Lypa", 1f));
        set.add(new Wood(1, "Lypa", 1f));

        Wood a = new Wood(1, "Lypa", 1f);
        Wood b = new Wood(1, "Lypa", 1f);
        System.out.println(b.equals(a));
        System.out.println(a.hashCode() + " " + b.hashCode());
        set.forEach(System.out::println);
        ///////lab 6 end
    }
}