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
abstract class Animal {

    protected boolean mammals;
    protected boolean carnivorous;
    public static final int MOOD_HAPPY = 1;
    public static final int MOOD_SCARE = -1;
    protected int mood;

    public Animal(boolean mammals, boolean carnivorous, int mood) {
        this.mammals = mammals;
        this.carnivorous = carnivorous;
        this.mood = mood;
    }

    public void sayHello() {

    }

    public abstract void sayHello(int s);

    public boolean isMammals() {
        return mammals;
    }

    public void setMammals(boolean mammal) {
        this.mammals = mammal;
    }

    public boolean isCarnivorous() {
        return carnivorous;
    }

    public void setCarnivorous(boolean carnivorous) {
        this.carnivorous = carnivorous;
    }

}
