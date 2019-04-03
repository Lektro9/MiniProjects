import java.awt.*;
import java.awt.event.*;

import javax.swing.JOptionPane;


public class grafiktest extends Frame implements WindowListener, ActionListener{

    

    public static void main (String args[]){
        grafiktest k = new grafiktest();
        k.setSize(480, 360);
        k.setVisible(true);

        
        
    }
    public grafiktest(){
        MenuBar mb = new MenuBar();
        Menu m = new Menu("Austesten");
        MenuItem mi1 = new MenuItem("hier");
        Button b1 = new Button("Click me!");
        Button b2 = new Button("Tester2");
        Button b3 = new Button("Tester3");
        Button b4 = new Button("Tester4");
        Button b5 = new Button("Tester5");

        this.setLayout(new BorderLayout());
        this.add(b1, BorderLayout.CENTER);
        this.add(b2, BorderLayout.SOUTH);
        this.add(b3, BorderLayout.NORTH);
        this.add(b4, BorderLayout.EAST);
        this.add(b5, BorderLayout.WEST);
        this.setSize (480, 360);
        this.setVisible(true);
        b1.addActionListener(this);
        m.add("hier");
        mb.add(m);
        this.setMenuBar(mb);
        this.addWindowListener(this);
    }
    public void paint (Graphics g){
        g.drawString("you suck", 50, 50);
        g.setColor(Color.RED);
        g.drawRect(10, 10, 400, 150);
    }

    public void actionPerformed(ActionEvent e){
        System.out.print("u suck\n");
        //textbox k2 = new textbox();
        //k2.setSize(480, 360);
        //k2.setVisible(true);
        Frame newW = new Frame();
        JOptionPane.showMessageDialog(newW, "\"you suck\" - Billy Gates, USA, 2018");
        
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
        System.exit(0);
    }
}