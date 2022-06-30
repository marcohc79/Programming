package com.example.holamundo;

class primeraParte {
    public static void main(String[] args){
        int resultado = 0;
        resultado = suma(2,3,4);
        System.out.println(resultado);
    }
    public static int suma(int a,int b,int c){
        return a + b + c;
    }
}

class segundaParte{
    public static void  main(String[] args){
        Auto miAuto = new Auto();
        miAuto.sumarPuertas();
        System.out.println(miAuto.puertas);
    }
}

class Auto{
    public int puertas = 4;

    public void sumarPuertas(){
        this.puertas++;
    }
}
