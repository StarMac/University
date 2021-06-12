package lab5.test;

import lab5.model.Wood;
import lab5.store.WoodDirectory;

import java.io.File;
import java.io.FileOutputStream;
import java.io.ObjectOutputStream;

public class TestStoreObject {
    public static void main() {
        //Створення довідника деревини
        WoodDirectory wd = new WoodDirectory();
        //Додаємо новий вид деревини
        wd.add(new Wood(4,"Дуб",1f));
        //Збереження каталогу у файлі
        File f = new File("wd.TestObject");
        try{
            FileOutputStream fos = new FileOutputStream(f);
            ObjectOutputStream oos = new ObjectOutputStream(fos);
            oos.writeObject(wd);
            oos.close();
        }catch (Exception e ){
            e.printStackTrace();
        }
    }

}
