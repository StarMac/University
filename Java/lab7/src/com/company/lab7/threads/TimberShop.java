package com.company.lab7.threads;

import com.company.lab7.model.IWeight;
import com.company.lab7.model.Timber;
import com.company.lab7.model.Wood;
import com.company.lab7.store.ProductStore;
import com.company.lab7.store.WoodDirectory;

import java.util.Random;

public class TimberShop extends WoodShop{

    public String getName(){
        return name;
    }
    public TimberShop(String name, WoodDirectory wd, ProductStore ps, int n) {
        super(name, wd, ps, n);
    }

    public  IWeight createProduct() throws Exception {
        int woodId = rnd.nextInt(3);
        Wood wood = wd.get(woodId);
        float length = 1 + rnd.nextFloat() * 10;
        float height = 0.1f + rnd.nextFloat();
        float width = 0.1f + rnd.nextFloat();
        Timber timber = new Timber(wood, length, height, width);
        return  timber;
    }
}
