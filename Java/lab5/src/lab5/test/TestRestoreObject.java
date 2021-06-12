package lab5.test;

import lab5.store.WoodDirectory;

import java.io.*;

public class TestRestoreObject {
    public static void main() {
    WoodDirectory wd = null;
    //Відновлення довідника з файлу
    File f = new File("wd.TestObject");
    try{
        FileInputStream fis = new FileInputStream(f);
        ObjectInputStream ois = new ObjectInputStream(fis);
        wd = (WoodDirectory) ois.readObject();
        ois.close();
    }catch(Exception e) {
        e.printStackTrace();
    }
    //Виведення довідника на консоль
        if (wd != null){
            for (Object w: wd.getArr())
                System.out.println(w.toString());
        }

    }
}
