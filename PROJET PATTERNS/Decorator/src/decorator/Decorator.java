/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package decorator;

/**
 *
 * @author GLOire a DIeu
 */
public class Decorator {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Personne p1=new Personne();
        
        Personne et=new Etudiant();
        
        Personne ens=new Enseignant();
        
        p1.Afficher();
        et.Afficher();
        ens.Afficher();
    }
    
}
