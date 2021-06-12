package lab2.test;

import lab2.model.*;
import lab2.store.ProductStore;
import lab2.store.WoodDirectory;

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
        //Наповнюємо каталог деревини в WoodDirectory
        wdUser.add(new Wood(0,"Дуб",0.7f));
        wdUser.add(new Wood(1,"Сосна",0.9f));
        wdUser.add(new Wood(2,"Ялина",0.6f));
        while(work) {
            System.out.println("Що ви хочете зробити?");
            switch (in.nextLine()){
                case "Додати деревину":
                    AddWood();
                    break;
                case "Додати брус":
                    AddTimber();
                    break;
                case "Додати циліндр":
                    AddCylinder();
                    break;
                case "Додати відходи":
                    AddWaste();
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
        System.out.println(psUser);
        id = -1;
    }

    private void AddCylinder(){
        System.out.println(wdUser);
        System.out.println("Введіть id деревини:");
        int id = in.nextInt();
        System.out.println("Введіть довжину циліндра:");
        float length = in.nextFloat();
        System.out.println("Введіть діаметр циліндра:");
        float diameter = in.nextFloat();
        psUser.add(new Cylinder(wdUser.get(id),length,diameter));
        System.out.println(psUser);
        id = -1;
    }

    private void AddWaste() {
        System.out.println("Введіть кількість відходів:");
        float weight = in.nextFloat();
        psUser.add(new Waste(weight));
        System.out.println(psUser);

    }
    private void calcWeight(){
        float fullWeight = 0;
        for (Object timber : psUser.getArr()){
            fullWeight+=((IWeight)timber).weight();
        }
        System.out.println(fullWeight);
    }
}