import java.util.Scanner;

public class kgvJ{
    public static String kgV(int zahl1, int zahl2){
        int gr = (zahl1 > zahl2) ? zahl1 : zahl2;
        int kl = (zahl1 < zahl2) ? zahl1 : zahl2;

        for(int i = 2; i < kl; i++){
            int x = 0;
            x = gr * i;
            if (x % kl == 0) {
                return "kleinstes gemeinsames Vielfaches ist: " + Integer.toString(x);
            }
        }
        return "teilerfremd: "+ Integer.toString(zahl1 * zahl2);
    }

    public static void main(String args[]){
        if (args.length < 2) {
            Scanner sc = new Scanner(System.in);
            System.out.println("Zahl1: ");
            int x = sc.nextInt();
            System.out.println("Zahl2: ");
            int y = sc.nextInt();
            System.out.println(kgV(x, y));
        }
        else {
            System.out.print(kgV(Integer.parseInt(args[0]), Integer.parseInt(args[1])));
        }
        
    }

}