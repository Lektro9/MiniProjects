public class nachUnten extends Thread{

    public static void main (String args[]){
        vonUntenNachOben();

    }

    public static void vonUntenNachOben(){

    }

    public static void vonObenNachUnten(){
        for (int i = 10000; i >-1 ; i--) {
            System.out.println(i);        
        }
    }


}