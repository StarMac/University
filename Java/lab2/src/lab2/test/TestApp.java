package lab2.test;

import lab2.model.*;
import lab2.store.ProductStore;
import lab2.store.WoodDirectory;

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
        ps.add(new Timber(wd.get(0),5f,0.5f,0.4f ));
        ps.add(new Timber(wd.get(1),10f,0.5f,0.4f ));
        ps.add(new Cylinder((wd.get(2)), 10f,2f));
        ps.add(new Waste(2.5f));
        //Друкуємо перелік продуктів
        System.out.println(wd);
        System.out.println(ps);
        //Обчислюємо вагу продуктів
        System.out.printf("Загальна вага: %1.3f", calcWeight());
    }

    private float calcWeight(){
        float fullWeight = 0;
        for (Object timber : ps.getArr()){
            fullWeight+= ((IWeight)timber).weight();
        }
        return fullWeight;
    }
}
