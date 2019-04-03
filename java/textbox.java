import java.awt.*;
import java.awt.event.*;


public class textbox extends Frame implements WindowListener, ActionListener{

    

    public static void main (String args[]){
        textbox k = new textbox();
        k.setSize(480, 360);
        k.setTitle("Friendly Reminder");
        k.setVisible(true);

        
        
    }
    public textbox(){
        this.addWindowListener(this);
    }
    public void paint (Graphics g){
        g.drawString("\"you still suck\" - Billy Bobson Gates, USA, 2018", 50, 50);
        g.setColor(Color.RED);
        g.drawRect(10, 10, 400, 150);
    }

    public void actionPerformed(ActionEvent e){
        
    }
    public void windowOpened(WindowEvent e){
        
    }
    public void windowActivated(WindowEvent e){
        
    }
    public void windowDeactivated(WindowEvent e){
        
    }
    public void windowIconified(WindowEvent e){
        
    }
    public void windowDeiconified(WindowEvent e){
        
    }
    public void windowClosing(WindowEvent e){
        this.dispose();
    }
    public void windowClosed(WindowEvent e){
        //System.exit(0);
    }
}