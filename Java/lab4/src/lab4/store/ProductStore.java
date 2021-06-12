package lab4.store;

import lab4.model.IWeight;

import java.util.Arrays;

public class ProductStore extends AbstractStore {

    public void add(IWeight newProduct){
        //Запобігаємо переповнення масиву
        if(arr.length == count)
            arr = Arrays.copyOf(arr, count + count/2);
        //Додаємо новий елемент
        arr[count++] = newProduct;
    }

    public  String toString(){
        StringBuilder sb = new StringBuilder("Вміст сховища продуктів:\n");
        sb.append(super.toString());
        return  sb.toString();
    }
}
