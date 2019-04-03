public class nachUnten extends Thread{

    public void run (){
        for (int i = 100; i >-1 ; i--) {
            System.out.println("      " + i);        
        }
    }
}