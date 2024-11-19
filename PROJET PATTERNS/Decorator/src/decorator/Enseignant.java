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
public class Enseignant extends Personne {
    
    String poste;

    @Override
    public void Afficher() {
        super.Afficher(); //To change body of generated methods, choose Tools | Templates.
        System.out.println("Poste : "+this.poste);
    }
    
    
}
