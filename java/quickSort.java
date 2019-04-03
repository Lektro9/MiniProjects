public class quickSort{

    public static void main(String[] args) {
        int[] test = {-5, -3, 4, -8, 10};
        quickSor(test);
        for (int i = 0; i < test.length; i++){
        System.out.print(test[i] + "\n");
        }
    }

public static int[] quickSor(int[] liste){
    qSort (liste, 0, liste.length - 1);
    return liste;
}

static void qSort(int[] liste, int lo, int hi){
    int median;
    if (lo < hi){
        median = liste[hi];
        int i = lo -1;
        int j = hi;
        for( ; ; ){
            while (liste[++i] < median);
            while (j > 0 && liste[--j] > median);
            if (j <= i){
                break;
            }
            int temp = liste[i];
            liste[i] = liste[j];
            liste[j] = temp;
        }
        liste[hi] = liste[i];
        liste[i] = median;

        qSort(liste, lo, i - 1);
        qSort(liste, i + 1, hi);
    }
}

}