package lab1.store;

import lab1.model.Timber;

import java.util.Arrays;

public class ProductStore {
    private int count = 0;
    private Timber[]arr = new Timber[3];

    public Timber[] getArr() {
        return Arrays.copyOf(arr,count);
    }

    public void add(Timber newTimber){
        //Запобігаємо переповнення масиву
        if(arr.length == count)
            arr = Arrays.copyOf(arr, count + count/2);
        //Додаємо новий елемент
        arr[count++] = newTimber;
    }

    public  String toString(){
        StringBuilder sb = new StringBuilder("Каталог брусков:\n");
        for (int i = 0; i < count; i++) {
            sb.append(arr[i]).append("\n");
        }
        return  sb.toString();
    }
}
