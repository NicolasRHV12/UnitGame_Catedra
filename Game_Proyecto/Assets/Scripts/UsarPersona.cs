

using UnityEngine;
using PackegesPersona;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class UsarPerona : MonoBehaviour
{

    List<Estudiante> listaE = new List<Estudiante>(); 
    // Start is called before the first frame update
    void Start()
    {
        Estudiante e1 = new Estudiante("2025_1", " Ing.multimedia","David Castro","dacastro@uao.edu.co","carrera 34");
        Estudiante e2 = new Estudiante("2025_2", " Ing.ambiental", "Sandra Garces", "dsgarces@uao.edu.co", "carrera 14");

        listaE.Add(e1);
        listaE.Add(e2);

        for(int i = 0; i < listaE.Count; i++)
        {
            Debug.Log(listaE[i].NameP + "" + listaE[i].NameCarrera);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
