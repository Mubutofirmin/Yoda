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
public class Personne {
    
    String noms;
    String adresse;
    
    public void Afficher()
    {
        System.out.println("Nom :"+this.noms);
        System.out.println("Adresse :"+this.adresse);
    }
    
}
