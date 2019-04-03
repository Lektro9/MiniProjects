import java.util.List;
import java.util.ArrayList;

public class ZweigSortTest{

    public static void main(String args[]){
        ZweigSort zweigSort = new ZweigSort();
        ArrayList<Integer> test = new ArrayList<>();
        test.add(11);
        test.add(4454);
        test.add(43);
        test.add(5556);
        for(int i = 0; i < test.size(); i++){
            zweigSort.addWert(test.get(i));
        }
/*         for (int i = 0; i < args.length; i++) {
            try {
                zweigSort.addWert(Integer.parseInt(args[i]));
            } catch(NumberFormatException e) {
            }
        } */
        List<Integer> sortiertAndersHerum = zweigSort.werdeAndersherumSortiert();
        for(int i:sortiertAndersHerum){
            System.out.println(i);
        }
    }
}