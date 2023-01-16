using System.Collections.Generic;
using System;

class fordon{
    private string tillverkare;
    private string bilmodel;
    private int år;
    private int vikt;
    
// properties
    public string Tillverkare{
        get{return tillverkare;}
        set{ tillverkare=value;}
    }
      public string Bilmodel{
        get{return bilmodel;}
        set{ bilmodel=value;}
    }
      public int År{
        get{return år;}
        set{ år=value;}
    }
     public int Vikt{
        get{return vikt;}
        set{ vikt=value;}
    }

    // metod för att få variabel till varje objekt 
    public fordon(string t, string b, int å, int v){
        tillverkare=t;
        bilmodel= b;
        år=å;
        vikt=v;
    }
     }                                  
    
class program{
    public static void Main(){
     
     // skapa lista föratt kunna lägga och ta bort objekt

    List <fordon> list= new List<fordon>();
      fordon f= new fordon("Jeff 1","BMW Z", 2018, 67 );
        list.Add(f);

        fordon r= new fordon("Jeff 3", "Benz C",2005, 785 );
        list.Add(r);

        foreach (fordon element in list){
            Console.WriteLine(element.Tillverkare);
            Console.WriteLine(element.Bilmodel);
            Console.WriteLine(element.År);
            Console.WriteLine(element.Vikt);
        }
    }
    }             
