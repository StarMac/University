package lab1.test;

import lab1.model.Timber;
import lab1.model.Wood;
import lab1.store.ProductStore;
import lab1.store.WoodDirectory;

import java.util.Scanner;

public class TestByConsole {
    //Каталог для деревини;
    private WoodDirectory wdUser = new WoodDirectory();
    //Каталог для брусів
    private ProductStore psUser = new ProductStore();
    Scanner in = new Scanner(System.in);

    boolean work = true;

    public void startAppConsole(){
        System.out.println();
        while(work) {
            System.out.println("Що ви хочете зробити?");
            switch (in.nextLine()){
                case "Додати деревину":
                    AddWood();
                    break;
                case "Додати брус":
                    AddTimber();
                    break;
                case "Підрахувати загальну вагу":
                    calcWeight();
                    break;
                case "Завершити роботу":
                    EndWork();
                    break;
                default:
                    System.out.println("Введені неправильні дані");
                    break;
            }


        }
    }

    private void EndWork() {
        work = !work;
    }

    private void AddWood(){
        int  id = wdUser.getArr().length;
        System.out.println("Введіть тип деревини:");
        String name = in.nextLine();
        System.out.println("Введіть плотність деревини:");
        float density = in.nextFloat();

        Wood newWood = new Wood(id,name,density);
        wdUser.add(newWood);
        System.out.println(wdUser);
    }

    private void AddTimber(){
        System.out.println(wdUser);
        System.out.println("Введіть id деревини:");
        int id = in.nextInt();
        System.out.println("Введіть довжину бруска:");
         float length = in.nextFloat();
        System.out.println("Введіть висоту бруска:");
         float height = in.nextFloat();
        System.out.println("Введіть ширину бруска:");
         float width = in.nextFloat();
        psUser.add(new Timber(wdUser.get(id),length,height,width));
        System.out.println("Перелік брусків" + psUser);
        id = -1;
    }

    private void calcWeight(){
        float fullWeight = 0;
        for (Timber timber : psUser.getArr()){
            fullWeight+=timber.weight();
        }
        System.out.println(fullWeight);
    }
}