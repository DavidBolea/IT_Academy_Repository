function f_print_first(){
    document.write("<br>");
    document.write("-------------------------Restaurant Fase 1-------------");
    document.write("<br>");
}
var Billets = new Array(7);
var preuTotal = 0.0;
Billets[1] = 5;
Billets[2] = 10;
Billets[3] = 20;
Billets[4] = 50;
Billets[5] = 100;
Billets[6] = 200;
Billets[7] = 500;

var platMenu = new Array(4);
var preuPlat = new Array(4);
function f_print_Second(){
    document.write("S'han creat els següents Arrays:   'Billets' , 'platMenu' i 'preuPlat'");
    document.write("<br>");
    document.write("S'ha creat la Variable: 'preuTotal'");
    document.write("<br>");
    document.write("<br>");
    document.write("-------------------------Restaurant Fase 2-------------");
    document.write("<br>");
}
var f=0;

// eliminar esta seccion

platMenu[0]="Macarrons";
preuPlat[0]= 7.45
platMenu[1]="Ostras";
preuPlat[1]= 12.34
platMenu[2]="Sushi";
preuPlat[2]= 11.7
platMenu[3]="Cargols";
preuPlat[3]= 3.00
platMenu[4]="Calçots";
preuPlat[4]= 3.45


function f_menu(){
    var menu="Menú";
    var menu=menu.bold();
    menu = menu.fontcolor("blue");
    document.write(menu);
    document.write("<br>");
    for(var i=0; i < platMenu.length; i++){
        if(platMenu[i].length >= 8){//imprime en el html
            document.write(platMenu[i] + '&nbsp;' + preuPlat[i] + " Euros");
            document.write("<br>");
        }
        else{
            document.write(platMenu[i] + '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;' + preuPlat[i] + " Euros");
            document.write("<br>");
        }

    }
}
f_print_first();
f_print_Second();
f_menu();

/*-------------------bucle que pregunta los platos del menú y los precios

for(var i = 0; i < platMenu.length; i++){
    f+=1
    platMenu[i] = prompt("Si us plau introdueixi el Nom del plat número: " + f );
    preuPlat[i] = prompt("Si us plau introdueixi el Preu del plat número: " + f );
    if(platMenu[i].length >= 8){
        document.write(platMenu[i] + "\t" + preuPlat[i]);
            document.write("<br>");
    }
    else{
        document.write(platMenu[i] + "\t\t" + preuPlat[i]);
            document.write("<br>");
    }
}
*/
function f_print_Third(){
    document.write("<br>");
    document.write("-------------------------Restaurant Fase 3-------------");
    document.write("<br>");
}
var comanda = new Array();
var pedido =0;
var pedidoString='s';
var compara_Menu_Comanda =0;

setTimeout(function() { Demana_Plats(); }, 1000); // funcion de tiempo...retrasa el prompt que esta en la funcion 'quierePedir' para permitir que imprima la fase 1 y 2 del programa
if(pedido === 1){
    Demana_Plats();
}    
function Demana_Plats(){
    var myComanda = new Array();
    compara_Menu_Comanda=0;
    myComanda= [];
    f_print_first();
    f_print_Second();
    f_menu();

    
    if (window.confirm("Vol demanar?")){
        pedido=1;
    }else{
        window.close();
    }
     //registra los platos que desa pedir
    
    while (pedido===1){
        myComanda.push(prompt("Quin plat desitja?"));
        if (window.confirm("Vol seguir demanant?")){
            pedido=1;
        }
        else{ //al finalizar el pedido, compara los platos con el menu, .....
            pedido=0;
            f_print_Third();
            var titolComanda="Comanda";
            titolComanda=titolComanda.bold();
            titolComanda = titolComanda.fontcolor("green");
            document.write(titolComanda);
            document.write("<br>");
            var plato;
            for(i = 0;i < myComanda.length; i++){
                plato = myComanda[i];
                for(var f = 0;f < platMenu.length; f++){
                    plato = myComanda[i];
                    if(plato == platMenu[f]){
                        compara_Menu_Comanda += 1;
                        preuTotal += preuPlat[f];
                        document.write(plato);
                        document.write("<br>");
                        break;
                    }
                    
                }
                                
            }
            FinComanda(compara_Menu_Comanda,myComanda.length);
            break;
        }
        
   
    }

}
function FinComanda(C_MenuComanda,lComanda){
    if(C_MenuComanda == lComanda){
        preuTotal=Math.round(preuTotal * 100) / 100
        document.write("El preuTotal del que ha demanat es: " + preuTotal + " Euros");

        var calc_Billets = 0.0;
        var resto = 0.0;
        
        for (var i = Billets.length -1 ; i > 0; i--){ // calcula forma de pago
            calc_Billets = preuTotal / Billets[i];
            if (calc_Billets >= 1){
                   
                if (calc_Billets > 1){ //analiza si tiene que pagar con + de 1 billete de este tipo
                       
                    var number = Math.floor(calc_Billets); // nos quedamos con las parte entera del número
                    document.write("<br>");
                    document.write("Has de pagar amb " + number +" billet/s de " + Billets[i] + " Euros.");
                    resto = preuTotal - (Billets[i] * number);
                    if(resto > 5){
                        preuTotal = resto;
                    }else{
                        resto=Math.round(resto * 100) / 100
                        document.write("<br>");
                        document.write("El resto : " + resto + " Euro/s, s'ha de pagar amb monedes.");
                        break;
                    }
                }
            }    
        if(calc_Billets < 1 && i==1){
            document.write("<br>");
            document.write("S'ha de pagar amb monedes.");
            break;
        }
             
        }
    } else {
        pedido=1;
        alert("Un dels plats que ha demanat no existeix! \n" + "Si us plau torni a fer la comanda desde el principi");
        document.body.innerHTML = "";
        Demana_Plats();
    }
}