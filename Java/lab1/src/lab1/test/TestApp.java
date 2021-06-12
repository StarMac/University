package lab1.test;

import lab1.model.Timber;
import lab1.model.Wood;
import lab1.store.ProductStore;
import lab1.store.WoodDirectory;

public class TestApp {

    //Каталог для деревини;
    private WoodDirectory wd = new WoodDirectory();
    //Каталог для брусів
    private ProductStore ps = new ProductStore();

    public void startApp(){
        //Наповнюємо сховище брусів
        ps.add(new Timber(wd.get(0),5f,0.5f,0.4f ));
        ps.add(new Timber(wd.get(1),10f,0.5f,0.4f ));
        //Друкуємо перелік продуктів
        System.out.println(wd);
        System.out.println(ps);
        //Обчислюємо вагу продуктів
        System.out.printf("Загальна вага: %1.3f", calcWeight());
    }

    private float calcWeight(){
        float fullWeight = 0;
        for (Timber timber : ps.getArr()){
            fullWeight+=timber.weight();
        }
        return fullWeight;
    }
}
