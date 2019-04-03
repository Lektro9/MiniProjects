import java.awt.*;
import java.awt.event.*;

import javax.swing.JOptionPane;

public class photoshop extends Frame implements Runnable, MouseMotionListener, ActionListener, WindowListener {

    //GUI
    private MenuBar mb;
    private Menu projekt;
    private MenuItem newTry;
    private MenuItem exit;
    private Menu farben;
    private MenuItem schwarz;

    //Thread und Buffer
    private Thread mal;
    private Image buffer;
    private Graphics bg;

    //globale Variablen
    private int xnew, ynew;
    private int xold, yold;
    private boolean malt;
    private Color farbe;

    public static void main (String args[]){
        photoshop ps = new photoshop();
        ps.start(); //TODO: Thread wird gestartet
        ps.setTitle("Photoshop TM");
        ps.setVisible(true);
        ps.setSize(500, 500);
    }
    
    public photoshop(){

        //Komponenten erzeugen
        mb = new MenuBar();
        projekt = new Menu("Projekt");
        farben = new Menu("Farben");
        schwarz = new MenuItem("no");
        newTry = new MenuItem("Neu");
        exit = new MenuItem("Beenden");

        //Komponenten zusammenflicken
        farben.add(schwarz);
        projekt.add(newTry);
        projekt.add(exit);
        mb.add(projekt);
        mb.add(farben);
        this.setMenuBar(mb);

        //Event handling
        this.addMouseMotionListener(this);
        schwarz.addActionListener(this);
        newTry.addActionListener(this);
        exit.addActionListener(this);
        this.addWindowListener(this);

        //Werte initialisieren
        xnew = 0;
        ynew = 0;
        xold = 0;
        yold = 0;
        malt = false;
        farbe = Color.BLACK;
    }

    public void start(){
        mal = new Thread(this);
        mal.start();
    }

    public void run(){
        while(true){
            try{
                mal.sleep(3);
            }
            catch (InterruptedException e){
            }
            repaint();
        }
    }

    public void update(Graphics g){
        if(buffer == null){
            buffer = createImage(500, 500);
            bg = buffer.getGraphics();
        }
        paint(bg);
        g.drawImage(buffer, 0, 0, this);
    }

    public void paint(Graphics g){
        if(malt){
            g.setColor(farbe);
            g.drawLine(xold, yold, xnew, ynew);
        }
    }

    public void mouseMoved(MouseEvent e){
        malt = false;
        xold = e.getX();
        yold = e.getY();
    }

    public void mouseDragged(MouseEvent e){
        if(malt){
            xold = xnew;
            yold = ynew;
        } else {
            xold = e.getX();
            yold = e.getY();
        }
        malt = true;
        xnew = e.getX();
        ynew = e.getY();
    }
    public void actionPerformed (ActionEvent e){
        String cmd = e.getActionCommand();
        if(cmd.equals ("Beenden")){
            Frame newF = new Frame();
            JOptionPane.showMessageDialog(newF, "Dieses Feature wurde noch nicht implementiert", "LoL", JOptionPane.ERROR_MESSAGE);
        }
        if(cmd.equals("Neu")){
            bg.setColor(Color.WHITE);
            bg.fillRect(0, 0, 500, 500);
        }
        if(cmd.equals("no")){
            textbox k2 = new textbox();
            k2.setSize(480, 360);
            k2.setTitle("Friendly Reminder");
            k2.setVisible(true);
        }

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