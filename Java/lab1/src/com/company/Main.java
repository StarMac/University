package com.company;

import lab1.test.TestApp;
import lab1.test.TestByConsole;

public class Main {

    public static void main(String[] args) {
        TestApp app = new TestApp();
        app.startApp();

        TestByConsole appConsole= new TestByConsole();
        appConsole.startAppConsole();
    }
}
