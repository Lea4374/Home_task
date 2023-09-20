/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package verisoft_task;

import java.io.ByteArrayOutputStream;
import java.io.PrintStream;
import org.junit.Assert;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;
import org.testng.annotations.Test;

/**
 *
 * @author Leah Dushnitzki
 */
public class TestAnimal {

    @Test
    public static void main(String[] args) {
        Cat cat = new Cat(true, true, Animal.MOOD_HAPPY);
        Assert.assertEquals(cat.getNumberOfLegs(), 4);

        Dog dog = new Dog(true, true, Animal.MOOD_SCARE);
        Assert.assertEquals(dog.getNumberOfLegs(), 4);

        Frog frog = new Frog(false, false, Animal.MOOD_HAPPY);
        Assert.assertEquals(frog.getNumberOfLegs(), 4);
        assertTrue(!frog.hasGills());
        assertFalse(frog.hasGills());
        assertTrue(frog.hasLaysEggs());
        assertFalse(!frog.hasLaysEggs());

        String res = null;
        PrintStream originalOut = System.out;
        try {
            ByteArrayOutputStream os = new ByteArrayOutputStream(100);
            PrintStream capture = new PrintStream(os);
            System.setOut(capture);
            cat.sayHello();
            dog.sayHello();
            cat.sayHello(Animal.MOOD_HAPPY);
            cat.sayHello(Animal.MOOD_SCARE);
            dog.sayHello(Animal.MOOD_HAPPY);
            dog.sayHello(Animal.MOOD_SCARE);
            frog.sayHello(Animal.MOOD_HAPPY);
            frog.sayHello(Animal.MOOD_SCARE);
            capture.flush();
            res = os.toString();
        } finally {
            System.setOut(originalOut);
        }
        Assert.assertEquals(res, "meow~wagging their tailspurr, purrhisshav havwhoopingquack quack quackplop into the water");      
    }
}
