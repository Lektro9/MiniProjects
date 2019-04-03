import java.util.HashSet;
import java.util.Set;

public class Kontaktetest
{

    public static void main(String args[]){
        Set<Kontakt> kontakte = new HashSet<>();

        kontakte.add(
            new Kontakt("Peter", "Hansen", "PeterH@web.de", "016112323323")
        );
        kontakte.add(
            new Kontakt("Klaus", "Schmitz", "schmitz@example.com", "0123/45678")
        );
        kontakte.add(
            new Kontakt("Anna", "Müller", "anna.mueller@example.com", "0161/12345678")
        );
        kontakte.add(
            new Kontakt("Fritz", "Becker", "becker@example.org", "0987/654321")
        );
       for (Kontakt kontakt:kontakte){
           System.out.printf(kontakt.getKontakt() + "\n");
       }

    }

}