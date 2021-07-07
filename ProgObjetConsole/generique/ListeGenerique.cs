using ProgObjetConsole.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObjetConsole.generique
{
    /// <summary>
    /// Classe Generique. T : paramètre de Type!!!
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ListeGenerique<T>
        where T: Personne
    {
        // tableau pour stocker les éléments de la liste 
        private T[] liste;
        // pointeur de position dans la liste 
        private int position;
        // pointeur pour l’ajout d’un nouvel element 
        private int elementSuivant;
        //nombre d’élémments de la liste 
        private int nbElements;
        // dimension de la liste
        private int taille;
        // indique si la liste est pleine 
        private bool complet = false;

        // constructeur avec un parametre permettant de dimensionner la liste 
        public ListeGenerique(int taille)
        {
            liste = new T[taille];
            this.taille = taille;
        }
        public void ajout(T element)
        {
            // on verifie si la liste est complete avant d’ajouter un element 
            if (!complet)
            {
                liste[elementSuivant] = element;
                nbElements = nbElements + 1;
                complet = (nbElements == taille);
                // si la liste n’est pas complete on positionne le pointeur
                // pour l’ajout de l’element suivant 
                if (!complet)
                {
                    elementSuivant = elementSuivant + 1;
                }
            }
        }
        public void supprime(int index)
        {
            int i;
            // on verifie si l’index n’est pas superieur au nombre d’elements
            // si l’index n’est pas inferieur à 0 
            if (index >= nbElements || index < 0)
            {
                return;
            }
            // on decale les elements d’une position vers le haut 
            for (i = index; i <= nbElements - 2; i++)
            {
                liste[i] = liste[i + 1];
            }
            // on positionne le pointeur pour l’ajout d’un nouvel élément 
            elementSuivant = elementSuivant - 1;
            // on met a jour le nombre d’elements 
            nbElements = nbElements - 1;
        }
        public int tailleListe
        {
            get
            {
                return nbElements;
            }
        }
        public T premier()
        {
            if (nbElements == 0)
            {
                throw new Exception("liste vide");
            }
            // on deplace le pointeur sur le premier element 
            position = 0;
            return liste[0];
        }
        public T dernier()
        {
            if (nbElements == 0)
            {
                throw new Exception("liste vide");
            }
            // on deplace le pointeur sur le dernier element
            position = nbElements - 1;
            return liste[position];
        }
        public T suivant()
        {
            if (nbElements == 0)
            {
                throw new Exception("liste vide");
            }
            // on verifie si on n’est pas a la fin de la liste 
            if (position == nbElements - 1)
            {
                throw new Exception("pas d’element suivant");
            }
            // on deplace le pointeur sur l’element suivant 
            position = position + 1;
            return liste[position];
        }
        public T precedent()
        {
            if (nbElements == 0)
            {
                throw new Exception("liste vide");
            }
            // on verifie si on n’est pas sur le premier element 
            if (position == 0)
            {
                throw new Exception("pas d’element precedent");
            }
            // on se deplace sur l’element precedent 
            position = position - 1;
            return liste[position];
        }

    }
}
