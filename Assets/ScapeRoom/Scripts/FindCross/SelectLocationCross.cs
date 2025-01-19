using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectLocationCross : MonoBehaviour
{
    class Registro{
        public int DatoX {set; get;}
        public int DatoZ {set; get;}

        public Registro (int dato1, int dato2) {
            DatoX = dato1;
            DatoZ = dato2;
        }
    }

    void Start()
    {
        print("FindCross");

        // Lista de posiciones en el escenario
        List<Registro> registros = new List<Registro>
        {
            new Registro(15,-10),
            new Registro(9,-11),
            new Registro(-12,0),
            new Registro(0,-10),
            new Registro(15,-16),
            new Registro(-10,12),
            //new Registro(10,10)
        };

        // Elige aleatoriamente una posicion de la lista
        int vIndiceRandom = Random.Range(0, registros.Count);
        Registro vRegistroRandom = registros[vIndiceRandom];
        print("X= " + vRegistroRandom.DatoX + " Z= " + vRegistroRandom.DatoZ);
        
        // Toma la posicion actual del  objeto
        Vector3 vPosicion = transform.position;
        // Cambia la posicion del objeto en los ejes X y Z
        vPosicion.x = vRegistroRandom.DatoX;
        vPosicion.z = vRegistroRandom.DatoZ;
        transform.position = vPosicion;
        
    }

    void Update()
    {
        
    }
}
