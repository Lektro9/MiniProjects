import java.util.List;
import java.util.ArrayList;

public class ZweigSort{

    private Zweig wurzel = null;

    public void addWert(int wert){
        if (wurzel == null) {
            wurzel = new Zweig(wert);
        } else {
            recursiveEingabe(wurzel, wert);
        }
    }
    private void recursiveEingabe(Zweig zweig, int wert){
        if (wert <= zweig.getWert()) {
            if(zweig.getLinks() != null){
                recursiveEingabe(zweig.getLinks(), wert);
                return;
            }
            Zweig newZweig = new Zweig(wert);
            zweig.setLinks(newZweig);
            return;
        } else {
            if (zweig.getRechts() != null) {
                recursiveEingabe(zweig.getRechts(), wert);
                return;
            }
            Zweig newZweig = new Zweig(wert);
            zweig.setRechts(newZweig);
            return;
        }
    }

    public ArrayList<Integer> werdeSortiert(){
        ArrayList<Integer> sortiert = new ArrayList<>();
        recursiveLesen(wurzel, sortiert);
        return sortiert;
    }

    public ArrayList<Integer> werdeAndersherumSortiert(){
        ArrayList<Integer> sortiert = new ArrayList<>();
        recursiveAndersherumLesen(wurzel, sortiert);
        return sortiert;
    }

    private void recursiveLesen(Zweig zweig, ArrayList<Integer> list){
        if (zweig.getLinks() != null) {
            recursiveLesen(zweig.getLinks(), list);
        }
        list.add(zweig.getWert());
        if (zweig.getRechts() != null) {
            recursiveLesen(zweig.getRechts(), list);
        }
    }

    private void recursiveAndersherumLesen(Zweig zweig, ArrayList<Integer> list){
        if (zweig.getRechts() != null) {
            recursiveAndersherumLesen(zweig.getRechts(), list);
        }
        list.add(zweig.getWert());
        if (zweig.getLinks() != null) {
            recursiveAndersherumLesen(zweig.getLinks(), list);
        }
    }

}