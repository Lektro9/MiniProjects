
public class ggt {

    public static int ggtt(int x, int y){

        if(x == y){
        return x;
    }
    int gr = (x > y) ? x : y;
    int kl = (x < y) ? x : y;

    for (int i = gr/2; i >=2; i--){
        if (gr % i == 0 && kl % i == 0)
        {
            return i;
        }
    }
        return 1;
    }
}