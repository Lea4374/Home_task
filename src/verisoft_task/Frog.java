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
public class Frog extends Animal implements Water, Land {

    static int numberOfLegs = 4;

    public Frog(boolean mammals, boolean carnivorous, int mood) {
        super(mammals, carnivorous, mood);
    }

    @Override
    public void sayHello(int mood) {
        this.mood = mood;
        if (this.mood == MOOD_HAPPY) {
            System.out.print("quack quack quack");
        } else if (this.mood == MOOD_SCARE) {
            System.out.print("plop into the water");
        }
    }

    @Override
    public boolean hasGills() {
        return false;   
    }

    @Override
    public boolean hasLaysEggs() {
        return true;
    }

    @Override
    public int getNumberOfLegs() {
        return numberOfLegs;
    }

}
