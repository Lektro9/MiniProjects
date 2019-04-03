public class nachOben extends Thread{
    public void run(){
        for (int i = 0; i < 101; i++) {
            System.out.println(i);        
        }
    }
}