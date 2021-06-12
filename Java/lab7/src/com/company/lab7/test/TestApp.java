package com.company.lab7.test;

import com.company.lab7.model.*;
import com.company.lab7.store.ProductStore;
import com.company.lab7.store.WoodDirectory;
import com.company.lab7.threads.CylinderShop;
import com.company.lab7.threads.TimberShop;
import com.company.lab7.threads.WoodShop;

import javax.swing.*;
import java.util.Iterator;
import java.util.ListIterator;
import java.util.function.Predicate;

public class TestApp {

    //Каталог для деревини;
    private WoodDirectory wd = new WoodDirectory();
    //Каталог для брусів
    private ProductStore ps = new ProductStore();

    Predicate<Object> prd = new Predicate<Object>() {
        @Override
        public boolean test(Object t) {
            return false;
        }
    };

    public void startApp() {
        //Наповнюємо каталог деревини в WoodDirectory
        wd.add(new Wood(0, "Дуб", 0.7f));
        wd.add(new Wood(1, "Сосна", 0.9f));
        wd.add(new Wood(2, "Ялина", 0.6f));

        WoodShop shop1 = new TimberShop("shop1", wd, ps, 3);
        WoodShop shop2 = new CylinderShop("cylinderShop", wd, ps, 3);
        Thread tshop1 = new Thread(shop1);
        Thread tshop2 = new Thread(shop2);
        tshop1.start();
        tshop2.start();

        (new Thread(() -> {
            try {
                tshop1.join();
                tshop2.join();
                System.out.println(ps.getCount());
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        })).start();
    }
    private float calcWeight(){
        float fullWeight = 0;
        for (Object timber : ps.getArr()){
            fullWeight+= ((IWeight)timber).weight();
        }
        return fullWeight;
    }
}
