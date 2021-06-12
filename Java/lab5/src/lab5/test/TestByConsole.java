package lab5.test;

import lab5.model.*;
import lab5.store.ProductStore;
import lab5.store.WoodDirectory;

import javax.swing.*;
import javax.swing.filechooser.FileFilter;
import java.io.*;
import java.util.Date;
import java.util.Scanner;

public class TestByConsole implements java.io.Serializable{
    //Каталог для деревини;
    private WoodDirectory wdUser = new WoodDirectory();
    //Каталог для брусів
    private ProductStore psUser = new ProductStore();
    Scanner in = new Scanner(System.in);
    private final BufferedWriter bw = new BufferedWriter(new FileWriter("Log.TXT",true));

    boolean work = true;

    public TestByConsole() throws IOException {
    }

    public void startAppConsole() throws IOException {
        Name();
        System.out.println();
        //Наповнюємо каталог деревини в WoodDirectory
        wdUser.add(new Wood(0,"Дуб",0.7f));
        wdUser.add(new Wood(1,"Сосна",0.9f));
        wdUser.add(new Wood(2,"Ялина",0.6f));
        while(work) {
            System.out.println("Що ви хочете зробити?");
            System.out.println("- Додати деревину \n- Додати брус \n- Додати циліндр \n- Додати відходи \n" +
                    "- Підрахувати загальну вагу \n- Зберегти \n- Експортувати у текстовий файл \n- Завершити роботу ");
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
                case "Зберегти":
                    Serialization();
                    Deserialization();
                    break;
                case "Експортувати у текстовий файл":
                    ToTXTFile();
                    break;
                case "Завершити роботу":
                    EndWork();
                    bw.close();
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
        if (wdUser.add(newWood)) {
            WriteString(newWood.toString());
        }
        else{
            System.out.println(newWood + " id вже існує\n");
        }

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
        try {
            Timber t = new Timber(wdUser.get(id), length, height, width);
            psUser.add(t);
            WriteString(t.toString());
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Введення продуктів", JOptionPane.ERROR_MESSAGE);
            AddTimber();
        }
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
        try {
            Cylinder c = new Cylinder(wdUser.get(id), length, diameter);
            psUser.add(c);
            WriteString(c.toString());
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Введення продуктів", JOptionPane.ERROR_MESSAGE);
            AddCylinder();
        }
        System.out.println(psUser);
        id = -1;
    }

    private void AddWaste() {
        System.out.println("Введіть кількість відходів:");
        float weight = in.nextFloat();
        try {
            Waste w = new Waste(weight);
            psUser.add(w);
            WriteString(w.toString());
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Введення продуктів", JOptionPane.ERROR_MESSAGE);
            AddWaste();
        }
        System.out.println(psUser);

    }
    private void calcWeight(){
        float fullWeight = 0;
        for (Object timber : psUser.getArr()){
            fullWeight+=((IWeight)timber).weight();
        }
        System.out.println(fullWeight);
    }

    private void Serialization (){
        //Збереження WoodDirectory у файлі
        File f = new File("wd.object");
        try{
            FileOutputStream fos = new FileOutputStream(f);
            ObjectOutputStream oos = new ObjectOutputStream(fos);
            oos.writeObject(wdUser);
            oos.close();
        }catch (Exception e ){
            e.printStackTrace();
        }
        //Збереження ProductStore у файлі
        File ff = new File("ps.object");
        try{
            FileOutputStream fos1 = new FileOutputStream(ff);
            ObjectOutputStream oos1 = new ObjectOutputStream(fos1);
            oos1.writeObject(psUser);
            oos1.close();
        }catch (Exception e ) {
            e.printStackTrace();
        }

    }
    private void Deserialization () {
        //Відновлення WoodDirecroty з файлу
        File f = new File("wd.object");
        try{
            FileInputStream fis = new FileInputStream(f);
            ObjectInputStream ois = new ObjectInputStream(fis);
            wdUser = (WoodDirectory) ois.readObject();
            ois.close();
        }catch(Exception e) {
            e.printStackTrace();
        }
        //Виведення WoodDirecroty на консоль
        if (wdUser != null){
            for (Object w: wdUser.getArr())
                System.out.println(w.toString());
        }

        //Відновлення ProductStore з файлу
        File ff = new File("ps.object");
        try{
            FileInputStream fis1 = new FileInputStream(ff);
            ObjectInputStream ois1 = new ObjectInputStream(fis1);
            psUser = (ProductStore) ois1.readObject();
            ois1.close();
        }catch(Exception e) {
            e.printStackTrace();
        }
        //Виведення ProductStore на консоль
        if (psUser != null){
            for (Object w: psUser.getArr())
                System.out.println(w.toString());
        }
    }

    private void ToTXTFile(){
        try {
            UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        } catch (InstantiationException e) {
            e.printStackTrace();
        } catch (IllegalAccessException e) {
            e.printStackTrace();
        } catch (UnsupportedLookAndFeelException e) {
            e.printStackTrace();
        }

        JFileChooser dialog = new JFileChooser();
        dialog.setFileFilter(new FileFilter() {
            @Override
            public boolean accept(File f) {
                if (f!= null){
                    //Відображати усі папки та файли .txt
                    return f.isDirectory() || f.toString().endsWith(".txt");
                }
                return false;
            }

            @Override
            public String getDescription() {
                return "файли типу *.txt";
            }
        });
        dialog.setFileSelectionMode(JFileChooser.FILES_AND_DIRECTORIES);
        dialog.setDialogTitle("Виберіть потрібні файли і папки");
        dialog.setApproveButtonText("Open");
        dialog.setMultiSelectionEnabled(true);
        dialog.showSaveDialog(null);
        File [] ff= dialog.getSelectedFiles();
        if(ff!=null) {
            for (File f : ff) {
                System.out.println(f.getAbsolutePath());
                //формування текстового файлу з каталогом деревини та виробів
                try {
                    BufferedWriter writer = new BufferedWriter(new FileWriter(f));
                    writer.write(wdUser.toString());
                    writer.newLine();
                    writer.write(psUser.toString());
                    writer.close();
                    System.out.println("Файл збережено");
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }
    }

    private void Name(){
        System.out.println("Введіть ваше ім'я та прізвище");
        String s = in.nextLine();
        try{
            bw.write((new Date())+ " " + s + " logged in");
            bw.newLine();
        }catch (IOException e){
            e.printStackTrace();
        }
    }

    private void WriteString(String s){
        try {
            bw.write((new Date()) + " added " + s);
            bw.newLine();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

}