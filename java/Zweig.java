public class Zweig{

    private int wert;
    private Zweig links = null;
    private Zweig rechts = null;

    //Zweig Definitionen
    public Zweig(int _wert){
        wert = _wert;
    }

    public Zweig(int _wert, Zweig _links, Zweig _rechts){
        wert = _wert;
        links = _links;
        rechts = _rechts;
    }

    //Werte und Linke/Rechte Zweige erstellen oder abrufen
    public void setWert(int _wert){
        wert = _wert;
    }

    public void setLinks(Zweig _links){
        links = _links;
    }

    public void setRechts(Zweig _rechts){
        rechts = _rechts;
    }

    public int getWert(){
        return wert;
    }

    public Zweig getLinks(){
        return links;
    }

    public Zweig getRechts(){
        return rechts;
    }
}