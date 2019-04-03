
public class Kontakt {

private String vorname;
private String nachname;
private String email;
private String mobile;

// Konstruktor
public Kontakt(String v, String n, String e, String m){
    this.vorname = v;
    this.nachname = n;
    this.email = e;
    this.mobile = m;

}

//Methoden

public String getKontakt(){
    return this.nachname + ", " + this.vorname + "; Email: " + this.email + "; Telefon: " + this.mobile;
}

    
}