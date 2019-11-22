console.log("");
console.log("-------------------------Ciutats Fase 1-------------");
console.log("");
var nomCiutat1, nomCiutat2, nomCiutat3, nomCiutat4, nomCiutat5,nomCiutat6;

//no hay inputs en la consola introducimos los datos de las ciudades:

nomCiutat1="Barcelona";
nomCiutat2="Madrid";
nomCiutat3="València";
nomCiutat4="Màlaga";
nomCiutat5="Càdis";
nomCiutat6="Santander";



console.log(nomCiutat1);
console.log(nomCiutat2);
console.log(nomCiutat3);
console.log(nomCiutat4);
console.log(nomCiutat5);
console.log(nomCiutat6);

console.log("");
console.log("-------------------------Ciutats Fase 2-------------");
console.log("");
var arrayCiutats=new Array(5);//crea un nuevo array y pasa los nombres de ciutat*
arrayCiutats[0]=nomCiutat1;
arrayCiutats[1]=nomCiutat2;
arrayCiutats[2]=nomCiutat3;
arrayCiutats[3]=nomCiutat4;
arrayCiutats[4]=nomCiutat5;
arrayCiutats[5]=nomCiutat6;
arrayCiutats.sort();
arrayCiutats.forEach(function(clave) {   //imprime el array
  console.log(clave);
});

console.log("");
console.log("-------------------------Ciutats Fase 3-------------");
console.log("");
var i=0;
var ArrayCiutatsModificades = new Array(arrayCiutats.length)
function eliminarDiacriticos(texto) {// funcion para quitar los acentos
  return texto.normalize('NFD').replace(/[\u0300-\u036f]/g,"");
}
arrayCiutats.forEach(function(clave, valor) {  //lama a funcion 'eliminarDiacriticos' y  remplaza la letra 'a' x '4' 
  ArrayCiutatsModificades[i]= eliminarDiacriticos(clave);
  ArrayCiutatsModificades[i]= ArrayCiutatsModificades[i].replace(/a/g, "4");
  console.log(ArrayCiutatsModificades[i]);
  i+=i;
});
console.log("");
console.log("-------------------------Ciutats Fase 4-------------");
console.log("");
var nomCiutatinvertit1 = new Array(nomCiutat1.leng);
var nomCiutatinvertit2 = new Array(nomCiutat2.leng);
var nomCiutatinvertit3 = new Array(nomCiutat3.leng);
var nomCiutatinvertit4 = new Array(nomCiutat4.leng);
var nomCiutatinvertit5 = new Array(nomCiutat5.leng);
var nomCiutatinvertit6 = new Array(nomCiutat6.leng);


var printHorizontal="";
var f = 0;

for(i = arrayCiutats[0].length - 1; i >= 0; i--) {//rellena nomCiutatinvetit con las letras en orden descendiente
  nomCiutatinvertit1[f] = arrayCiutats[0].substring(i,i+1);
   printHorizontal+=nomCiutatinvertit1[f];
   f += 1;
   if (i<1){
        printHorizontal=arrayCiutats[0] + " - " + printHorizontal;
        console.log(printHorizontal);
        printHorizontal=""
   }
   
}
for(i = arrayCiutats[1].length - 1; i >= 0; i--) {//rellena nomCiutatinvetit con las letras en orden descendiente
  nomCiutatinvertit2[f] = arrayCiutats[1].substring(i,i+1);
   printHorizontal+=nomCiutatinvertit2[f];
   f += 1;
   if (i<1){
        printHorizontal=arrayCiutats[1] + " - " + printHorizontal;
        console.log(printHorizontal);
        printHorizontal=""
   }
   
}
for(i = arrayCiutats[2].length - 1; i >= 0; i--) {//rellena nomCiutatinvetit con las letras en orden descendiente
  nomCiutatinvertit3[f] = arrayCiutats[2].substring(i,i+1);
   printHorizontal+=nomCiutatinvertit3[f];
   f += 1;
   if (i<1){
        printHorizontal=arrayCiutats[2] + " - " + printHorizontal;
        console.log(printHorizontal);
        printHorizontal=""
   }
   
}
for(i = arrayCiutats[3].length - 1; i >= 0; i--) {//rellena nomCiutatinvetit con las letras en orden descendiente
  nomCiutatinvertit4[f] = arrayCiutats[3].substring(i,i+1);
   printHorizontal+=nomCiutatinvertit4[f];
   f += 1;
   if (i<1){
        printHorizontal=arrayCiutats[3] + " - " + printHorizontal;
        console.log(printHorizontal);
        printHorizontal=""
   }
   
}
for(i = arrayCiutats[4].length - 1; i >= 0; i--) {//rellena nomCiutatinvetit con las letras en orden descendiente
  nomCiutatinvertit5[f] = arrayCiutats[4].substring(i,i+1);
   printHorizontal+=nomCiutatinvertit5[f];
   f += 1;
   if (i<1){
        printHorizontal=arrayCiutats[4] + " - " + printHorizontal;
        console.log(printHorizontal);
        printHorizontal=""
   }
   
}
for(i = arrayCiutats[5].length - 1; i >= 0; i--) {//rellena nomCiutatinvetit con las letras en orden descendiente
  nomCiutatinvertit1[6] = arrayCiutats[5].substring(i,i+1);
   printHorizontal+=nomCiutatinvertit1[6];
   f += 1;
   if (i<1){
        printHorizontal=arrayCiutats[5] + " - " + printHorizontal;
        console.log(printHorizontal);
        printHorizontal=""
   }
   
}



