package com.company;

import lab5.test.*;

import java.io.IOException;

public class Main {

    public static void main(String[] args) throws IOException {
        TestApp app = new TestApp();
        app.startApp();

        TestByConsole appConsole= new TestByConsole();
        appConsole.startAppConsole();

       TestFile.main();

        TestStoreObject storeObject = new TestStoreObject();
        storeObject.main();

        TestRestoreObject restoreObject = new TestRestoreObject();
        restoreObject.main();


    }
}
