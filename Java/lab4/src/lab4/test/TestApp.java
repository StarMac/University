package lab4.test;

import lab4.model.*;
import lab4.store.ProductStore;
import lab4.store.WoodDirectory;

import javax.swing.*;
import java.util.Iterator;
import java.util.ListIterator;

public class TestApp {

    //Каталог для деревини;
    private WoodDirectory wd = new WoodDirectory();
    //Каталог для брусів
    private ProductStore ps = new ProductStore();

    public void startApp(){
        //Наповнюємо каталог деревини в WoodDirectory
        wd.add(new Wood(0,"Дуб",0.7f));
        wd.add(new Wood(1,"Сосна",0.9f));
        wd.add(new Wood(2,"Ялина",0.6f));

        //Наповнюємо сховище брусів
        try {
            ps.add(new Timber(wd.get(0),90f,90f,90f ));
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Введення продуктів", JOptionPane.ERROR_MESSAGE);
        }
        try {
            ps.add(new Timber(wd.get(1),4f,4f,1.2f ));
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Введення продуктів", JOptionPane.ERROR_MESSAGE);
        }
        try {
            ps.add(new Cylinder((wd.get(1)), 10f,2f));
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Введення продуктів", JOptionPane.ERROR_MESSAGE);
        }
        try {
            ps.add(new Waste(0.05f));
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Введення продуктів", JOptionPane.ERROR_MESSAGE);
        }
        //Друкуємо перелік продуктів
        System.out.println(wd);
        System.out.println(ps);
        //Обчислюємо вагу продуктів
        System.out.printf("Загальна вага: %1.3f", calcWeight());

        System.out.println();
        System.out.println();
        System.out.println("Test Iterator");
        System.out.println("Перелік виробів до вилучення");
        System.out.println(ps.toString());
        Iterator<Object> itr = ps.iterator();
        while (itr.hasNext()){
            IWeight obj = (IWeight) itr.next();
            if (obj.weight() > 90) itr.remove();
        }
        System.out.println("Перелік виробів після вилучення");
        System.out.println(ps.toString());

        System.out.println();
        System.out.println("Test ListIterator");
        System.out.println("Перелік виробів до вилучення");
        System.out.println(ps.toString());
        ListIterator<Object> listItr = ps.listIterator();
        while (listItr.hasNext()){
            IWeight obj = (IWeight) listItr.next();
            if (obj.weight() < 1) listItr.remove();
        }
        System.out.println("Перелік виробів після вилучення");
        System.out.println(ps.toString());

    }

    private float calcWeight(){
        float fullWeight = 0;
        for (Object timber : ps.getArr()){
            fullWeight+= ((IWeight)timber).weight();
        }
        return fullWeight;
    }
}
