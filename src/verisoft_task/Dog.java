/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package verisoft_task;

/**
 *
 * @author Leah Dushnitzki
 */
public class Dog extends Animal implements Land {

    static int numberOfLegs = 4;

    public Dog(boolean mammals, boolean carnivorous, int mood) {
        super(mammals, carnivorous, mood);
    }

    public void sayHello() {
        System.out.print("wagging their tails");
    }

    @Override
    public void sayHello(int mood) {
        this.mood = mood;
        if (this.mood == MOOD_HAPPY) {
            System.out.print("hav hav");
        } else if (this.mood == MOOD_SCARE) {
            System.out.print("whooping");
        }
    }

    @Override
    public int getNumberOfLegs() {
        return numberOfLegs;
    }
}
