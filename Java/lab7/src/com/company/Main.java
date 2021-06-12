package com.company;

import com.company.lab7.test.TestApp;
import com.company.lab7.test.TestCollections;

import java.io.IOException;

public class Main {

    public static void main(String[] args) throws IOException {
        TestCollections testCollections = new TestCollections();
        testCollections.main();
        TestApp app = new TestApp();
        app.startApp();
/*
        TestByConsole appConsole= new TestByConsole();
        appConsole.startAppConsole();*/
      // TestFile.main();

     //   TestStoreObject storeObject = new TestStoreObject();
      //  storeObject.main();

     //   TestRestoreObject restoreObject = new TestRestoreObject();
      //  restoreObject.main();


    }
}
