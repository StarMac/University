package com.company.lab7.threads;

import com.company.lab7.model.IWeight;
import com.company.lab7.model.Timber;
import com.company.lab7.model.Wood;
import com.company.lab7.store.ProductStore;
import com.company.lab7.store.WoodDirectory;

import java.util.Random;

public abstract  class WoodShop implements  Runnable{
    WoodDirectory wd;
    ProductStore ps;
    Random rnd = new Random();
    String name;
    int n;

    public String getName(){
        return name;
    }
    public WoodShop(String name, WoodDirectory wd, ProductStore ps, int n) {
        this.name = name;
        this.wd = wd;
        this.ps = ps;
        this.n = n;
    }


    public  void run(){
        for (int i = 0; i < n; i++) {
            try {
                IWeight product = createProduct();
                ps.add(product);
                System.out.println(this.getName() + " create " + product);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    protected abstract IWeight createProduct() throws Exception;
}
