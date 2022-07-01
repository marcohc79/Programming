public class ejercicio04 {
    public static void main(String[] args){
        int numeroIf = -1;
        if (numeroIf > 0){
            System.out.println("Es positivo");
        } else if (numeroIf < 0) {
           System.out.println("Es negativo");
        }else {
            System.out.println("0");
        }

        int numeroWhile = 0;
        int numeroWhile2 =2;

        while (numeroWhile <3){
            numeroWhile ++;
            System.out.println(numeroWhile);
        };

        do{
            System.out.println(numeroWhile2);
            numeroWhile2++;
        }while (numeroWhile2 <3);

        for(int numeroFor=0; numeroFor <3; numeroFor++){
            System.out.println("Numero for: " + numeroFor);
        }

        var estacion = "primavera";

        switch (estacion){
            case "verano":
                System.out.println("Verano");
                break;
            case "invierno":
                System.out.println("Invierno");
                break;
            case "primavera":
                System.out.println("Primavera");
                break;
            case "otoño":
                System.out.println("Otoño");
                break;
        }
    }
}
