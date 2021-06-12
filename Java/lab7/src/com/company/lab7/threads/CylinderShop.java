package com.company.lab7.threads;

import com.company.lab7.model.Cylinder;
import com.company.lab7.model.IWeight;
import com.company.lab7.model.Timber;
import com.company.lab7.model.Wood;
import com.company.lab7.store.ProductStore;
import com.company.lab7.store.WoodDirectory;

public class CylinderShop extends WoodShop{

    public CylinderShop(String name, WoodDirectory wd, ProductStore ps, int n) {
        super(name, wd, ps, n);
    }

    @Override
    protected IWeight createProduct() throws Exception {
        int woodId = rnd.nextInt(3);
        Wood wood = wd.get(woodId);
        float length = 1 + rnd.nextFloat() * 10;
        float diameter = 0.1f + rnd.nextFloat();
        Cylinder cylinder = new Cylinder(wood, length, diameter);
        return  cylinder;
    }
}
